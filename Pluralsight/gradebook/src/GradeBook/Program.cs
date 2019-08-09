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
            
            string userBookType = GetUserInput("Please select a book type (0: InMemory, 1: InDisk):", new UserInputCriteria { Values = new []{ "0", "1" }});
            string gradeBookName = GetUserInput("Please enter a name for the GradBook:", new UserInputCriteria { DataType = typeof(string) });

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

            // Entry user input
            string userInput = string.Empty;
            Func<string, bool> isValidGrade = input => !input.ToLowerInvariant().Equals(OUT_COMMAND);

            do
            {
                userInput = GetUserInput("Enter a grade:", new UserInputCriteria { DataType = typeof(double), Values = new []{ OUT_COMMAND } });

                if(isValidGrade(userInput))
                {
                    _book.AddGrade(double.Parse(userInput));
                }
            } while(isValidGrade(userInput));

            // Show statistics
            var statistics = _book.GetStatistics();
            Console.WriteLine(string.Empty);
            Console.WriteLine($"GradeBook : {_book.Name} - Statistics.");
            Console.WriteLine($"{nameof(statistics.Average)}: {statistics.Average:N2}.");
            Console.WriteLine($"{nameof(statistics.High)}: {statistics.High:N2}.");
            Console.WriteLine($"{nameof(statistics.Low)}: {statistics.Low:N2}.");
            Console.WriteLine($"{nameof(statistics.Letter)}: {statistics.Letter}.");
        }

        static string GetUserInput(string message, UserInputCriteria userInputCriteria)
        {
            bool isValid = false;
            string userInput = string.Empty;

            do 
            {
                Console.WriteLine(message);
                userInput = Console.ReadLine();

                if(userInputCriteria.DataType != null)
                {
                    TypeConverter converter = TypeDescriptor.GetConverter(userInputCriteria.DataType);
                    isValid = converter.IsValid(userInput);
                }

                if(userInputCriteria.Values.Length > 0 && !isValid) 
                {
                    isValid = Array.IndexOf(userInputCriteria.Values, userInput) != -1;
                }

            } while(!isValid);

            return userInput;
        }
    }
}