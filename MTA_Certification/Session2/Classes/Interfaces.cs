namespace Session2.Classes
{
   class Interfaces
   {
   }

   interface IPerson
   {
      int Id { set; }
      string Name { set; }

      int GetId();
      string GetName();      
   }

   //A class can implements N interfaces.
   class Person : IPerson
   {      
      public int Id { get; set; }
      public string Name { get;  set; }

      public int GetId()
      {
         return Id;
      }

      public string GetName()
      {
         return Name;
      }
   }
}