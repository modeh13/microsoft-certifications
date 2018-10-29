using System;
using System.Linq;

namespace ProgrammaticFlow
{
   class Program
   {
      enum Dog {
         Pitbull,
         Golden, 
         Labrador,
         Pastor,
         Bullterrier
      }

      static void Main(string[] args)
      {
         //Structures of Condition
         WorkingIfElse();
         WorkingSwitch();

         //Structures of Control
         WorkingWhile();
         WorkingDoWhile();
         WorkingFor();
         WorkingForEach();

         //Structures of Control Transfer
         //continue, break, goto, return, throw, yield
         WorkingStructuresOfControlTransfer();
      }

      private static void PrintTitle(string title)
      {
         Console.WriteLine(new string('-', 50));
         Console.WriteLine(title);
         Console.WriteLine(new string('-', 50));
      }

      /// <summary>
      /// Working with If-Else statement
      /// </summary>
      private static void WorkingIfElse()
      {
         PrintTitle("Working with If-Else statement");

         int number = 5;

         if (number == 1)
         {
            Console.WriteLine("The number is 1.");
         }
         else if (number == 5)
         {
            Console.WriteLine("The number is 5.");
         }
         else
         {
            Console.WriteLine("The number is " + number);
         }
      }

      /// <summary>
      /// Workign with Switch statment
      /// </summary>
      private static void WorkingSwitch()
      {
         PrintTitle("Working with Switch statement");
         Dog dog = Dog.Pastor;

         switch (dog)
         {
            //OR
            case Dog.Pastor: 
            case Dog.Bullterrier:
               Console.WriteLine("Dog says, I'm " + Dog.Pastor.ToString() + " or " + Dog.Bullterrier.ToString());
               break;
            case Dog.Pitbull:
               Console.WriteLine(Dog.Pitbull.ToString());
               break;
            case Dog.Golden:
               Console.WriteLine(Dog.Golden.ToString());
               break;
            case Dog.Labrador:
               Console.WriteLine(Dog.Labrador.ToString());
               break;
            default:
               throw new NotSupportedException();               
         }
      }

      /// <summary>
      /// Working with While statement
      /// </summary>
      private static void WorkingWhile()
      {
         PrintTitle("Working with While statement");

         int i = 1;

         while (i < 5)
         {
            Console.WriteLine("Number " + i);
            i++;
         }
      }

      /// <summary>
      /// Working with Do-While statement
      /// </summary>
      private static void WorkingDoWhile()
      {
         PrintTitle("Working with Do-While statement");
         int i = 1;

         do
         {
            Console.WriteLine("Number " + i);
            i++;
         }
         while (i < 5);
      }

      /// <summary>
      /// Working with For statement
      /// </summary>
      private static void WorkingFor()
      {
         PrintTitle("Working with For statement");
         var numbers = new[] { 1, 2, 3, 4, 5 };
         //var numbers = new int[] { 1, 2, 3, 4, 5 };
         //int[] numbers = new int[] { 1, 2, 3, 4, 5 };

         for (int i = 0; i < numbers.Length; i++)
         {
            Console.WriteLine("Number " + numbers[i]);
         }
      }

      /// <summary>
      /// Working with For-Each statement
      /// </summary>
      private static void WorkingForEach()
      {
         PrintTitle("Working with For-Each statement");
         var numbers = new[] { 1, 2, 3, 4, 5 };
         //var numbers = new int[] { 1, 2, 3, 4, 5 };
         //int[] numbers = new int[] { 1, 2, 3, 4, 5 };

         foreach (int i in numbers)
         {
            Console.WriteLine("Number " + i);
         }
      }

      /// <summary>
      /// Working with Structures of Control transfer like break, continue, return, goto, throw, yield
      /// </summary>
      private static void WorkingStructuresOfControlTransfer()
      {
         PrintTitle("Working with Structures of Control transfer");
         var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 10, 11, 12, 13, 14, 15 };

         for (int i = 0; i < numbers.Length; i++)
         {
            if (i % 2 == 0)
               continue;

            Console.WriteLine("Number " + numbers[i]);

            if (numbers[i] > 10) break;
         }
         if (numbers.Contains(14)) Console.WriteLine("The number 14 is in Array.");
         else throw new ArgumentException();
         goto Stop;

         Stop:
         return;
      }
   }
}