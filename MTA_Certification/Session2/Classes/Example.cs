using System.Collections.Generic;

namespace Session2.Classes
{
   public class Example
   {
      //Member that storages the property value.
      private string name;
      private string email;

      //The member used as source for INDEXER can be ARRAY, LIST
      //private string[] phones = { "3187451236", "3104521011", "6425510", "20153212" };
      private List<string> phones;

      public static string Company = "AD"; //This is a static member, it is a class element and not an object (instance).

      //Properties
      public string Name {
         get { return name; }
         set { name = value; }
      }

      //Properties Auto-Implemented 
      public string LastName { get; set; } //Read and Write

      //Only write.
      public string Email {
         set { email = value; }
      }

      public byte Age { get; } //Only read.

      //Constructors
      //public Example() { } //This is a Constructor by default that is not visible.

      //Initialize the properties and class data.
      public Example(string name, string lastname) {
         this.Name = name;
         this.LastName = lastname;
      }

      //Methosds
      //The methods are a secuencial of sentences (Code).
      //Describes the functionality of Class and behaviors allowed.
      //Access modifiers (public, protected, private)
      //return type as (DataType or void)
      //An Array of the arguments as parameters
      public string GetFullName() {

         return string.Format("{0} {1}", this.name, this.LastName);
      }

      //INDEXER
      //Type "indexe" + TAB
      public string this[int index]
      {
         get {
            return phones[index];
         }
         set { /* set the specified index to value here */
            phones[index] = value;
         }
      }
   }
}