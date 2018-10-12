namespace Session2.Classes
{
   //Abstraction: It allows us to define the structure, attributes, methods and behaviors for a class without worrying about. how does it works?
   class Abstraction : object
   {
      public Abstraction()
      {
         //Casting of Types.
         Polygon polygon = new Rectangle(10, 20); //A rectangle is a Polygon. Polygon is the base class.

         //Casting of Rectangle to Object class (Fundamental base class).
         //There is not problem because all classes inherit of object base class.
         object rect1 = new Rectangle(25, 50);

         //It is necessary an explicit CAST because in runtime must validates if the instance of "object" 
         //type is compatible with Rectangle class.
         //if it is not compatible throw a System.InvalidCastException.
         Rectangle rect2 = (Rectangle)rect1;

         //To avoid the Exception (System.InvalidCastException).
         if (rect1 is Rectangle)
         {
            rect2 = (Rectangle)rect1;
         }

         //The operator "as" makes the CAST process but if the object instance is not compatible with the CLASS, 
         //it will return NULL value and will not throw Exception (System.InvalidCastException).
         Rectangle rect3 = rect1 as Rectangle;
      }

      public override bool Equals(object obj)
      {
         return base.Equals(obj);
      }

      public override string ToString()
      {
         return base.ToString();
      }

      public override int GetHashCode()
      {
         return base.GetHashCode();
      }
   }

   internal abstract class Polygon
   {
      //A method abstract can not be "private".
      //private abstract void GetDate() { }
      public double Length { get; protected set; }
      public double Width { get; protected set; }      

      protected abstract double GetArea();
   }

   //The "sealed" classes don't allow the INHERIT.
   sealed class Rectangle : Polygon
   {
      public Rectangle(double length, double width)
      {
         Length = length;
         Width = width;
      }

      //The member GetArea can be "sealed" only if It is override.
      sealed protected override double GetArea()
      {
         return Length * Width;
      }
   }
}