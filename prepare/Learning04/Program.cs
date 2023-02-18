using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment stu1 = new Assignment("Gozie", "Making Billions to Trillions");
        Console.WriteLine(stu1.GetSummary());
        Console.WriteLine();

        MathAssignment stu2 = new MathAssignment("Nwangele", "Calculus", "Chapter 15", "96-100");
        Console.WriteLine(stu2.GetSummary());
        Console.WriteLine(stu2.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment stu3 = new WritingAssignment("Benji Nwangele", "High Finance", "The merger of High Finance with High Tech");
        Console.WriteLine(stu3.GetSummary());
        Console.WriteLine(stu3.GetWritingInformation());
    }
}