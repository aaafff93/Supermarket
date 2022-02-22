using Newtonsoft.Json;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Supermarket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
        }

        public void RefreshDB()
        {
            Connection.Connect(); //подключение

            comboBox1.DisplayMember = "Connection.dataSet.Tables.TableName";
            comboBox1.Items.Clear();            
           
            for (int i = 0; i < Connection.dataSet.Tables.Count; i++)
            {
                comboBox1.Items.Add(Connection.dataSet.Tables[i]);
            }           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Media.SoundPlayer soundBarcodeRead = new System.Media.SoundPlayer(@"../../_Sounds/soundOpen.wav");
            soundBarcodeRead.Play();

            RefreshDB();           
        }

        private void ButtonOpenCashRegisters_Click(object sender, EventArgs e)
        {
            CashRegisterForm1 cashRegisterForm1 = new CashRegisterForm1();
            cashRegisterForm1.Show();

            CashRegisterForm2 cashRegisterForm2 = new CashRegisterForm2();
            cashRegisterForm2.Show();

            CashRegisterForm3 cashRegisterForm3 = new CashRegisterForm3();
            cashRegisterForm3.Show();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = comboBox1.SelectedItem;           
        }       

        //редактирование кассиров
        private void ButtonEditCashiers_Click(object sender, EventArgs e)
        {
            EditingCashierForm editingCashierForm = new EditingCashierForm();
            editingCashierForm.ShowDialog();
        }

        //редактирование касс
        private void ButtonEditCashRegister_Click(object sender, EventArgs e)
        {
            EditingCashRegisterForm editingCashRegisterForm = new EditingCashRegisterForm();
            editingCashRegisterForm.ShowDialog();
        }

        //редактирование товаров
        private void ButtonEditProduct_Click(object sender, EventArgs e)
        {
            EditingProductForm editingProductForm = new EditingProductForm();
            editingProductForm.ShowDialog();
        }

        //редактирование продаж
        private void ButtonEditSales_Click(object sender, EventArgs e)
        {
            EditingSalesForm editingSalesForm = new EditingSalesForm();
            editingSalesForm.ShowDialog();

        }

        //редактирование склада
        private void ButtonEditStorage_Click(object sender, EventArgs e)
        {
            EditingStorageForm editingStorageForm = new EditingStorageForm();
            editingStorageForm.ShowDialog();
        }

        //из БД в JSON 
        private void ButtonFromDBToJson_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName + ".json", false, Encoding.Default))
                    {
                        string JSONString = JsonConvert.SerializeObject(comboBox1.SelectedItem, Formatting.Indented);
                        sw.Write(JSONString);
                        MessageBox.Show("Сохранено по адресу: " + saveFileDialog1.FileName + ".json");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        //из БД в XML
        private void ButtonFromDBToXML_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ((DataTable)comboBox1.SelectedItem).WriteXml(saveFileDialog1.FileName + ".xml");
                    MessageBox.Show("Сохранено по адресу: " + saveFileDialog1.FileName + ".xml");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //из JSON в БД
        private void ButtonImportFromJSON_Click(object sender, EventArgs e)
        {
            try
            {
                string JSONString = null;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader sr = new StreamReader(openFileDialog1.FileName, Encoding.Default))
                    {
                        JSONString = sr.ReadToEnd();
                    }

                    DataTable dataTable = JsonConvert.DeserializeObject<DataTable>(JSONString);

                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        dataTable.Rows[i][0] = Connection.dataSet.Tables[comboBox1.SelectedIndex].Rows.Count + 1;
                        Connection.dataSet.Tables[comboBox1.SelectedIndex].ImportRow(dataTable.Rows[i]);
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Выберите таблицу");
            }
            catch (JsonReaderException)
            {
                MessageBox.Show("Выбран неправильный файл");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //из XML в БД
        private void ButtonImportFromXML_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    DataSet dataSetXML = new DataSet();

                    dataSetXML.ReadXml(openFileDialog1.FileName);

                    for (int i = 0; i < dataSetXML.Tables[0].Rows.Count; i++)
                    {
                        dataSetXML.Tables[0].Rows[i][0] = Connection.dataSet.Tables[comboBox1.SelectedIndex].Rows.Count + 1;
                        dataSetXML.Tables[0].Rows[i]["Revenue"] = dataSetXML.Tables[0].Rows[i]["Revenue"].ToString().Replace('.', ',');
                        //dataSetXML.Tables[0].Rows[i]["Price"] = dataSetXML.Tables[0].Rows[i]["Revenue"].ToString().Replace('.', ',');
                        var s =  Connection.dataSet.Tables[comboBox1.SelectedIndex];
                        Connection.dataSet.Tables[comboBox1.SelectedIndex].ImportRow(dataSetXML.Tables[0].Rows[i]);
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Выберите таблицу");
            }
            catch (System.Xml.XmlException)
            {
                MessageBox.Show("Выбран неправильный файл");
            }
            catch (Exception ex) //?
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //сохранение в БД
        private void SaveToDatabase(string tableName)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"SELECT * FROM {tableName}", Connection.connection);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            //MessageBox.Show(commandBuilder.GetInsertCommand().CommandText); //вывести команду
            sqlDataAdapter.Update(Connection.dataSet.Tables[$"{tableName}"]);           
        }

        //кнопка сохранения
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < Connection.dataSet.Tables.Count; i++)
                {
                    SaveToDatabase(Connection.dataSet.Tables[i].TableName);
                }
                MessageBox.Show("Сохранено");
            }
            catch (SqlException)
            {
                MessageBox.Show("Выбран неправильный файл");
                Connection.dataSet.RejectChanges();
            }
        }

        //отмена изменений
        private void ButtonRegectChanges_Click(object sender, EventArgs e)
        {
            Connection.dataSet.RejectChanges();
            MessageBox.Show("Изменения отменены");
        }

        private void TabControl1_Selected(object sender, TabControlEventArgs e)
        {
            //сумма в целом для всех товаров
            textBoxTotalRevenue.Text = Connection.dataSet.Tables["Product"].Compute("Sum(Revenue)", string.Empty).ToString();
        }
    }
}
