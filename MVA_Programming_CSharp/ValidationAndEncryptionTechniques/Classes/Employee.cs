using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationAndEncryptionTechniques.Classes
{
   class Employee
   {
      public string Name { get; private set; }

      /// <summary>
      /// Validating the Input with normal method
      /// </summary>
      /// <param name="name"></param>
      public void SetName(string name)
      {
         if (string.IsNullOrEmpty(name))
            throw new ArgumentNullException("The name is empty or null");

         if (name == this.Name)
            throw new ArgumentException("The value is duplicated");

         if (name.Length > 10)
            throw new ArgumentOutOfRangeException("The value is too big");

         this.Name = name;
      }

      /// <summary>
      /// Validating the Input using "Data Contracts" 
      /// </summary>
      /// <param name="name"></param>
      public void SetNameWithDataContract(string name)
      {
         Contract.Requires(!string.IsNullOrEmpty(name), "The name is empty");
         this.Name = name;
      }

      /// <summary>
      /// Validating the Output using "Data Contracts"
      /// </summary>
      /// <returns></returns>
      public string GetName()
      {
         //Validate Output
         Contract.Ensures(!string.IsNullOrWhiteSpace(Contract.Result<string>()));
         return this.Name;
      }
   }
}