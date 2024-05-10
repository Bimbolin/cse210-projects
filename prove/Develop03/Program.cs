using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a scripture reference (e.g., 'John 3:16' or 'Proverbs 3:5-6'):");
        string referenceInput = Console.ReadLine();
        Console.WriteLine("Enter the scripture text:");
        string scriptureText = Console.ReadLine();

        Scripture scripture = new Scripture(referenceInput, scriptureText);

        do
        {
            Console.Clear();
            scripture.Display();
            Console.WriteLine("\nPress enter to hide words or type 'quit' to exit.");
            string command = Console.ReadLine();

            if (command.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords();
        } while (!scripture.AllWordsHidden);
    }
}
