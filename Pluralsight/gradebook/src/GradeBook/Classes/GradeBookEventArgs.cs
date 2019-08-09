using System;

public class GradeBookEventArgs : EventArgs
{
    public double Grade { get; set; }

    public GradeBookEventArgs(double grade)
    {
        Grade = grade;
    }
}