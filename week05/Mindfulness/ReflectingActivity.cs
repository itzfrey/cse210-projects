public class ReflectingActivity : Activity
{
    private List<string> _prompts;

    private List<string> _questions;

    public ReflectingActivity() : base("Reflecting", "This activity will help you reflect on times when you have shownn strength and resilience. This will help you recognize the poser you have and how you can use it in other aspect of your life.", 30)
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
   
    }

    public new void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine();
        
        base.GetDurationInput();
        
        Console.WriteLine("Get ready...");
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();

        string randomPrompt = GetRandomPrompt();
        Console.WriteLine($" --- {randomPrompt} --- ");

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience. \nYou may begin in:");
        Console.Write("You may begin in :");
        ShowCountDown(5);
        Console.WriteLine();
        
        while (_duration > 0)
        {
            DisplayQuestions();

            _duration -= 6; 
        }

        base.DisplayEndingMessage(); // Call the base class DisplayEndingMessage for the standard finishing message
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"Prompt: {GetRandomPrompt()}");
    }

    public void DisplayQuestions()
    {
        foreach (var question in _questions)
        {
            Console.WriteLine();
            Console.Write($"{question}");
            ShowSpinner(3); 
           
        }
    }
}
