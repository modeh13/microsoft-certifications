using System;
using System.IO;
using GradeBook.Abstractions;

namespace GradeBook.Classes
{
    public class InDiskBook : Book
    {
        public string FileName 
        { 
            get
            {
                return $"{Name}.txt";
            }
        }
        public override event GradeAddedDelegate GradeAdded;

        public InDiskBook(string name) : base(name)
        {
            if(File.Exists(FileName)) {
                File.Delete(FileName);
            }
        }        

        public override void AddGrade(double grade)
        {
            if(grade >= 0.0 && grade <= 100.0)
            {    
                // Base classes                 
                // MarshalByRefObject   - BinaryWriter  - BinaryReader
                // All classes inherit of MarshalByRefObject
                // 1.) Stream
                // - FileStream, BufferdStream, MemoryStream
                // 2.) TextWriter
                // - StreamWriter, StringWriter
                // 3.) TextReader
                // - StreamReader, StringReader
                using(var writer = new StreamWriter(FileName, true, System.Text.Encoding.UTF8))
                {
                    writer.WriteLine(grade);
                }

                if(GradeAdded != null) 
                {
                    GradeAdded(this, new GradeBookEventArgs(grade));
                }

                return;
            }

            throw new ArgumentException($"Grade {grade} must be more greater or equal than zero and more less than one hundred.");            
        }        

        public override Statistics GetStatistics()
        {
            var result = new Statistics();            

            using(var stream = File.OpenRead(FileName))
            {
                using(var reader = new StreamReader(stream, System.Text.Encoding.UTF8))
                {
                    string line = string.Empty;
                    while ((line = reader.ReadLine()) != null)
                    {
                        double grade = double.Parse(line);
                        result.Add(grade);
                    }
                }
            }

            return result;
        }        
    }
}