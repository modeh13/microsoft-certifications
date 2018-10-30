using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CodeReflectionAndGC
{
   class Program
   {
      //Examples classes
      public class Dog {
         private int size;
         public string Name { get; set; }

         public Dog() { }

         public Dog(string name)
         {
            this.Name = name;
         }

         public void Run() {
            Console.WriteLine($"The dog with name {Name} is running.");
         }
      }

      static void Main(string[] args)
      {
         WorkingWithCodeReflection();

      }

      private static void PrintTitle(string title)
      {
         Console.WriteLine(new string('-', 50));
         Console.WriteLine(title);
         Console.WriteLine(new string('-', 50));
      }

      /// <summary>
      /// Code Reflection
      /// Type: It provides metadata at runtime:
      /// - Assembly, Constructors, Properties, Attributes, Methods
      /// We can create instance, asign property value, execute methods, and so on. 
      /// </summary>
      private static void WorkingWithCodeReflection()
      {
         PrintTitle("Working with Code Reflection");

         //We must use the System.Reflection namespace to work with "Code Reflection".
         //We always get the TYPE metadata for each interaction with the Code Reflection
         //-------------------------------------------
         //How do I get Type data?
         //- Statically at compilation time
         //- Dynamically at runtime

         Dog dog = new Dog("Maxi");

         //At Compilation time
         Type typeC = typeof(Dog);

         //At Runtime
         Type typeR = dog.GetType();

         //TYPE Methods
         Console.WriteLine(typeC.Name);
         Console.WriteLine(typeR.Assembly.FullName);

         //-------------------------------------------
         //How can I create an instance of Type?
         //Thera are two ways to create instance of Type, this methods use the "default constructor (without Parameters)."
         //- Activator.CreateInstance
         //- Calling Invoke a ConstructorInfo object (Advanced scenarios)

         //Using the Activator.CreateInstance static method
         Dog dog2 = (Dog)Activator.CreateInstance(typeof(Dog));
         Dog dog3 = Activator.CreateInstance<Dog>(); //Generic

         //Usingt the ConstructorInfo object         
         ConstructorInfo dogConstructor = typeR.GetConstructors().First();
         Dog dog4 = (Dog) dogConstructor.Invoke(null);

         //-------------------------------------------
         //How to get a property value?         
         PropertyInfo property = typeR.GetProperty("Name");
         object dogName = property.GetValue(dog);

         //How to set a property value?
         property.SetValue(dog, "Terry");
         Console.WriteLine("The dog name is " + property.GetValue(dog));

         //-------------------------------------------
         //How to invoke a methods?
         MethodInfo method = typeR.GetMethod("Run");
         method.Invoke(dog, null);         
      }

      /// <summary>
      /// Garbage Collection
      /// It recommendable to let the GC do its things
      /// A scenario that make sense is "Windows Services (LocalService, NetworkService, LocalSystem, UserAccount"
      /// </summary>
      private static void WorkingWithGarbageCollection()
      {
         //It's recommend or good practice to unsubscribe the Listener of the Event Handler if we aren't going to work more with that instance.
         GC.Collect();
         GC.WaitForPendingFinalizers();
      }

      //Simple IDispose pattern
      public class DbConnection : IDisposable
      {
         public void Dispose()
         {
            //Clean Resources
         }
      }

      //Full implementation about IDispose pattern
      public class FileDispose : IDisposable
      {
         #region IDisposable Support
         private bool disposedValue = false; // To detect redundant calls

         protected virtual void Dispose(bool disposing)
         {
            if (!disposedValue)
            {
               if (disposing)
               {
                  // TODO: dispose managed state (managed objects).
               }

               // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
               // TODO: set large fields to null.

               disposedValue = true;
            }
         }

         // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
         // ~FileDispose() {
         //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
         //   Dispose(false);
         // }

         // This code added to correctly implement the disposable pattern.
         public void Dispose()
         {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            //GC.SuppressFinalize(this);
         }
         #endregion
      }
   }
}