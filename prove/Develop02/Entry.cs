class Entry
{
    public string _date;
    public string _prompt;
    public string _response;
    public string[] _prompts =
    {
        "How was your day?",
        "What did you do today?",
        "How was you week?"
    };

    public void DisplayEntry()
    {

    }
    public void CreateEntry()
    {
        Random random = new Random();
        string randomPrompt = _prompts[random.Next(_prompts.Length)];

        Console.WriteLine(randomPrompt);
        string userResponce = Console.ReadLine();
    }
    public void CreateEntryWithData()
    {
        DateTime _date = DateTime.Now;
        Console.WriteLine(_date);
    }
}