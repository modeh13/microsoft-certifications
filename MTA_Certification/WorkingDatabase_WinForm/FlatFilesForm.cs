using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WorkingDatabase_WinForm
{
   public partial class FlatFilesForm : Form
   {
      const string ConnectionString = "Data Source=FAMILIA; User Id=sa; Password=Sigma1702*; Initial Catalog=Northwind";
      const string TextFilesFolder = "TextFiles";

      public FlatFilesForm()
      {
         InitializeComponent();
         lblResult.Text = string.Empty;
      }

      private DataTable GetCustomers()
      {
         DataTable data = new DataTable();
         SqlConnection sqlConnection = null;

         try
         {
            const string querySql = "SELECT CustomerId, CompanyName, ContactName, Phone FROM Customers";
            sqlConnection = new SqlConnection(ConnectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(querySql, sqlConnection);
            adapter.Fill(data);
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally {
            if (sqlConnection?.State == ConnectionState.Open)
            {
               sqlConnection.Close();
            }
         }

         return data;
      }


      private void btnTextFiles_Click(object sender, EventArgs e)
      {
         string baseDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, TextFilesFolder);
         string filePath = Path.Combine(baseDirectory, "CustomerList.txt");
         DataTable data = GetCustomers();

         if (data?.Rows.Count > 0)
         {
            if (!Directory.Exists(baseDirectory)) {
               Directory.CreateDirectory(baseDirectory);
            }

            using (StreamWriter sw = new StreamWriter(filePath, true, Encoding.UTF8))
            {
               string fileLine = string.Empty;

               foreach (DataRow dataRow in data.Rows)
               {
                  fileLine = string.Format("{0}, {1}, {2}, {3}", dataRow["CustomerId"], dataRow["CompanyName"], dataRow["ContactName"], dataRow["Phone"]);
                  sw.WriteLine(fileLine);
               }
            }

            lblResult.Text = $"{data.Rows.Count} customers were saved.";
         }
         else {
            MessageBox.Show("Customers not found.");
         }

      }

      private void btnReadFile_Click(object sender, EventArgs e)
      {
         string baseDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, TextFilesFolder);
         string filePath = Path.Combine(baseDirectory, "CustomerList.txt");

         if (File.Exists(filePath))
         {
            lvwContent.Items.Clear();

            using (StreamReader sr = new StreamReader(filePath))
            {
               while (!sr.EndOfStream) {
                  lvwContent.Items.Add(sr.ReadLine());
               }
            }
         }
         else {
            MessageBox.Show($"The {Path.GetFileNameWithoutExtension(filePath)} file doesn't exist.");
         }
      }
   }
}