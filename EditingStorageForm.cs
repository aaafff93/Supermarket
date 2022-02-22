using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Supermarket
{
    public partial class EditingStorageForm : Form
    {
        public EditingStorageForm()
        {
            InitializeComponent();
        }

        private void EditingStorageForm_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = Connection.dataSet.Tables["Storage"];
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;

            textBoxName.DataBindings.Add("Text", bindingSource1, "Name");
            textBoxQuantity.DataBindings.Add("Text", bindingSource1, "Quantity");
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

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Storage", Connection.connection);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(sqlDataAdapter);

                sqlDataAdapter.Update(Connection.dataSet.Tables["Storage"]);

                MessageBox.Show("Сохранено");
            }
            catch (Exception ex)
            {
                Connection.dataSet.Tables["Storage"].RejectChanges();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
