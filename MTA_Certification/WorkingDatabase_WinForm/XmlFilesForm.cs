using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace WorkingDatabase_WinForm
{
   public partial class XmlFilesForm : Form
   {
      const string XmlFilesFolder = "files";

      public XmlFilesForm()
      {
         InitializeComponent();
      }

      /// <summary>
      /// Using XMLReader class to read a XML file.      
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void btnReadXml_Click(object sender, EventArgs e)
      {
         const string xmlFile = "Customers.xml";
         string filesDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, XmlFilesFolder);
         string filePath = Path.Combine(filesDirectory, xmlFile);

         if (File.Exists(filePath))
         {
            using (XmlReader xmlReader = XmlReader.Create(filePath))
            {
               lvwCustomers.Items.Clear();

               while (xmlReader.Read())
               {
                  if (xmlReader.IsStartElement())
                  {
                     switch (xmlReader.Name)
                     {
                        case "Customer":
                           lvwCustomers.Items.Add($"Customer with ID: {xmlReader.GetAttribute("Id")}");
                           break;
                        case "CompanyName":
                           if(xmlReader.Read()) lvwCustomers.Items.Add($"Company name: {xmlReader.Value}");
                           break;
                        case "Phone":
                           if (xmlReader.Read())  lvwCustomers.Items.Add($"Phone number: {xmlReader.Value}");
                           break;
                     }
                  }
               }
            }
         }
      }
   }
}