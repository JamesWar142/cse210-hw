using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        bool done = false;
        int userResponse;
        do
        {
            userResponse = menu.ProcessMenu();
            switch (userResponse)
            {
                case 1:
                // Create new journal entry
                // Add entry to list of entries
                break;
                case 2:
                // Display journal entries
                break;
                case 3:
                // Save journal to file
                break;
                case 4:
                // Load journal from file
                break;
                case 5:
                    done = true;
                    break;
            }
        } while (!done);
    }
}