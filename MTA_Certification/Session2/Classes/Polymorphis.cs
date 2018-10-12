using System;

namespace Session2.Classes
{
   //The characteristic of the class derived from sharing a common functionality with the Base class but defining its own implementation.
   //Through abstract and virtual methods that are overrides
   class Polymorphis
   {
      internal void DrawPolygons()
      {
         Rectangle rectangle = new Rectangle();
         Triangle triangle = new Triangle();
         Polygon rectangle1 = new Rectangle();
         Polygon triangle1 = new Triangle();

         //Using "override"
         Console.WriteLine("Using 'override' keyword.");
         Console.WriteLine("With instaces of type (Rectangle and Triangle).");
         rectangle.Draw();
         triangle.Draw();
         Console.WriteLine("With base class (Polygon).");
         rectangle1.Draw();
         triangle1.Draw();

         //Using "new"
         Console.WriteLine(string.Empty);
         Console.WriteLine("Using 'new' keyword.");
         Console.WriteLine("With instaces of type (Rectangle and Triangle).");
         rectangle.ReDraw();
         triangle.ReDraw();
         Console.WriteLine("With base class (Polygon).");
         rectangle1.ReDraw();
         triangle1.ReDraw();
      }

      public class Polygon
      {
         public virtual void Draw()
         {
            Console.WriteLine("Drawing polygon.");
         }

         public virtual void ReDraw()
         {
            Console.WriteLine("ReDrawing polygon.");
         }
      }

      internal class Rectangle : Polygon
      {
         //If the reserved word "override" is not in the signature method the compiler assume it as reserved word "new" implicitly.
         public override void Draw()
         {
            Console.WriteLine("Drawing Rectangle.");
         }

         //The override method has priority over the method in the class base.
         public override void ReDraw()
         {
            Console.WriteLine("ReDrawing Rectangle.");
         }
      }

      protected class Triangle : Polygon
      {
         public override void Draw()
         {
            Console.WriteLine("Drawing Triangle.");
         }

         //public void ReDraw() -- This definition is equivalent. (if "override" keyword is omitted, the "new" keyword is assumed)
         //Using the Base class, the method in the Base class has priority.
         public new void ReDraw()
         {
            Console.WriteLine("ReDrawing Triangle.");
         }
      }
   }
}