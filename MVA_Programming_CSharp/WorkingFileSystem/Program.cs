using System;
using System.Diagnostics;
using System.IO;
using System.IO.IsolatedStorage;

namespace WorkingFileSystem
{
   class Program
   {
      static void Main(string[] args)
      {
         CreatingFiles();
         WorkingWithFolders();
      }

      private static void PrintTitle(string title)
      {
         Console.WriteLine(new string('-', 50));
         Console.WriteLine(title);
         Console.WriteLine(new string('-', 50));
      }

      /// <summary>
      /// Creating files using the File class and its static methods 'WriteAllText' and 'ReadAllText'
      /// </summary>
      private static void CreatingFiles()
      {
         PrintTitle("Creating Files with 'File.WriteAllText' method");
         const string fileName = "MyFile.txt";
         //string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), fileName);
         string filePath = Path.Combine(Directory.GetCurrentDirectory(), fileName);

         string fileContent = "This is a default content for the new file that we are going to create, using the 'File.WriteAllText' method";

         //Create file
         File.WriteAllText(filePath, fileContent);

         //Read file
         string read = File.ReadAllText(filePath);
         Debug.Assert(read.Equals(fileContent));
      }

      /// <summary>
      /// Working with Directories
      /// </summary>
      private static void WorkingWithFolders()
      {
         PrintTitle("Working with Folders");

         //Special Folders
         var docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
         var app = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
         var prog = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
         var desk = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

         //Application Folder
         var dir = Directory.GetCurrentDirectory();

         //Isolated Storage Folders
         var iso = IsolatedStorageFile.GetStore(IsolatedStorageScope.Assembly, "Demo").GetDirectoryNames("*");

         //Manual Path
         var manual = new DirectoryInfo("C.\\MyFolder");             
      }

      /// <summary>
      /// Working with Files
      /// </summary>
      private static void WorkingWithFiles()
      {
         PrintTitle("Working with Files");

         string dir = Directory.GetCurrentDirectory();

         //Read files
         foreach (string filePath in Directory.GetFiles(dir))
            Console.WriteLine(Path.GetFileName(filePath));

         //Rename/Move
         string path1 = "C:\\temp\file1.txt";
         string path2 = "C:\\temp\file2.txt";

         File.Move(path1, path2);

         //File Info
         FileInfo fileInfo = new FileInfo(path2);
         Console.WriteLine("{0}Kb", fileInfo.Length / 1000);
      }
   }
}