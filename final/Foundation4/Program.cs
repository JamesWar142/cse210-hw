using System;

class Program
{
    static void Main(string[] args)
    {
        Activity activity= new Activity();
        var running = new Running(activity);
        var cycling = new Cycling(activity);
        var swimming = new Swimming(activity);
        Console.WriteLine("Welcome to fitness tracker. What activity would you like to do?");
        Console.WriteLine("a. Running");
        Console.WriteLine("b. Cycling");
        Console.WriteLine("c. Swimming");
        string choice=Console.ReadLine();
        switch (choice)
        {
            case "a":
                running.Date();
                running.Time();
                running.Distance();
                running.Calculations();
                running.GetSummary();
                break;
            case "b":
                cycling.Date();
                cycling.Time();
                cycling.Distance();
                cycling.Calculations();
                cycling.GetSummary();
                break;
            case "c":
                swimming.Date();
                swimming.Time();
                swimming.Distance();
                swimming.Calculations();
                swimming.GetSummary();
                break;
        }
    }
}