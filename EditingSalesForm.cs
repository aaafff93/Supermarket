using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Supermarket
{
    public partial class EditingSalesForm : Form
    {
        public EditingSalesForm()
        {
            InitializeComponent();
        }
        private void EditingSalesForm_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = Connection.dataSet.Tables["Sales"];
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;

            textBoxSalesID.DataBindings.Add("Text", bindingSource1, "SalesID");
            textBoxCashierID.DataBindings.Add("Text", bindingSource1, "CashierID");
            textBoxCashRegisterID.DataBindings.Add("Text", bindingSource1, "CashRegisterID");
            textBoxProductID.DataBindings.Add("Text", bindingSource1, "ProductID");
            textBoxTimeOfSale.DataBindings.Add("Text", bindingSource1, "TimeOfSale");
            textBoxQuantity.DataBindings.Add("Text", bindingSource1, "Quantity");
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

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Sales", Connection.connection);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(sqlDataAdapter);

                sqlDataAdapter.Update(Connection.dataSet.Tables["Sales"]);

                MessageBox.Show("Сохранено");
            }
            catch (Exception ex)
            {
                Connection.dataSet.Tables["Sales"].RejectChanges();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
