public class Journal
{
    public List<Prompt> _entries = new List<Prompt>();
    public void Date()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        Console.WriteLine(dateText);
    }
    public void ReadFromFile()
    {
        
    }
}