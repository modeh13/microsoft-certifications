using System;

namespace ProgramFlow
{
   class Program
   {
      static void Main(string[] args)
      {
      }

      /// <summary>
      /// Working with "goto" statement
      /// It's possible to use with "case expression"
      /// </summary>
      private static void WorkingWithGoTo()
      {
         //Using the 'case expression'
         char character = 'e';

         switch (character)
         {
            case 'a':
               Console.WriteLine("The character is a vowel.");
               break;

            case 'e':
               goto case 'a';

            case 'i':
               goto case 'a';

            case 'o':
               goto case 'a';

            case 'u':
               goto case 'a';

            default:
               break;
         }

         //Using the 'label expression'
         int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
         for (int i = 0; i < 10; i++)
         {
            if (numbers[i] == 8)
            {
               goto Control;
            }
         }
         Console.WriteLine("End of Loop");

         Control:
         Console.WriteLine("The number is 8");
      }
   }
}