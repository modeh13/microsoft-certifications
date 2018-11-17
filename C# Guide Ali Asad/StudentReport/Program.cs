using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StudentReport
{
   class Program
   {
      static readonly string[] subjects = { "English", "Math", "Computers" };    

      static void Main(string[] args)
      {  
         Console.WriteLine("Press any following key...");

         //Variables
         int studentsNumber;
         double subjectValue, totalValues;
         string studentName;

         Console.WriteLine(new string('*', 50));
         GetIntValue("Enter Total Students :", out studentsNumber);

         string[,] studentsData = new string[studentsNumber, subjects.Length + 2]; //2: StudentName + Total Values

         // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
         //Read data for each Student
         for (int i = 0; i < studentsData.GetLength(0); i++)
         {
            totalValues = 0;
            studentName = ReadValue("Enter the Student Name :");
            studentsData[i, 0] = studentName;

            for (int j = 0; j < subjects.Length; j++)
            {
               subjectValue = GetDoubleValue("Enter " + subjects[j] + " Marks (Out Of 100) :", @"^\d{1,2}$|^100$");
               studentsData[i, j + 1] = totalValues.ToString();
               totalValues += subjectValue;
            }

            studentsData[i, studentsData.GetLength(1) - 1] = (totalValues / subjects.Length).ToString();

            Console.WriteLine(new string('*', 50));
         }

         // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
         //Sort Data and Print Students Report
         string reportTitle = "Report Card";
         reportTitle = reportTitle.PadBoth('*', 50);

         

         Console.WriteLine(reportTitle);

         for (int i = 0; i < studentsData.GetLength(0); i++)
         {
            Console.WriteLine(new string('*', 50));
            Console.WriteLine("Student Name: {0}, Position {1}, Total: {2:N2}/{3}", studentsData[i, 0], i + 1, studentsData[i, studentsData.GetLength(1) - 1], subjects.Length * 100);
            Console.WriteLine(new string('*', 50));
         }

         Console.ReadKey();
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
      private static void GetIntValue(string message, out int a)
      {
         string value = ReadValue(message);

         while (!int.TryParse(value, out a))
            value = ReadValue(message);
      }

      /// <summary>
      /// Read a value from Console input stream with a validation if the value typed is a number
      /// </summary>
      /// <param name="message">Message to show when the input is requested</param>
      /// <param name="a">Value typed</param>
      private static void GetDoubleValue(string message, out double a)
      {
         string value = ReadValue(message);

         while (!double.TryParse(value, out a))
            value = ReadValue(message);
      }

      /// <summary>
      /// Read a value from Console input strem with a Regular Expression validation.
      /// </summary>
      /// <param name="message">Message to show when the input is requested</param>
      /// <param name="pattern">Value typed</param>
      /// <returns></returns>
      private static double GetDoubleValue(string message, string pattern)
      {
         string input = ReadValue(message);
         Regex regex = new Regex(pattern);
         Match match = regex.Match(message);

         while (!regex.Match(input).Success)
            input = ReadValue(message);

         return double.Parse(input);
      }
   }

   static class Extensions
   {
      /// <summary>
      /// Method to add a partiular charater in both sides left and right for a string text
      /// </summary>
      /// <param name="text">Text to apply the Pad</param>
      /// <param name="character">Character to use</param>
      /// <param name="count">Length of the end string</param>
      /// <returns>String with the character</returns>
      public static string PadBoth(this string text, char character, int count)      
      {
         if (text == null)
            throw new ArgumentException("The text input parameter must not be empty.");

         if (text.Length < count) {
            int offSet = count - text.Length;
            int leftSize = offSet / 2;
            int rightSize = offSet - leftSize;

            text = new string(character, leftSize) + text + new string(character, rightSize);
         }

         return text;
      }
   }
}