using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WorkingDatabase_WinForm
{
   public partial class GetTotalSalesForm : Form
   {
      public GetTotalSalesForm()
      {
         InitializeComponent();
         lblTotalSales.Text = string.Empty;
      }

      #region Methods
      private string GetTotalSales(string customerId)
      {
         string totalSales = string.Empty;
         const string connectionString = "Data Source=FAMILIA; User Id=sa; Password=Sigma1702*; Initial Catalog=Northwind;";
         SqlConnection sqlConnection = null;

         try
         {
            sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand()
            {
               Connection = sqlConnection,
               CommandText = "dbo.GetCustomerSales",
               CommandType = CommandType.StoredProcedure
            };
            sqlCommand.Parameters.Add(new SqlParameter("@CustomerId", customerId));
            sqlCommand.Parameters.Add(new SqlParameter()
            {
               ParameterName = "@TotalSales",
               SqlDbType = SqlDbType.Money,
               Direction = ParameterDirection.Output
            });

            //This way, we guarantee that the object SqlConnection is delivered once it has finished.
            using (sqlConnection)
            {
               sqlConnection.Open();
               int rowsAffected = sqlCommand.ExecuteNonQuery();
               totalSales = sqlCommand.Parameters["@TotalSales"].Value.ToString();
               sqlConnection.Close();
            }

            //Using this way, we need to make sure the CLOSE database connection.
            //sqlConnection.Open();
            //int rowsAffected = sqlCommand.ExecuteNonQuery();
            //totalSales = sqlCommand.Parameters["@TotalSales"].Value.ToString();
            //sqlConnection.Close();
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            if (sqlConnection?.State == ConnectionState.Open)
            {
               sqlConnection.Close();
            }
         }

         return totalSales;
      }
      #endregion

      #region Events
      private void btnExecute_Click(object sender, EventArgs e)
      {
         if (!string.IsNullOrEmpty(txtCustomerId.Text))
         {
            string totalSales = GetTotalSales(txtCustomerId.Text);

            if (!string.IsNullOrEmpty(totalSales)) {
               lblTotalSales.Text = string.Format("Total sales: {0}", double.Parse(totalSales));
            }
         }
      } 
      #endregion
   }
}