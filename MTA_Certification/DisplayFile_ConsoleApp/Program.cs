using System;
using System.IO;

namespace DisplayFile_ConsoleApp
{
   class Program
   {
      //Console Application
      //Working with command line.
      //We need to open new cmd.exe window and go to folder where "Console Application" file .exe is and execute the following command.
      //DisplayFile_ConsoleApp ##File path.
      //Example: DisplayFile_ConsoleApp fileSample.txt

      //Also we can set the command line arguments from Project's properties in Right Click->Properties, and then select DEBUG section.
      static void Main(string[] args)
      {
         if (args.Length < 1) return;

         string[] lines = File.ReadAllLines(args[0]);

         foreach (string line in lines)
         {
            Console.WriteLine(line);
         }

         Console.ReadKey();
      }
   }
}