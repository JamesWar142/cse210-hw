using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        
        bool running = true;

        while (running)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine();
            Console.Clear();

            if (choice == "4")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Enter duration in seconds: ");
                int duration = int.Parse(Console.ReadLine());

                if (choice == "1")
                {
                    Breathing breathing = new Breathing(
                        "Breathing", "This activity will help you to relax.", duration);
                    breathing.PerformActivity();
                }
                else if (choice == "2")
                {
                    Reflection reflection = new Reflection(
                        "Breathing", "This activity will help you think deeply about an experience.", duration);
                    reflection.PerformActivity();
                }
                else if (choice == "3")
                {
                    Listing listing = new Listing(
                        "Listing", "This activity will help you list things that have happened in your life.", duration);
                    listing.PerformActivity();
                }
                else
                {
                    Console.WriteLine("Please choose a valid option.");
                }

            }
        }
    }
}