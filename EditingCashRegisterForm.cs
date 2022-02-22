using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Supermarket
{
    public partial class EditingCashRegisterForm : Form
    {
        public EditingCashRegisterForm()
        {
            InitializeComponent();
        }

        private void EditingCashRegisterForm_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = Connection.dataSet.Tables["CashRegister"];
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;

            textBoxCashRegisterID.DataBindings.Add("Text", bindingSource1, "CashRegisterID");
            textBoxCashRegisterNumber.DataBindings.Add("Text", bindingSource1, "CashRegisterNumber");
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

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM CashRegister", Connection.connection);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(sqlDataAdapter);

                sqlDataAdapter.Update(Connection.dataSet.Tables["CashRegister"]);

                MessageBox.Show("Сохранено");
            }
            catch (Exception ex)
            {
                Connection.dataSet.Tables["CashRegister"].RejectChanges();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
