using System;
using System.Collections.Generic;
using System.Collections;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Mindfulness App!\n");

        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        StartBreathingActivity();
                        break;
                    case 2:
                        StartReflectingActivity();
                        break;
                    case 3:
                        StartListingActivity();
                        break;
                    case 4:
                        Console.WriteLine("Exiting the program. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }

            Console.WriteLine(); // Add a newline for better formatting
        }
    }

    static void StartBreathingActivity()
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        breathingActivity.Run();

        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();
    }

    static void StartReflectingActivity()
    {
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        reflectingActivity.Run();

        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();
    }

    static void StartListingActivity()
    {
        ListingActivity listingActivity = new ListingActivity();
        listingActivity.Run();

        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();
    }
}
