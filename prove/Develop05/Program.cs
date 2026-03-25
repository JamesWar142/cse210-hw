using System;

class Program
{
    static void Main(string[] args)
    {
        Goals goal1 = new Goals("random goal", 100, "complete a goal", "Normal");
        Console.WriteLine(goal1.GoalInformation());
    }
}