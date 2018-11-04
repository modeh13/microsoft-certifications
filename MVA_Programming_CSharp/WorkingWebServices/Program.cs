using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web.Script.Serialization;
using System.Xml.Serialization;

namespace WorkingWebServices
{
   class Program
   {
      static void Main(string[] args)
      {
      }

      private static void PrintTitle(string title)
      {
         Console.WriteLine(new string('-', 50));
         Console.WriteLine(title);
         Console.WriteLine(new string('-', 50));
      }

      /// <summary>
      /// Working with JavaScriptSerializarer, we need to add 'System.Web.Extensions' reference to be able to work with JSON serializer.
      /// </summary>
      private static async void WorkingWithJavaScriptSerializar()
      {
         var url = new Uri("http://localhost:1234/MyService.svc/json/4");
         System.Net.WebClient client = new System.Net.WebClient();
         string json = await client.DownloadStringTaskAsync(url);

         //Deserialize JSON into OBJECTS
         JavaScriptSerializer serializer = new JavaScriptSerializer();
         JSONSAMPLE.Data data = serializer.Deserialize<JSONSAMPLE.Data>(json);

         Console.WriteLine(data.Number);
      }

      /// <summary>
      /// Working with 'DataContractJsonSerializer' class, but it's necessary to include 
      /// the reference for the 'System.Runtime.Serialization.Json' namespace;
      /// </summary>
      private static async void WorkingWithDataContractJsonSerializer()
      {
         var url = new Uri("http://localhost:1234/MyService.svc/json/4");
         System.Net.WebClient client = new System.Net.WebClient();
         var json = await client.OpenReadTaskAsync(url);

         //Serializer/Deserializer
         var serializer = new DataContractJsonSerializer(typeof(DATACONTRACTSAMPLE.Data));
         var data = serializer.ReadObject(json) as DATACONTRACTSAMPLE.Data;

         Console.WriteLine(data.Number);
      }

      /// <summary>
      /// Working with the 'XmlSerializer' class to get the XML data
      /// </summary>
      private static async void WorkintWithXMLResponse()
      {
         var url = new Uri("http://localhost:1234/MyService.svc/xml/4");
         System.Net.WebClient client = new System.Net.WebClient();
         var xml = await client.DownloadStringTaskAsync(url);
         var bytes = Encoding.UTF8.GetBytes(xml);

         using (MemoryStream ms = new MemoryStream(bytes))
         {
            var serializer = new XmlSerializer(typeof(XMLSAMPLE.Data));
            var data = serializer.Deserialize(ms) as XMLSAMPLE.Data;

            Console.WriteLine(data.Number);
         }
      }
   }
}

namespace JSONSAMPLE
{
   public class Data
   {
      public int Number { get; set; }
      public int[] Multiples { get; set; }
   }
}

namespace DATACONTRACTSAMPLE
{
   [DataContract]
   public class Data
   {
      [DataMember(Name = "CustomName")]
      public int Number { get; set; }

      [DataMember]
      public int[] Multiples { get; set; }
   }
}

namespace XMLSAMPLE
{
   [DataContract]
   public class Data
   {
      [DataMember(Name = "CustomName")]
      public int Number { get; set; }

      [DataMember]
      public int[] Multiples { get; set; }
   }
}