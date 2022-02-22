using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Supermarket
{
    static class Connection //статический класс для подключения
    {
        //public static string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Supermarket;Integrated Security=True";
        public static string connectionString = File.ReadAllText("../../_Connection/connectionString.txt");
        public static string sql = @"
SELECT * FROM Cashier
SELECT * FROM CashRegister;
SELECT * FROM Product
SELECT * FROM Sales
SELECT * FROM Storage";
        public static SqlConnection connection;
        public static SqlDataAdapter sqlDataAdapter;
        public static DataSet dataSet;

        public static void Connect()
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();

                sqlDataAdapter = new SqlDataAdapter(sql, connection);

                sqlDataAdapter.InsertCommand = new SqlCommandBuilder(sqlDataAdapter).GetInsertCommand();
                sqlDataAdapter.UpdateCommand = new SqlCommandBuilder(sqlDataAdapter).GetUpdateCommand();
                sqlDataAdapter.DeleteCommand = new SqlCommandBuilder(sqlDataAdapter).GetDeleteCommand();

                dataSet = new DataSet();

                sqlDataAdapter.TableMappings.Add("Table", "Cashier");
                sqlDataAdapter.TableMappings.Add("Table1", "CashRegister");
                sqlDataAdapter.TableMappings.Add("Table2", "Product");
                sqlDataAdapter.TableMappings.Add("Table3", "Sales");
                sqlDataAdapter.TableMappings.Add("Table4", "Storage");

                sqlDataAdapter.Fill(dataSet);

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
