using System;

namespace UsingClassesAndStructs.Classes
{
   class Cow : Animal
   {
      public Cow()
      {
         Name = "Simental";
      }

      public override void Run()
      {
         Console.WriteLine($"The {Name} cow is running.");
      }

      public new void Walk()
      {
         Console.WriteLine($"The {Name} cow is walking.");
      }
   }
}