using System;
using UsingClassesAndStructs.Classes;

namespace UsingClassesAndStructs
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("Working with Classes.");
         Console.WriteLine(new string('-', 50));

         Animal baseAnimal = new Animal();
         Dog dog = new Dog();
         Cow cow = new Cow();

         baseAnimal.Run();
         dog.Run();

         Console.WriteLine(new string('-', 50));         

         baseAnimal.Walk();
         dog.Walk();
         cow.Walk();

         Console.WriteLine(new string('-', 50));
         Console.WriteLine("Casting");
         Console.WriteLine(new string('-', 50));

         ((Animal)dog).Run();
         ((Animal)dog).Walk();

         ((Animal)cow).Run();
         ((Animal)cow).Walk();

         Console.WriteLine(new string('-', 50));
         Console.WriteLine("Subscribing to Event");
         Console.WriteLine(new string('-', 50));
         baseAnimal.Walked += Dog_Walked;
         baseAnimal.Walk();
         RunFromGenericMethod(dog);
      }

      private static void Dog_Walked(object sender, EventArgs e)
      {
         Console.WriteLine("The Animal has walked.");
      }

      private static void RunFromGenericMethod<T>(T obj) where T : Animal
      {
         obj.Run();
      }
   }
}