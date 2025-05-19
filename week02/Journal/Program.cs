using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        Console.WriteLine("Welcome to the Journal Program!");
        
        while (true)
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Exit");

            Console.Write("What would you like to do? ");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
              
                case 1:
                    PromptGenerator promptGenerator = new PromptGenerator();
                    string promptText = promptGenerator.GetRandomPrompt();

                    DateTime theCurrentTime = DateTime.Now;
                    string dateText = theCurrentTime.ToShortDateString();

                    Console.Write($"Prompt: {promptText}\nEnter your response: ");
                    String entryText = Console.ReadLine();

                    Entry newEntry = new Entry(dateText, promptText, entryText);

                    theJournal.AddEntry(newEntry);
                    Console.WriteLine();
                    break;
                case 2:
                    theJournal.DisplayAll();
                    break;
                case 3:
                    theJournal.SaveToFile();
                    break;
                case 4:
                    theJournal.LoadFromFile();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;

            }
            

        }
    }
}