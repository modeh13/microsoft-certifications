using System;

namespace WorkingWithDateTime
{
   class Program
   {
      static void Main(string[] args)
      {
         DateTime dateTime = DateTime.Now;

         //Printing the DateTime values
         Console.WriteLine(dateTime);
         Console.WriteLine(dateTime.ToString());
         
         Console.WriteLine("Date - Short and Long");
         Console.WriteLine(dateTime.ToShortDateString());
         Console.WriteLine(dateTime.ToLongDateString());

         Console.WriteLine("Time - Short and Long");
         Console.WriteLine(dateTime.ToShortTimeString());
         Console.WriteLine(dateTime.ToLongTimeString());

         //Adding MILLISECONDS, SECONDS, MINUTES, DAYS, MONTHS, YEARS
         DateTime date1 = dateTime.AddDays(3);
         DateTime date2 = dateTime.AddMonths(1);
         DateTime dat32 = dateTime.AddYears(5);

         //Creating Datetimes instances
         DateTime birthDay = new DateTime(1991, 1, 9);
         DateTime birthDayFromString = DateTime.Parse("1991-01-09");

         //Substract time
         //TimeSpan: It represents the elapsed time between two specific DateTimes
         TimeSpan myAge = DateTime.Now.Subtract(birthDayFromString);
         Console.WriteLine(myAge.TotalDays);

         Console.ReadKey();
      }
   }
}