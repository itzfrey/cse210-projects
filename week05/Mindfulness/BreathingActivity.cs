public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 30)
    {

    }
    
    public new void Run()
    {
        DisplayStartingMessage();
        
        
        base.GetDurationInput(); // Use the base class method to get the duration input
        

        Console.WriteLine("Get ready...");
        ShowSpinner(3);

        while (_duration > 0)
        {
            Console.WriteLine();
            Console.Write($"Breathe in...");
            ShowCountDown(3);
            Console.WriteLine();

            Console.Write("Now breathe out...");
            ShowCountDown(3);
            Console.WriteLine();

            _duration -= 6;         }

        Console.WriteLine();
        base.DisplayEndingMessage();
    }
}