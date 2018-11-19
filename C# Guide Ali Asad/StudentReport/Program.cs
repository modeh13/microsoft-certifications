using System;
using System.Text.RegularExpressions;

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

         studentsData.Sort2DArrayByColumn(studentsData.GetLength(1) - 1, false);         

         Console.WriteLine(reportTitle);

         for (int i = 0; i < studentsData.GetLength(0); i++)
         {
            Console.WriteLine(new string('*', 50));
            Console.WriteLine("Student Name: {0}, Position {1}, Total: {2:N2}/{3}", studentsData[i, 0], i + 1, Convert.ToDouble(studentsData[i, studentsData.GetLength(1) - 1]), subjects.Length * 100);
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

      /// <summary>
      /// Sort the 2D array base on numeric column.
      /// </summary>
      /// <param name="data">2D array to sort</param>
      /// <param name="columnIndex">Index of the column to take as reference for the sorting criterion</param>
      /// <param name="ascending">Ascending or Descending</param>
      /// <returns>2D array sorted by column</returns>
      public static string[,] Sort2DArrayByColumn(this string[,] data, int columnIndex, bool ascending = true)
      {
         return QuickSort2DArray(data, columnIndex, 0, data.GetLength(0) - 1, ascending);
      }

      /// <summary>
      /// Quick algorithm to sort a 2D array based on numeric column.
      /// </summary>
      /// <param name="data">2D array to sort</param>
      /// <param name="columnIndex">Index of the column to take as reference for the sorting criterion</param>
      /// <param name="left">Top threshold</param>
      /// <param name="right">Bottom threshold</param>
      /// <param name="ascending">Ascending or Descending</param>
      /// <returns></returns>
      private static string[,] QuickSort2DArray(string[,] data, int columnIndex, int left, int right, bool ascending)
      {
         if (right > left)
         {
            //Case Recursive
            int pivotIndex = left + (right - left) / 2;
            pivotIndex = GetNewPivote(data, columnIndex, left, right, pivotIndex, ascending);
            QuickSort2DArray(data, columnIndex, left, pivotIndex - 1, ascending);
            QuickSort2DArray(data, columnIndex, pivotIndex + 1, right, ascending);
         }

         //Case Base
         return data;
      }

      /// <summary>
      /// Get the data array for the row in a 2D array based on index.
      /// </summary>
      /// <param name="data">2D array with the data</param>
      /// <param name="rowIndex">Row index</param>
      /// <returns>Single array with the data belonging to row</returns>
      private static string[] GetRow2DArray(string[,] data, int rowIndex)
      {
         string[] row = new string[data.GetLength(1)];

         for (int i = 0; i < row.Length; i++)
         {
            row[i] = data[rowIndex, i];
         }

         return row;
      }

      /// <summary>
      /// Set the data values for the row in a 2D array based on index.
      /// </summary>
      /// <param name="data">2D array with the data</param>
      /// <param name="rowIndex">Row index</param>
      /// <param name="row">Data row with values to set</param>
      private static void SetRow2DArray(string[,] data, int rowIndex, string[] row)
      {
         for (int i = 0; i < data.GetLength(1); i++)
         {
            data[rowIndex, i] = row[i];
         }
      }

      /// <summary>
      /// Get the new pivot position for the current iteration in the QuickSort algorithm.
      /// </summary>
      /// <param name="data">2D array to sort</param>
      /// <param name="columnIndex">Index of the column to take as reference for the sorting criterion</param>
      /// <param name="left">Top threshold</param>
      /// <param name="right">Bottom threshold</param>
      /// <param name="pivotIndex">Pivot index</param>
      /// <param name="ascending">Ascending or Descending</param>
      /// <returns></returns>
      private static int GetNewPivote(string[,] data, int columnIndex, int left, int right, int pivotIndex, bool ascending)
      {
         string[] pivoteRow = GetRow2DArray(data, pivotIndex);

         //Move pivote to end position
         string[] rightValue = GetRow2DArray(data, right);
         SetRow2DArray(data, right, pivoteRow);
         SetRow2DArray(data, pivotIndex, rightValue);

         //newPivot storages the index for the first more bigger value than PIVOT
         int newPivot = left;
         string[] tempValue;

         for (int i = left; i < right; i++)
         {
            if (!ascending)
            {
               if (double.Parse(data[i, columnIndex]) >= double.Parse(pivoteRow[columnIndex]))
               {
                  tempValue = GetRow2DArray(data, newPivot);
                  SetRow2DArray(data, newPivot, GetRow2DArray(data, i));
                  SetRow2DArray(data, i, tempValue);
                  newPivot++;
               }
            }
            else
            {
               if (double.Parse(data[i, columnIndex]) <= double.Parse(pivoteRow[columnIndex]))
               {
                  tempValue = GetRow2DArray(data, newPivot);
                  SetRow2DArray(data, newPivot, GetRow2DArray(data, i));
                  SetRow2DArray(data, i, tempValue);
                  newPivot++;
               }
            }
         }

         tempValue = GetRow2DArray(data, right);
         rightValue = GetRow2DArray(data, newPivot);
         SetRow2DArray(data, newPivot, tempValue);

         return newPivot;
      }
   }
}