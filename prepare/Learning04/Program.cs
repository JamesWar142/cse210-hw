using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("James Wyatt", "Science");
        Math math = new Math("James Wyatt", "Math", "7.3", "8-19");
        Writing writing = new Writing("James Wyatt", "English", "Random Words");


        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}