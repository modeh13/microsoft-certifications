using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace WorkingDatabaseLINQ
{
   class Program
   {
      static void Main(string[] args)
      {
         WorkingWithLINQ();
      }

      private static void PrintTitle(string title)
      {
         Console.WriteLine(new string('-', 50));
         Console.WriteLine(title);
         Console.WriteLine(new string('-', 50));
      }

      /// <summary>
      /// Working with the ORM (Object Relational Mapping) - Entity Framework
      /// </summary>
      private static void WorkingWithEntityFramework()
      {
         PrintTitle("Working with Entity Framework");

         using (Entities context = new Entities())
         {
            //Using the DbSet<T> directly
            //var products = context.Products;
            //var products = context.Products.ToList();
            var products = context.Products.Where(x => x.Name.StartsWith("L"));

            foreach (Products product in products)
               Console.WriteLine(product.Name);

            //Making some changes
            var firstProduct = context.Products.First();
            firstProduct.Name = "Tickets";
            context.SaveChanges();
         }
      }

      // Working with the LINQ (Language Integrated Query)
      private static void WorkingWithLINQ()
      {
         IEnumerable<int> data = Enumerable.Range(1, 50);

         //Method syntax (Lambda)
         IEnumerable<string> method = data.Where(x => x % 2 == 0).Select(x => x.ToString());

         //Query syntax
         IEnumerable<string> query = from n in data
                                     where n % 2 == 0
                                     select n.ToString();

         //It's similar to "Breakpoint"
         Debugger.Break();

         //Dynamic data (Anonymous data)
         var projection = from n in data
                          select new
                          {
                             Even = (n % 2 == 0),
                             Odd = !(n % 2 == 0),
                             Value = n,
                          };

         Debugger.Break();

         var letters = new[] { "A", "C", "B", "E", "Q" };

         var sortAsc = from l in letters
                       orderby l ascending
                       select l;

         var sortDesc = letters.OrderByDescending(x => x);

         //Candy
         var values = new[] { "A", "B", "A" ,"C" ,"A", "D" };

         var distinct = values.Distinct();
         var first = values.First();
         var firstOr = values.FirstOrDefault();
         var last = values.Last();
         var lastOr = values.LastOrDefault();
         var page = values.Skip(2).Take(2);

         Debugger.Break();


         //Aggregates
         var numbers = Enumerable.Range(1, 50);
         var any = numbers.Any(x => x % 2 == 0);
         var count = numbers.Count(x => x % 2 == 0);
         var sum = numbers.Sum();
         var max = numbers.Max();
         var min = numbers.Min();
         var avg = numbers.Average();

         Debugger.Break();

         var dictionary = new Dictionary<string, string>()
            {
                 {"1", "B"}, {"2", "A"}, {"3", "B"}, {"4", "A"},
            };

         var group = // IEnumerable<string, IEnumerable<string>>
             from d1 in dictionary
             group d1 by d1.Value into g
             select new
             {
                Key = g.Key,
                Members = g,
             };

         //IEnumerable<string, int>
         var group1 = dictionary.GroupBy(x => x.Value, (key, g) => new { Key = key, Count = g.Count() });

         Debugger.Break();

         var dictionary1 = new Dictionary<string, string>()
            {
                 {"1", "B"}, {"2", "A"}, {"3", "B"}, {"4", "A"},
            };

         var dictionary2 = new Dictionary<string, string>()
            {
                 {"5", "B"}, {"6", "A"}, {"7", "B"}, {"8", "A"},
            };

         var join =
             from d1 in dictionary1
             join d2 in dictionary2 on d1.Value equals d2.Value
             select new
             {
                Key1 = d1.Key,
                Key2 = d2.Key,
                Value = d1.Value
             };

         Debugger.Break();

      }
   }
}