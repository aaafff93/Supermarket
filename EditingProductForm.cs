using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using ZXing;

namespace Supermarket
{
    public partial class EditingProductForm : Form
    {
        public EditingProductForm()
        {
            InitializeComponent();
        }

        private void EditingProductForm_Load(object sender, EventArgs e)
        {
            pictureBoxImage.AllowDrop = true;

            bindingSource1.DataSource = Connection.dataSet.Tables["Product"];
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;

            textBoxProductID.DataBindings.Add("Text", bindingSource1, "ProductID");
            textBoxEncodeBarecode.DataBindings.Add("Text", bindingSource1, "Barecode");
            pictureBoxImage.DataBindings.Add("Image", bindingSource1, "Image", true); //картинка декодируется сама
            textBoxName.DataBindings.Add("Text", bindingSource1, "Name");
            textBoxPrice.DataBindings.Add("Text", bindingSource1, "Price");
            textBoxWt.DataBindings.Add("Text", bindingSource1, "Wt");   
            textBoxRevenue.DataBindings.Add("Text", bindingSource1, "Revenue");
        }

        private void ButtonEncode_Click(object sender, EventArgs e)
        {
            try
            {
                BarcodeWriter barcodeWriter = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 };
                pictureBoxBarcode.Image = barcodeWriter.Write(textBoxEncodeBarecode.Text);
            }
            catch
            {
                MessageBox.Show("Введите штрих-код");
            }
        }

        private void ButtonSaveBarcode_Click(object sender, EventArgs e)
        {
            if (pictureBoxBarcode.Image != null)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureBoxBarcode.Image.Save(saveFileDialog1.FileName + ".jpeg");
                        MessageBox.Show("Сохранено");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }      

        private void ButtonInsert_Click(object sender, EventArgs e)
        {
            bindingSource1.AddNew();           
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            bindingSource1.Remove(bindingSource1.Current);
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                bindingSource1.EndEdit();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Product", Connection.connection);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(sqlDataAdapter);

                sqlDataAdapter.Update(Connection.dataSet.Tables["Product"]);

                MessageBox.Show("Сохранено");
            }
            catch (Exception ex)
            {
                Connection.dataSet.Tables["Product"].RejectChanges();
                MessageBox.Show(ex.Message);
            }

        }

        private void PictureBoxImage_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                var fileNames = data as string[];
                if (fileNames.Length > 0)
                {
                    pictureBoxImage.Image = Image.FromFile(fileNames[0]);
                }
            }
        }

        private void PictureBoxImage_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }    

    }
}
