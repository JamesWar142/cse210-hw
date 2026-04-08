using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address();
        var lecture = new Lectures(address);
        var reception = new Reception(address);
        var outdoor = new Outdoor(address);


        address.Location();
        Console.WriteLine("\nWhat type of event do you want to be held?");
        Console.WriteLine("a: Lecture");
        Console.WriteLine("b: Reception");
        Console.WriteLine("c: Outdoor");
        string eventType = Console.ReadLine();
        Console.WriteLine("\nWhat type message do you want to see?");
        Console.WriteLine("a: Standard");
        Console.WriteLine("b: Full");
        Console.WriteLine("c: Short");
        string message = Console.ReadLine();

        switch (eventType)
        {
            case "a":
                switch (message)
                {
                    case "a":
                        lecture.Standard();
                        lecture.Info();
                        break;
                    case "b":
                        lecture.Full();
                        lecture.Standard();
                        lecture.Info();
                        break;
                    case "c":
                        lecture.Short();
                        break;
                } break;
            case "b":
                switch (message)
                {
                    case "a":
                        reception.Standard();
                        reception.Info();
                        break;
                    case "b":
                        reception.Full();
                        reception.Standard();
                        reception.Info();
                        break;
                    case "c":
                        reception.Short();
                        break;
                } break;
            case "c":
                switch (message)
                {
                    case "a":
                        outdoor.Standard();
                        outdoor.Info();
                        break;
                    case "b":
                        outdoor.Full();
                        outdoor.Standard();
                        outdoor.Info();
                        break;
                    case "c":
                        outdoor.Short();
                        break;
                } break;
        }
    }
}