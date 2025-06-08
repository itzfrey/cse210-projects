public class ListingActivity : Activity
{
    private int _count;

    private List<string> _questions;

    public ListingActivity() :base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 10)
    {
        _questions = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
           
        };
    }

    public new void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine();

        base.GetDurationInput();
        Console.WriteLine();

        Console.WriteLine("Get ready...");
        ShowSpinner(3);

        
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        string randomPrompt = GetRandomPrompt();
        Console.WriteLine($"----- {randomPrompt} ----- ");

        Console.Write("You may begin in: ");
        ShowCountDown(5); 

        GetListFromUser();
        List<string> itemList = GetListFromUser();

        Console.WriteLine($"You entered {itemList.Count} items.");

        base.DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    private List<string> GetListFromUser()
    {
        List<string> itemList = new List<string>();

        while (_duration > 0)
        {
            string item = Console.ReadLine();
            itemList.Add(item);

            _duration--;
        }

        return itemList;
    }

}
