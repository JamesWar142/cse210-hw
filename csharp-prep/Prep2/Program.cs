using System;

class Program
{
    static void Main(string[] args)
    {
        string letter;
        string symbol;
        Console.Write("What is your grade: ");
        int grade = int.Parse(Console.ReadLine());
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        symbol = "";
        if (letter != "A" && letter != "F")
        {
            int symbolNum = grade % 10;
            if (symbolNum >= 7)
            {
                symbol = "+";
            }
            else if (symbolNum < 3)
            {
                symbol = "-";
            }
        }

        Console.WriteLine($"Your grade is {letter}{symbol}");
        if (grade >= 70)
        {
            Console.WriteLine("You passed the class");
        }
        else
        {
            Console.WriteLine("You failed the class");
        }

    }
}