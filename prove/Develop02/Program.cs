using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        Journal journal = new Journal();
        Prompt genPrompt = new Prompt();

        bool running = true;

        while (running)
        {
            menu.DisplayMenu();
            string choice = menu.MenuChoice();
            
            if (choice == "1")
            {
                // get prompt
                string prompt = genPrompt.getPrompt();
                Console.WriteLine($"Prompt: {prompt}");

                // get response
                Console.Write("Response: ");
                string response = Console.ReadLine();

                // create the entry WITH data
                Entry newEntry = new Entry(prompt, response);

                // save the entry
                journal.AppendEntry(newEntry);
            }
            else if (choice == "2")
            {
                Console.WriteLine("\n-----Entries-----");
                journal.DisplayEntries();
            }
            else if (choice == "3")
            {
                journal.SaveFile();
            }
            else if (choice == "4")
            {
                Console.Write("Choose file to load entries: ");
                string loadFile = Console.ReadLine();
                journal.LoadFile(loadFile);
            }
            else if (choice == "5")
            {
                running = false;
                break;
            }
            else
            {
                Console.WriteLine("Please make a proper choice");
            }
        }
    }
}
