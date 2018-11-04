using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfRest
{
   // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
   // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.

   [ServiceContract]
   public class RestService
   {
      [OperationContract]
      [WebGet(UriTemplate = "/json/{number}", ResponseFormat = WebMessageFormat.Json)]
      public Data GetMultipleJson(string number)
      {
         return new Data(int.Parse(number));
      }

      [OperationContract]
      [WebGet(UriTemplate = "/xml/{number}", ResponseFormat = WebMessageFormat.Xml)]
      public Data GetMultipleXml(string number)
      {
         return new Data(int.Parse(number));
      }
   }

   [DataContract]
   public class Data
   {
      public Data(int number)
      {
         var list = Enumerable.Range(1, 100);
         this.Multiples = list.Where(x => x % number == 0).ToArray();
      }

      [DataMember]
      public int Number { get; set; }

      [DataMember]
      public int[] Multiples { get; set; }
   }
}