using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> number = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished : ");
        int userNumber = -1;

        // The user will enter numbers until they enter 0

        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());
            number.Add(userNumber);
        }
        Console.WriteLine("The Sum is: " + number.Sum());
        Console.WriteLine("The Average is: " + number.Average());
        Console.WriteLine("The Max Largest number is: " + number.Max());
        Console.WriteLine("The smallest positive number is: " + number.Where(x => x > 0).Min());
        Console.WriteLine("The sorted list is: ");
        number.Sort();
        foreach (int num in number)
        {
            Console.WriteLine(num);
        }

    }
}