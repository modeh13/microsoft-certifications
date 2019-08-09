using GradeBook.Classes;

namespace GradeBook.Abstractions
{
    public delegate void GradeAddedDelegate(object sender, GradeBookEventArgs args);

    public interface IBook
    {   
        string Name { get; }
        event GradeAddedDelegate GradeAdded;

        void AddGrade(double grade);
        Statistics GetStatistics();
    }
}