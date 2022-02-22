using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Supermarket
{
    public partial class EditingCashierForm : Form
    {
        public EditingCashierForm()
        {
            InitializeComponent();          
        }

        private void EditingCashierForm_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = Connection.dataSet.Tables["Cashier"];
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;

            textBoxCashierID.DataBindings.Add("Text", bindingSource1, "CashierID");
            textBoxFIO.DataBindings.Add("Text", bindingSource1, "FIO");
            textBoxRevenue.DataBindings.Add("Text", bindingSource1, "Revenue");
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

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Cashier", Connection.connection);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(sqlDataAdapter);

                sqlDataAdapter.Update(Connection.dataSet.Tables["Cashier"]);

                MessageBox.Show("Сохранено");
            }
            catch (Exception ex)
            {
                Connection.dataSet.Tables["Cashier"].RejectChanges();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
