using System;
using System.Text;

namespace WorkingWithStrings
{
   /// <summary>
   /// Working with Strings
   /// In this example, It's shown the different ways that we can manipulate a string variable.
   /// The String data type is "Immutable", that is, it cannot be modified.
   /// If this is modified, a new string is created.
   /// </summary>
   class Program
   {
      static void Main(string[] args)
      {
         string myString = "This is my message for people that live in Colombia";
         Console.WriteLine(myString);

         //The Backslash (\) is the character used to scape special characters. --> \n; New Line, \r
         string scapingCharacter = "This is my message for \"people\" that live in Colombia";         
         Console.WriteLine(scapingCharacter);

         //If we need to print the Backslash character into a string message.
         //We must add a Backslash for each "\"
         string backslash = "The file can be found in the following path C:\\MyFolder\\Files";
         Console.WriteLine(backslash);

         //We can use the @ character to indicate to compiler that we want to try the string as literal
         string backslashArroba = @"The file can be found in the following path C:\MyFolder\Files";
         Console.WriteLine(backslashArroba);

         //Using the String.Format method
         Console.WriteLine(string.Format("{0} - {1}", "First", "Second"));
         Console.WriteLine(string.Format("{0} - {0}", "First", "Second"));
         Console.WriteLine(string.Format("{1} - {0}", "First", "Second"));

         //Currency format based on Current Culture Info
         Console.WriteLine(string.Format("{0:C}", 12345.55));

         //Number format based on Current Culture Info
         Console.WriteLine(string.Format("{0:N}", 123456789));

         //Percentage format based on Current Culture Info
         Console.WriteLine(string.Format("{0:P}", .35));

         //Custom format
         Console.WriteLine(string.Format("{0:(###) ###-####}", 0576815797));

         //Concatenating a string
         //Each time, the CLR makes a new variable when the += operator is used.
         //Below, it's a inefficient way to work.
         myString = string.Empty;

         for (int i = 1; i <= 100; i++)
         {
            myString += "--" + i;
         }
         Console.WriteLine(myString);

         //The best way to do the above approach is using the StringBuilder class.
         StringBuilder builder = new StringBuilder();

         for (int i = 1; i <= 100; i++)
         {
            builder.Append("--" + i);            
         }
         Console.WriteLine(myString);

         Console.ReadKey();
      }
   }
}