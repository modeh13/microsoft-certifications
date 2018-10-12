using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WorkingDatabase_WinForm
{
   public partial class MainForm : Form
   {
      public MainForm()
      {
         InitializeComponent();         
      }

      #region Methods
      private void ExecuteQuery(string sql)
      {
         try
         {
            const string connectionString = "Data Source=FAMILIA; User Id=sa; Password=Sigma1702*; Initial Catalog=Northwind;";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connectionString);
            DataTable data = new DataTable();
            adapter.Fill(data);
            dgwResult.DataSource = data;
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }
      #endregion

      #region Events
      private void btnExecute_Click(object sender, EventArgs e)
      {
         if (!string.IsNullOrEmpty(txtSqlStatament.Text))
         {
            ExecuteQuery(txtSqlStatament.Text.Trim());
         }
      } 
      #endregion
   }
}