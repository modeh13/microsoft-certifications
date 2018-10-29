using System;
using System.Text;

namespace WorkingWithStrings
{
   class Program
   {
      static void Main(string[] args)
      {
         WorkingWithStrings();
         WorkingWithStringBuilder();
      }

      private static void PrintTitle(string title)
      {
         Console.WriteLine(new string('-', 50));
         Console.WriteLine(title);
         Console.WriteLine(new string('-', 50));
      }

      /// <summary>
      /// Working with string data type.
      /// A string object is an immutable (unchangeable) sequence of characters.
      /// Any method that manipulates a string, actually returns a new string.
      /// </summary>
      private static void WorkingWithStrings()
      {
         PrintTitle("Working with Strings");
         String obj = "This is a new sentence using the Class.";
         string text = "This is a sentence using the reference data type.";

         text += " We're addding an additional characters but when we do that, a new string object is created.";

         Console.WriteLine(obj);
         Console.WriteLine(text);

         //Some methods
         PrintTitle("Substring method");
         Console.WriteLine(text.Substring(0, 10));

         PrintTitle("Concat method");
         Console.WriteLine(string.Concat(obj, "We're using the 'Concat' method."));

         PrintTitle("Replace method");
         Console.WriteLine(text.Replace("sentence", "paragraph"));

         PrintTitle("ToUpper method");
         Console.WriteLine(text.ToUpper());

         PrintTitle("ToLower method");
         Console.WriteLine(text.ToLower());

         var array = text.ToCharArray();
         var bytes = Encoding.UTF8.GetBytes(text);         
      }

      /// <summary>
      /// Working with StringBuilder class
      /// The StringBuilder class provides a mutable implementation of a string.
      /// </summary>
      private static void WorkingWithStringBuilder()
      {
         StringBuilder builder = new StringBuilder();

         builder.Append("This is a StringBuilder example.");
         builder.AppendLine("This method adds a string but also it adds a Environment.NewLine");
         builder.AppendFormat("This is an example using the AppendFormat method, this is the number {0} at {1} by {2}", 1, DateTime.Now, "Germán Ramírez");

         Console.WriteLine(builder.ToString());
      }
   }
}