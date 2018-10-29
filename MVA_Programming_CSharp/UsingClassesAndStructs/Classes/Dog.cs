using System;

namespace UsingClassesAndStructs.Classes
{
   class Dog : Animal
   {
      //Full implementation of Properties with the private member.
      private string breed;

      public string Breed
      {
         get { return breed; }
         set { breed = value; }
      }

      public Dog()
      {
         Name = "Golden Retriever";
      }
      
      //Method override of Base declaration
      public override void Run()
      {
         Console.WriteLine($"The {Name} dog is running.");
      }

      //Method hides the Base declaration
      public void Walk()
      {
         Console.WriteLine($"The {Name} dog is walking.");         
      }

      protected void Eat()
      {
         Console.Write($"The {Name} dog is goint to eat something.");
      }
   }
}