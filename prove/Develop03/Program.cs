using System;

class Program
{
    static void Main(string[] args)
    {
        Word myword = new Word("Bob");
        Ref myref = new Ref("John 3:15 ");

        Console.WriteLine(myref.Reference() + myword.GetWordString());

        myword.HideWord();
        Console.WriteLine(myref.Reference() + myword.GetWordString());

        Word myWord2 = new Word("Moroni");

        Console.WriteLine(myWord2.GetWordString());

        myWord2.HideWord();
        Console.WriteLine(myWord2.GetWordString());
    }
}