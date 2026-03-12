using System;

class Program
{
    static void Main(string[] args)
    {
        Word myword = new Word("Bob");

        Console.WriteLine(myword.GetWordString());

        myword.HideWord();
        Console.WriteLine(myword.GetWordString());

        Word myWord2 = new Word("Moroni");

        Console.WriteLine(myWord2.GetWordString());

        myWord2.HideWord();
        Console.WriteLine(myWord2.GetWordString());
    }
}