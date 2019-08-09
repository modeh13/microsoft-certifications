using System;
using GradeBook.Classes;
using GradeBook.Abstractions;
using System.ComponentModel;

namespace GradeBook
{
    enum BookType : byte
    {
        InMemory,
        InDisk
    }

    class Program
    {
        private const string OUT_COMMAND = "q";
        private const string TITLE = "GradeBook App";
        static BookType BookType { get; set; }    
        static IBook _book;


        static void Main(string[] args)
        {
            Console.WriteLine(new string('-', 50));
            Console.WriteLine(TITLE);
            Console.WriteLine(new string('-', 50));
            
            string userBookType = GetUserInput("Please select a book type (0: InMemory, 1: InDisk):", "0", "1");
            string gradeBookName = GetUserInput("Please enter a name for the GradBook:", typeof(string));

            switch(userBookType)
            {
                case "0":
                    BookType = BookType.InMemory;
                    _book = new InMemoryBook(gradeBookName);
                    break;
                default:
                    BookType = BookType.InDisk;
                    //_book = new InDiskBook("");
                    break;
            }

            string userInput = GetUserInput("Enter a grade:", typeof(double), "q") as string;
            while(!userBookType.ToLowerInvariant().Equals(OUT_COMMAND))
            {
                _book.AddGrade(double.Parse(userInput));
                userInput = GetUserInput("Enter a grade:", typeof(double), "q") as string;
            }

            Console.ReadKey();            
        }

        static string GetUserInput(string message, params string[] allowedValues)
        {
            string userInput = string.Empty;

            while(Array.IndexOf(allowedValues, userInput) == -1) 
            {
                Console.WriteLine(message);
                userInput = Console.ReadLine();
            }

            return userInput;
        }

        static string GetUserInput(string message, Type allowedType, params string[] allowedValues)
        {
            string userInput = null;
            var converter = TypeDescriptor.GetConverter(allowedType);            

            // not valid && index == -1
            // 

            //true -- true
            while((userInput != null && !converter.IsValid(userInput)) 
                && Array.IndexOf(allowedValues, userInput) == -1) 
            {
                Console.WriteLine(message);
                userInput = Console.ReadLine();
            }

            return userInput;
        }
    }
}