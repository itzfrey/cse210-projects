public class Activity
{
    protected string _name;
    
    protected string _description;

    protected int _duration;

    public Activity(string name, string description, int defaultDuration)
    {
        _name = name;
        _description = description;
        _duration = defaultDuration;
    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayEndingMessage();
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to {_name} Activity!");
       
        Console.WriteLine(_description);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done! You have completed the {_name} Activity.");
    }

    public void GetDurationInput()
    {
        Console.Write("How long, in seconds would you like for your session? ");
        while (!int.TryParse(Console.ReadLine(), out _duration) || _duration <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer for the duration.");
            Console.Write("Duration (seconds): ");
        }
    }

    public void ShowSpinner(int seconds)
    {
        
        List<string> animationStrings = new List<string> {"|", "/", "-", "\\"};
      
        foreach (string s in animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(1000);

            Console.Write("\b \b");
        }
        Console.WriteLine();
        
    }
    

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}  