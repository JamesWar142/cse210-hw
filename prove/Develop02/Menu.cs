class Menu
{
    public void DisplayMenu()
    {
        Console.WriteLine("Please Select one of the choices bellow:");
        Console.WriteLine("1: Write");
        Console.WriteLine("2: Display");
        Console.WriteLine("3: Save");
        Console.WriteLine("4: Load");
        Console.WriteLine("5: Quit");
    }
    public string MenuChoice()
    {
        //we use public string as we want to keep response
        Console.Write("What would you like to do: ");
        return Console.ReadLine();
        // return is used to identify proper string
    }
}