using System;

class Program
{
    public static void Greeting()
    {
        Console.WriteLine("Hello Bob");
    }

    public static int AddNumbers(int n1, int n2)
    {
        return n1 + n2;
    }
    static void Main(string[] args)
    {
        Greeting();
        // for(int i = 0; i < 10; i += 3)
        // {
        //     Console.WriteLine(i);
        // }

        // int y = 10;
        // int z = ++y;
        // Console.WriteLine(y);
        // Console.WriteLine(z);

        // for(int i = 100000; i >= -100000; i -= 10000)
        //     Console.WriteLine(i);

        // bool done = false;

        // do
        // {
        //     Console.Write("Please input your age: ");
        //     int age = int.Parse(Console.ReadLine());
        //     if (age >= 0 && age <= 125)
        //     {
        //         done = true;
        //         Console.WriteLine("Thank you.");
        //     }
        //     else
        //     {
        //         Console.WriteLine("Please input a valid age.");
        //     }
        // } while(!done);

//         Console.WriteLine("Hello Sandbox World!");

//         int age;
//         Console.Write("Please input your age: ");
//         age = int.Parse(Console.ReadLine());

//         Console.WriteLine($"Your age is: {age}");

//         if (age <= 100)
//         {
//             Console.WriteLine("You are cool");
//         }
//         else if (age <= 150)
//         {
//             Console.WriteLine("You are sort of cool");
//         }


        // List<int> myData = new List<int>();
        // myData.Add(10);
        // myData.Add(11);
        // myData.Add(12);
        // myData.Add(13);
        // myData.Add(14);
        // myData.Add(15);

        // Console.WriteLine(myData.Count);

        // foreach(int i in myData)
        // {
        //     Console.WriteLine(i);
        // }
    }
}