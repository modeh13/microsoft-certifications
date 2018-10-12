using Session1.DataTypes;
using Session2.Classes;
using Session2.Events;
using System;

namespace Session2
{
   //ALT + UP/DOWN --> Move Line
   //CTRL + L --> Remove Line
   //CTRL + K + S --> Add Region
   //CTRL + . --> Add using
   //CTRL + K + D --> Format code
   //CTRL + K + U --> Uncomment code
   //CTRL + K + C --> Comment code
   //CTRL + F --> Find
   //CTRL + H --> Replace
   //CTRL + SHIFT + H 
   //CTRL + SHIFT + B --> Build Project
   //CTRL + G --> Go to Line
   //CTRL + T --> Go to All

   //POO
   //Class, objects (Properties, Constructors, Methods, Events)
   //Delegates,
   //Events

   // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
   // Access modifiers (PUBLIC, PROTECTED, PRIVATE, INTERNAL, PROTECTED INTERNAL
   // - The Classes of most high level into "namespaces" must be "public or internal"
   // - By default, the access modifier for the Class is "internal"
   // - The nested classes could be less restrictive than its container class.
   internal class Rectangle {
      public int X { get; set; }
      public int Y { get; set; }

      protected class Example1 {
         public class Example2 { }
      }
   }

   class Program
   {
      public static string Message;

      struct Point {
         public int X;
         public int Y;
      }

      static void Main(string[] args)
      {
         //1-) New instance class to Example type.
         CreatingNewInstanceClass();

         //2-) Using EVENTs with delegates
         WorkingWithEventsAndDelegates();

         //3-) Using static class members
         Console.WriteLine(new string('-', 50));
         Console.WriteLine("Using static class members");
         Console.WriteLine(Example.Company);

         //4-) Using STRUCTS (Structures defined by user). They are recommend to simple structures in otherwise use a Class.
         WorkingWithStructs();

         //5-) Datatypes of values and references
         ValuesAndReferencesDataTypes();

         //6-) Working with Abstrations and CASTING objects.
         var obj = new Abstraction();

         //7-) Polymorphis
         Console.WriteLine(new string('-', 50));
         Console.WriteLine("Polymorphis");
         Polymorphis poly = new Polymorphis();
         poly.DrawPolygons();

         Console.Read();
      }

      #region Methods
      private static void CreatingNewInstanceClass()
      {
         Console.WriteLine(new string('-', 50));
         Console.WriteLine("Creating new Instance of a Class.");
         Example example = new Example("Germán", "Ramírez");
         Console.WriteLine(example.GetFullName());
      }

      private static void WorkingWithEventsAndDelegates()
      {
         Console.WriteLine(new string('-', 50));
         Console.WriteLine("Working with Events and delegates");
         CustomEvents events = new CustomEvents();
         events.EventHandler += Events_EventHandler; //Subscribe to EventHandler assigning the method name. (Controlador de Eventos)
         events.SetMessage += new CustomEvents.DelegateText(SetText); //Subscribe to EventHandler using a new instance for the Delegate

         //using delagates
         events.SetText += new CustomEvents.DelegateText(SetText);
         events.PredefinedEventHandler += new EventHandler(Events_EventHandler);
      }

      static void WorkingWithStructs()
      {
         Console.WriteLine(new string('-', 50));
         Console.WriteLine("Working with STRUCTS");
         ValueTypes.Person person = new ValueTypes.Person();
         person.Name = "Germán";
         Console.WriteLine(person.Name);

         //Using DateTimeOffset STRUCT (UTC - Universal Time Coordinate).
         DateTime date1, date2;
         DateTimeOffset dateOffset1, dateOffset2;
         //DateTimeKind -- ENUM
         TimeSpan difference;

         // Find difference between Date.Now and Date.UtcNow
         date1 = DateTime.Now;
         date2 = DateTime.UtcNow;
         difference = date1 - date2;
         Console.WriteLine("{0} - {1} = {2}", date1, date2, difference);

         // Find difference between Now and UtcNow using DateTimeOffset
         dateOffset1 = DateTimeOffset.Now;
         dateOffset2 = DateTimeOffset.UtcNow;
         difference = dateOffset1 - dateOffset2;
         Console.WriteLine("{0} - {1} = {2}",
                           dateOffset1, dateOffset2, difference);
      }

      static void ValuesAndReferencesDataTypes()
      {
         Console.WriteLine(new string('-', 50));
         Console.WriteLine("Values and References DataTypes");
         //Value Type
         Point point1 = new Point();
         point1.X = 10;
         point1.Y = 20;

         Point point2 = point1;
         point2.X = 100;

         Console.WriteLine($"p1.X = {point1.X} - p2.X = {point2.X}");

         //References Type 
         Rectangle rect1 = new Rectangle();
         rect1.X = 10;
         rect1.Y = 20;

         Rectangle rect2 = rect1; //(The reference is the same)
         rect2.X = 100;

         Console.WriteLine($"rect1.X = {rect1.X} - rect2.X = {rect2.X}");
      }
      #endregion

      private static void SetText(string text)
      {
         Message = text;
      }

      private static void Events_EventHandler(object sender, EventArgs e)
      {
         throw new NotImplementedException();
      }
   }
}