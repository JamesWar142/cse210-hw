class Listing : BaseActivity
{
    private string[] _prompts = {
        "List as many things as you can that make you smile.",
        "List the people who have influenced you positively.",
        "List things you are grateful for today."
    };
    private int _duration;

    public Listing(string name, string description, int duration)
    : base(name, description)
    {
        _duration = duration;
    }

    public void PerformActivity()
    {
        Random rand = new Random();

        DisplayGreeting();
        DisplayDescription();

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($" --- {_prompts[rand.Next(_prompts.Length)]} --- ");
        Console.WriteLine("Press anyting to begin.");
        DisplaySpinner("Are you ready?", 3);

        List<string> entries = new List<string>();
        int endTime = Environment.TickCount + (_duration * 1000);

        while (Environment.TickCount < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            entries.Add(response);
        }

        Console.WriteLine($"\nYou listed {entries.Count} items!");
    }
}
