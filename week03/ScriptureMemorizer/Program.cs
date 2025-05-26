using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Create ScriptureLibrary and add some scriptures
        ScriptureLibrary library = new ScriptureLibrary();

        library.AddScripture(new Scripture(
            new Reference("John", 3, 16),
            "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."
        ));
        library.AddScripture(new Scripture(
            new Reference("Psalm", 23, 1),
            "The Lord is my shepherd, I shall not want."
        ));
        library.AddScripture(new Scripture(
            new Reference("Proverbs", 3, 5, 6),
            "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."
        ));

        Scripture currentScripture = library.GetRandomScripture();
        if (currentScripture == null)
        {
            Console.WriteLine("No scriptures found.");
            return;
        }

        Console.WriteLine(currentScripture.GetDisplayText());

        while (true)
        {
            Console.Write("\nPress Enter to hide words or type 'quit' to exit: ");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "quit")
                break;

            currentScripture.HideRandomWords(5);
            Console.WriteLine(currentScripture.GetDisplayText());

            if (currentScripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nAll words are hidden. Well done!");
                break;
            }
        }
    }
}

