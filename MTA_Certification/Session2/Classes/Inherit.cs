namespace Session2.Classes
{
   internal class Inherit
   {      
      protected class Animal
      {
      }

      //The subclase must have an access modifier equal or less accesible than its Base class.
      //In this case, Dog must be "protected", "private" or "private protected".
      protected class Dog : Animal
      {
      }
   }

   public class Vehicule
   {
      public byte Model { get; set; }
      public string Name { get; set; }

      //The methods with signature "virtual" can not be "private".
      protected virtual void StartMotor() { }
   }

   public class Car : Vehicule
   {
      protected override void StartMotor()
      {
         base.StartMotor();
      }
   }
}