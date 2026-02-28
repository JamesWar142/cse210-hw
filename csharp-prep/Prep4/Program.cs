using System;

class Program
{
    static void Main(string[] args)
    {
        int total = 0;
        int number = -1;
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        int highest = number;
        int smallest = 1000000000;
        foreach (int i in numbers)
            {
                total = total + i;
                if (highest < i)
                {
                    highest = i;
                }
                if ((i < smallest && i > 0) || smallest < 0)
                {
                    smallest = i;
                }
            }
        float average = ((float)total)/numbers.Count;
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {highest}");
        Console.WriteLine($"The smallest positive number is: {smallest}");
        numbers.Sort();
        Console.WriteLine($"The sorted list is:");
        foreach (int x in numbers)
        {
            Console.WriteLine(x);
        }
    }
}