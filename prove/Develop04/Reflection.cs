class Reflection : BaseActivity
{
    private string[] _prompts = {
        "Think of a time you helped someone in need.",
        "Recall a moment where you overcame a difficult challenge.",
        "Think of a time when you made a positive difference."
    };

    private string[] _questions = {
        "Why was this experience meaningful?",
        "What did you learn from it?",
        "How can you apply this in the future?",
        "How did this event shape who you are?"
    };

    private int _duration;

    public Reflection(string name, string description, int duration): 
    base(name, description)
    {
        _duration = duration;
    }

    public void PerformActivity()
    {
        Random rand = new Random();

        DisplayGreeting();
        DisplayDescription();

        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($" --- {_prompts[rand.Next(_prompts.Length)]} --- ");
        Console.WriteLine("When you have something in mind, press anyting to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on the following questions:");
        DisplaySpinner("Are you ready?", 3);

        int timeLeft = _duration;

        while (timeLeft > 0)
        {
            Console.WriteLine("> " + _questions[rand.Next(_questions.Length)]);
            Console.ReadLine();
            DisplaySpinner("", 3);
            timeLeft -= 3;
        }
    }
}
