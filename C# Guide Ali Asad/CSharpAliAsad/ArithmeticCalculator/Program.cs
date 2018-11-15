using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticCalculator
{
   class Program
   {
      static readonly string[] options = new[] { "1", "2", "3", "4", "C", "E" };

      static void Main(string[] args)
      {
         Console.WriteLine("Press any following key to perform an arithmetic operation: \n");

         //Print the Main menu
         Console.WriteLine("1 - Addition");
         Console.WriteLine("2 - Subtraction");
         Console.WriteLine("3 - Multiplication");
         Console.WriteLine("4 - Division");
         Console.WriteLine("C - Clear");
         Console.WriteLine("E - Exit \n");
                  
         string option = ReadOption();
         double a, b, result;                

         switch (option)
         {
            case "1":
               GetValue("Enter Value 1: ", out a);
               GetValue("Enter Value 2: ", out b);
               result = Addition(a, b);
               PrintResult('+', a, b, result);
               break;
            case "2":
               GetValue("Enter Value 1: ", out a);
               GetValue("Enter Value 2: ", out b);
               result = Subtraction(a, b);
               PrintResult('-', a, b, result);
               break;
            case "3":
               GetValue("Enter Value 1: ", out a);
               GetValue("Enter Value 2: ", out b);
               result = Multiplication(a, b);
               PrintResult('*', a, b, result);
               break;
            case "4":
               GetValue("Enter Value 1: ", out a);
               GetValue("Enter Value 2: ", out b);
               result = Division(a, b);
               PrintResult('/', a, b, result);
               break;
            case "C":
               Console.Clear();
               break;
         }
         
         Console.Write("Do you want to continue again (Y/N)? ");
         string d = Console.ReadLine();         
      }

      /// <summary>
      /// 
      /// </summary>
      /// <returns></returns>
      private static string ReadOption()
      {         
         string option = ReadValue("Option: ").ToUpper();

         while (!options.Contains(option))
         {
            Console.WriteLine("Try again, the value inserted isn't valid...");
            option = ReadValue("Option: ").ToUpper();
         }
         Console.WriteLine(string.Empty);

         return option;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="symbol"></param>
      /// <param name="a"></param>
      /// <param name="b"></param>
      /// <param name="result"></param>
      private static void PrintResult(char symbol, double a, double b, double result)
      {
         Console.WriteLine(string.Format("Result {0} {1} {2} = {3} \n", a, symbol,b, result));         
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="message"></param>
      /// <returns></returns>
      private static string ReadValue(string message)
      {
         Console.Write(message);
         return Console.ReadLine();
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="message"></param>
      /// <param name="a"></param>
      private static void GetValue(string message, out double a)
      {
         string value = ReadValue(message);

         while (!double.TryParse(value, out a))
            value = ReadValue(message);         
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="a"></param>
      /// <param name="b"></param>
      /// <returns></returns>
      private static double Addition(double a, double b)
      {
         return a + b;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="a"></param>
      /// <param name="b"></param>
      /// <returns></returns>
      private static double Subtraction(double a, double b)
      {
         return a - b;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="a"></param>
      /// <param name="b"></param>
      /// <returns></returns>
      private static double Multiplication(double a, double b)
      {
         return a * b;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="a"></param>
      /// <param name="b"></param>
      /// <returns></returns>
      private static double Division(double a, double b)
      {
         return a / b;
      }
   }
}