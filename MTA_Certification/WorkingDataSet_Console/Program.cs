using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingDataSet_Console
{
   class Program
   {
      const string ConnectionString = "Data Source=FAMILIA; User Id=sa; Password=Sigma1702*; Initial Catalog=Northwind";

      static void Main(string[] args)
      {
         WorkingWithDataSet();
      }

      /// <summary>
      /// Get Customers and Orders data from DataBase and use DataSet object to create a relationship to print Orders by Customer.
      /// </summary>
      private static void WorkingWithDataSet()
      {
         const string queryCustomers = "SELECT * FROM Customers";
         const string queryOrders = "SELECT * FROM Orders";

         SqlConnection sqlConnection = new SqlConnection(ConnectionString);
         SqlDataAdapter customersAdapter = new SqlDataAdapter(queryCustomers, sqlConnection);
         SqlDataAdapter ordersAdapter = new SqlDataAdapter(queryOrders, sqlConnection);

         DataSet customerOrders = new DataSet();
         customersAdapter.Fill(customerOrders, "Customers");
         ordersAdapter.Fill(customerOrders, "Orders");

         DataRelation relation = customerOrders.Relations.Add("CustomerOrders", 
                                                               customerOrders.Tables["Customers"].Columns["CustomerID"],
                                                               customerOrders.Tables["Orders"].Columns["CustomerID"]);

         foreach (DataRow customerRow in customerOrders.Tables["Customers"].Rows)
         {
            Console.WriteLine("Customer Id: " + customerRow["CustomerID"]);

            foreach (DataRow orderRow in customerRow.GetChildRows(relation))
               Console.WriteLine("\t" + orderRow["OrderID"]);
         }

         Console.WriteLine("Press any key to continue...");
         Console.ReadKey();
      }
   }
}