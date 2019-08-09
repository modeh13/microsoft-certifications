using System;
using GradeBook.Classes;

namespace GradeBook.Abstractions
{
    public abstract class Book : IBook
    {  
        public string Name { get; set; }    
        public virtual event GradeAddedDelegate GradeAdded; 

        public Book(string name)
        {
            Name = name;            
        }

        public abstract void AddGrade(double grade);
        public virtual Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }
    }
}