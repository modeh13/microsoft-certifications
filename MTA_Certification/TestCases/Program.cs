using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCases
{
   class Program
   {
      static void Main(string[] args)
      {
         //Testing the case - VUMINGO Exam test
         DisplayResult();
      }

      private static void DisplayResult()
      {
         //Top two
         foreach(var ranking in Rankings(true))
         {
            Console.WriteLine(ranking);
         }

         //All
         foreach (var ranking in Rankings(false))
         {
            Console.WriteLine(ranking);
         }
      }

      private static IEnumerable<string> Rankings(bool top2Only)
      {
         yield return "Jhon";
         yield return "Nancy";

         if (top2Only) yield break;
         yield return "Chris";
      }
   }
}