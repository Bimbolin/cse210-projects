using System;
using System.Collections.Generic;

class Program
{
    private static Journal journal = new Journal();
    private static List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
        
    };

  
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        String choice;
        do
        {
          Console.WriteLine("Please select one of the following choice:");
          Console.WriteLine("1. Write"); 
          Console.WriteLine("2. Display");
          Console.WriteLine("3. Load");
          Console.WriteLine("4. Save");
          Console.WriteLine("5. Quit");
          Console.Write("What whould you like to do?");
          choice = Console.ReadLine();
          switch (choice)
            {
                case "1":
                    WriteEntry();
                    break;
                case "2":
                    DisplayEntries();
                    break;
                case "3":
                    LoadEntries();
                    break;
                case "4":
                    SaveEntries();
                    break;
                case "5":
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
            Console.WriteLine();
        }
        while (choice != "5");
    }

    static void WriteEntry()
    {
        string filename = Console.ReadLine();  
        Random random = new Random();
        int randomIndexNum = random.Next(prompts.Count);
        string prompt = prompts[randomIndexNum];
        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        journal.AddEntry(prompt, response, filename);
    }

    static void DisplayEntries()
    {
        journal.DisplayJournal();
    }

    static void LoadEntries()
    {
        Console.Write("Enter the filename to load: ");
        string filename = Console.ReadLine();
        journal.LoadJournal(filename);
    }

    static void SaveEntries()
    {
        Console.Write("Enter the filename to save: ");
        string filename = Console.ReadLine();
        journal.SaveJournal(filename);
    }
}