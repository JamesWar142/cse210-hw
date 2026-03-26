using System;

class Program
{
    static void Main(string[] args)
    {
        bool complete = false;
        SimpleGoal mySimpleGoal = new SimpleGoal();

        Console.WriteLine("Welcome to your Goal Tracker!");
        while (complete == false)
        {
            Console.WriteLine("1. View Goals");
            Console.WriteLine("2. Create a goal");
            Console.WriteLine("3. Complete a goal");
            Console.WriteLine("4. View Total Points");
            Console.WriteLine("5. Quit");
            Console.Write("Please select an option: ");
            int userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                Console.WriteLine(mySimpleGoal.GetConsoleString());
            }
            else if(userChoice == 2)
            {
                mySimpleGoal.CreateGoal();
            }
            else if(userChoice == 3)
            {
                
            }
            else if(userChoice == 4)
            {
                
            }
            else if(userChoice == 5)
            {
                Console.WriteLine("Goodluck with your goals!");
                complete = true;
            }
            else
            {
                Console.WriteLine("Please enter a proper choice.");
            }
        }
    }
}