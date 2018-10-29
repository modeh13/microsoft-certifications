using System;

namespace UsingClassesAndStructs.Classes
{
   class Animal
   {
      //Properties auto-implemented (Encapsulate the private member)
      public string Name { get; set; }

      public event EventHandler Walked;


      public string Greeting()
      {
         return "Hello !!";
      }
     
      public virtual void Run()
      {
         Console.WriteLine("An animal is running.");
      }

      public virtual void Walk()
      {
         Console.WriteLine("An animal is walking.");
         Walked?.Invoke(this, EventArgs.Empty);
      }
   }
}