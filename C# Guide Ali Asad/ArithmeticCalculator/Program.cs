using System;
using System.Linq;

namespace ArithmeticCalculator
{
   class Program
   {
      static readonly string ENTER_VALUE_1 = "Enter Value 1 :";
      static readonly string ENTER_VALUE_2 = "Enter Value 2 :";
      static readonly string[] options = new[] { "1", "2", "3", "4", "C", "E" };

      static void Main(string[] args)
      {
         bool isOperation;
         double a, b, result;
         string option;

         PrintMenu();         
         option = ReadOption("Option :", options: options);

         while (!"E".Equals(option))
         {
            a = 0;
            b = 0;
            isOperation = IsNumeric(option);

            //This validation is only executed if the option is an arithmetic operation
            if (isOperation)
            {
               GetValue(ENTER_VALUE_1, out a);
               GetValue(ENTER_VALUE_2, out b);
            }

            switch (option)
            {
               case "1":                  
                  result = Addition(a, b);
                  PrintResult('+', a, b, result);
                  break;
               case "2":
                  result = Subtraction(a, b);
                  PrintResult('-', a, b, result);
                  break;
               case "3":
                  result = Multiplication(a, b);
                  PrintResult('*', a, b, result);
                  break;
               case "4":
                  result = Division(a, b);
                  PrintResult('/', a, b, result);
                  break;
               case "C":
                  Console.Clear();
                  PrintMenu();
                  break;
            }

            if(isOperation)
               option = ReadOption("Do you want to continue again (Y/N)? ", options: new[] { "Y", "N" });

            option = new string[]{ "Y", "C"}.Contains(option) ? ReadOption("Option :", options: options): "E";
         }

         Console.Write("Press any key to finish...");
         Console.ReadKey();      
      }

      /// <summary>
      /// Print the main menu with the options for the Calculator.
      /// </summary>
      private static void PrintMenu()
      {
         Console.WriteLine("Press any following key to perform an arithmetic operation: \n");

         //Print the Main menu
         Console.WriteLine("1 - Addition");
         Console.WriteLine("2 - Subtraction");
         Console.WriteLine("3 - Multiplication");
         Console.WriteLine("4 - Division");
         Console.WriteLine("C - Clear");
         Console.WriteLine("E - Exit \n");
      }

      /// <summary>
      /// Read a Input from Console standard stream.
      /// </summary>
      /// <param name="message">Message to show when the input is requested</param>
      /// <param name="errorMessage">Message to show when the input isn't a valid</param>
      /// <param name="options">Array the elements that define the valid options</param>
      /// <returns>Value typed by user</returns>
      private static string ReadOption(string message, string errorMessage = "Try again, the value inserted isn't valid...", params string[] options)
      {         
         string option = ReadValue(message).ToUpper();

         while (!options.Contains(option))
         {
            Console.WriteLine(errorMessage);
            option = ReadValue(message).ToUpper();
         }
         Console.WriteLine(string.Empty);

         return option;
      }

      /// <summary>
      /// Print the result to Console standard output stream.
      /// </summary>
      /// <param name="symbol">Character that represents the symbol of the operation</param>
      /// <param name="a">First operand</param>
      /// <param name="b">Second operand</param>
      /// <param name="result">The operation's result</param>
      private static void PrintResult(char symbol, double a, double b, double result)
      {
         Console.WriteLine(string.Format("Result {0} {1} {2} = {3} \n", a, symbol,b, result));         
      }

      /// <summary>
      /// Read value from Console standard input stream.
      /// </summary>
      /// <param name="message">Message to show when the input is requested</param>
      /// <returns>Value typed by user</returns>
      private static string ReadValue(string message)
      {
         Console.Write(message);
         return Console.ReadLine();
      }

      /// <summary>
      /// Read a value from Console input stream with a validation if the value typed is a number
      /// </summary>
      /// <param name="message">Message to show when the input is requested</param>
      /// <param name="a">Value typed</param>
      private static void GetValue(string message, out double a)
      {
         string value = ReadValue(message);

         while (!double.TryParse(value, out a))
            value = ReadValue(message);         
      }

      /// <summary>
      /// Check if a text value is a number or not
      /// </summary>
      /// <param name="text">Text value</param>
      /// <returns>true: It's a number, false: It isn't a number</returns>
      private static bool IsNumeric(string text)
      {
         return int.TryParse(text, out int value);
      }

      /// <summary>
      /// Addition operation
      /// </summary>
      /// <param name="a">First operand</param>
      /// <param name="b">Scond operand</param>
      /// <returns>The addition's result</returns>
      private static double Addition(double a, double b)
      {
         return a + b;
      }

      /// <summary>
      /// Substration operation
      /// </summary>
      /// <param name="a">First operand</param>
      /// <param name="b">Second operand</param>
      /// <returns>The substraction's result</returns>
      private static double Subtraction(double a, double b)
      {
         return a - b;
      }

      /// <summary>
      /// Multiplication operation
      /// </summary>
      /// <param name="a">First operand</param>
      /// <param name="b">Second operand</param>
      /// <returns>The multiplication's result</returns>
      private static double Multiplication(double a, double b)
      {
         return a * b;
      }

      /// <summary>
      /// Division operation
      /// </summary>
      /// <param name="a">First operand</param>
      /// <param name="b">Second operand</param>
      /// <returns>The division's result</returns>
      private static double Division(double a, double b)
      {
         return a / b;
      }
   }
}