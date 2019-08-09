using System;
using System.Collections.Generic;
using GradeBook.Abstractions;

namespace GradeBook.Classes
{
    public class InMemoryBook : Book
    {
        private List<double> _grades;
        public override event GradeAddedDelegate GradeAdded;

        public InMemoryBook(string name) : base(name)
        {
            _grades = new List<double>();
        }

        public override void AddGrade(double grade)
        {
            if(grade >= 0 && grade <= 100)
            {
                _grades.Add(grade);

                if(GradeAdded != null) 
                {
                    GradeAdded(this, new GradeBookEventArgs(grade));
                }
            }

            throw new ArgumentException($"Grade {grade} must be more greater or equal than zero and more less than one hundred.");
        }

        public override Statistics GetStatistics()
        {
            var result = new Statistics();
            for(var i = 0; i < _grades.Count; i++)
            {
                result.Add(_grades[i]);
            }

            return result;
        }
    }
}