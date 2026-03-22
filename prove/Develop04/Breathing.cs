class Breathing : BaseActivity
{
    private int _duration;
    public Breathing(string name, string description, int duration)
    : base(name, description)
    {
        _duration = duration;
    }
    

    public void PerformActivity()
    {
        int timeLeft = _duration;

        while (timeLeft > 0)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(3000);
            Console.WriteLine("Breathe out...");
            Thread.Sleep(3000);

            timeLeft -= 6;
        }
    }
}