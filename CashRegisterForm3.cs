using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace Supermarket
{
    public partial class CashRegisterForm3 : Form
    {
        string decodeBarcode = null;
        public CashRegisterForm3()
        {
            InitializeComponent();
        }

        private void CashRegisterForm3_Load(object sender, EventArgs e)
        {
            pictureBoxBarcode.AllowDrop = true;

            comboBox1.Items.Clear();

            foreach (DataRow row in Connection.dataSet.Tables["Cashier"].Rows)
            {
                comboBox1.Items.Add(row["FIO"]);
            }

            comboBox1.SelectedIndex = 0;
        }

        private void PictureBoxBarcode_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                var fileNames = data as string[];
                if (fileNames.Length > 0)
                {
                    pictureBoxBarcode.Image = Image.FromFile(fileNames[0]);
                }
            }

            BarcodeReader barcodeReader = new BarcodeReader();
            var decodeBarcodeResult = barcodeReader.Decode((Bitmap)pictureBoxBarcode.Image);
            if (decodeBarcodeResult != null)
            {
                decodeBarcode = decodeBarcodeResult.ToString();
            }

            pictureBoxImage.InitialImage = null;

            try
            {
                byte[] imageByte = (byte[])Connection.dataSet.Tables["Product"].Select($"Barecode = '{decodeBarcode}'")[0]["Image"];
                MemoryStream memoryStream = new MemoryStream(imageByte);
                pictureBoxImage.Image = Image.FromStream(memoryStream);
            }
            catch
            {
                pictureBoxImage.Image = null;
                pictureBoxBarcode.Image = null;
                numericUpDown1.Value = 1;
                MessageBox.Show("Неправильный штрих-код");
            }
        }

        private void PictureBoxBarcode_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        //сохранение в бд
        private void SaveToDatabase(string tableName)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"SELECT * FROM {tableName}", Connection.connection);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            sqlDataAdapter.Update(Connection.dataSet.Tables[$"{tableName}"]);
        }

        private void MakePurchaseButton_Click(object sender, EventArgs e)
        {
            int storageQuantity = -1;
            string currentProduct = null;

            try
            {
                currentProduct = Connection.dataSet.Tables["Product"].Select($"Barecode = '{decodeBarcode}'")[0]["Name"].ToString();
                storageQuantity = Int32.Parse(Connection.dataSet.Tables["Storage"].Select($"Name = '{currentProduct}'")[0]["Quantity"].ToString());
            }
            catch
            {
                //MessageBox.Show("Перетащите штрих-код");
            }

            //сравнение выбранных товаров с количеством на складе
            if (storageQuantity >= Int32.Parse(numericUpDown1.Value.ToString()) && pictureBoxImage.Image != null)
            {

                try
                {
                    int salesID = -1;

                    if (Connection.dataSet.Tables["Sales"].Rows.Count == 0)
                    {
                        salesID = 1;
                    }
                    else
                    {
                        salesID = Int32.Parse(Connection.dataSet.Tables["Sales"].Rows[Connection.dataSet.Tables["Sales"].Rows.Count - 1][0].ToString()) + 1;
                    }

                    DataRow cashierIDRow = Connection.dataSet.Tables["Cashier"].Select($"FIO = '{comboBox1.SelectedItem}'")[0];
                    int cashierID = Int32.Parse(cashierIDRow["CashierID"].ToString());

                    int cashRegisterID = 3; //тут

                    DataRow productRow = Connection.dataSet.Tables["Product"].Select($"Barecode = '{decodeBarcode}'")[0];
                    int productID = Int32.Parse(productRow["ProductID"].ToString());

                    string timeOfSale = DateTime.Now.ToString("s");

                    string quantity = numericUpDown1.Value.ToString();

                    decimal currentRevenue = (decimal.Parse(productRow["Price"].ToString()) * numericUpDown1.Value);

                    //вставка новой продажи
                    Connection.dataSet.Tables["Sales"].Rows.Add(salesID, cashierID, cashRegisterID, productID, timeOfSale, quantity, currentRevenue);

                    //подсчёт выручки для каждой кассы                
                    decimal cashRegisterRevenue = decimal.Parse(Connection.dataSet.Tables["CashRegister"].Select($"CashRegisterID = 3")[0]["Revenue"].ToString()); //и тут
                    cashRegisterRevenue = decimal.Add(cashRegisterRevenue, currentRevenue);
                    Connection.dataSet.Tables["CashRegister"].Select($"CashRegisterID = 3")[0]["Revenue"] = cashRegisterRevenue; //и тут

                    //подсчёт выручки по каждому товару
                    decimal productRevenue = decimal.Parse(Connection.dataSet.Tables["Product"].Select($"Barecode = '{decodeBarcode}'")[0]["Revenue"].ToString());
                    productRevenue = decimal.Add(productRevenue, currentRevenue);
                    Connection.dataSet.Tables["Product"].Select($"Barecode = '{decodeBarcode}'")[0]["Revenue"] = productRevenue;

                    //подсчёт выручки для каждого кассира
                    decimal cashierRevenue = decimal.Parse(Connection.dataSet.Tables["Cashier"].Select($"FIO = '{comboBox1.SelectedItem.ToString()}'")[0]["Revenue"].ToString());
                    cashierRevenue = decimal.Add(cashierRevenue, currentRevenue);
                    Connection.dataSet.Tables["Cashier"].Select($"FIO = '{comboBox1.SelectedItem.ToString()}'")[0]["Revenue"] = cashierRevenue;

                    //после добавления?
                    try
                    {
                        //уменьшение количества на складе
                        storageQuantity = storageQuantity - (int)numericUpDown1.Value;
                        Connection.dataSet.Tables["Storage"].Select($"Name = '{currentProduct}'")[0]["Quantity"] = storageQuantity;
                        for (int i = 0; i < Connection.dataSet.Tables.Count; i++)
                        {
                            SaveToDatabase(Connection.dataSet.Tables[i].TableName);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        Connection.dataSet.RejectChanges();
                    }

                }
                catch (IndexOutOfRangeException)
                {
                    pictureBoxBarcode.Image = null;
                    numericUpDown1.Value = 1;
                    Connection.dataSet.RejectChanges();
                    MessageBox.Show("Такого штрих-кода нет");
                }
                catch (System.FormatException ex)
                {
                    pictureBoxBarcode.Image = null;
                    numericUpDown1.Value = 1;
                    Connection.dataSet.RejectChanges();
                    MessageBox.Show(ex.Message);
                }

                pictureBoxImage.Image = null;
                pictureBoxBarcode.Image = null;
                numericUpDown1.Value = 1;

                System.Media.SoundPlayer soundBarcodeRead = new System.Media.SoundPlayer(@"../../_Sounds/soundBarcodeRead.wav");
                soundBarcodeRead.Play();
            }
            else if (pictureBoxImage.Image == null)
            {
                MessageBox.Show("Перетащите штрих-код");
            }
            else
            {
                System.Media.SoundPlayer soundBarcodeRead = new System.Media.SoundPlayer(@"../../_Sounds/soundEmptyStorage.wav");
                soundBarcodeRead.Play();               

                MessageBox.Show(
                    $"Такого количества ({numericUpDown1.Value}) товара '{currentProduct}' нет на складе. " +
                    $"Имеется: ({Int32.Parse(Connection.dataSet.Tables["Storage"].Select($"Name = '{currentProduct}'")[0]["Quantity"].ToString())})");

                pictureBoxImage.Image = null;
                pictureBoxBarcode.Image = null;
                numericUpDown1.Value = 1;
            }
        }
    }
}
