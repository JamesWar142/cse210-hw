using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture john3 = new Scripture("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        Ref myref = new Ref("John 3:15 ");

       while (true)
        {
            Console.Clear();
            Console.WriteLine("Press enter to hide words or type quit to end the practice.");
            Console.WriteLine();
            Console.WriteLine(myref.Reference() + john3.GetScripture());
            string input = Console.ReadLine();
            if (input != null && input == "quit")
                break;
            if (john3.AllHidden())
                {
                    break;
                }
            john3.HideWords(3);
        }
    }
}