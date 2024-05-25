using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Program
{
    public static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nMenu Option:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Exit");
            Console.Write("Select an option: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    CreateNewGoal(goalManager);
                    break;
                case "2":
                    ListGoals(goalManager);
                    break;
                case "3":
                    SaveGoals(goalManager);
                    break;
                case "4":
                    goalManager = LoadGoals();
                    break;
                case "5":
                    RecordEvent(goalManager);
                    break;
                case "6":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }

    private static void CreateNewGoal(GoalManager goalManager)
    {
        Console.WriteLine("The type of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int goalType = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        Goal goal;
        switch (goalType)
        {
            case 1:
                goal = new SimpleGoal(name, description, points);
                break;
            case 2:
                goal = new EternalGoal(name, description, points);
                break;
            case 3:
                Console.Write("Enter target count: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                goal = new ChecklistGoal(name, description, points, targetCount, bonusPoints);
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                return;
        }

        goalManager.AddGoal(goal);
        Console.WriteLine("Goal added successfully!");
    }

    private static void ListGoals(GoalManager goalManager)
    {
        Console.WriteLine("The goals are:");
        foreach (var goal in goalManager.Goals)
        {
            Console.WriteLine(goal.Display());
        }
        Console.WriteLine("You have {0} points", goalManager.Score);
    }

    private static void SaveGoals(GoalManager goalManager)
    {
        Console.WriteLine("Enter file path to save progress:");
        string filePath = Console.ReadLine();
        using (Stream stream = File.Open(filePath, FileMode.Create))
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(goalManager, options);
            using (var writer = new StreamWriter(stream))
            {
                writer.Write(jsonString);
            }
        }
        Console.WriteLine("Progress saved successfully!");
    }

    private static GoalManager LoadGoals()
    {
        Console.WriteLine("Enter file path to load progress:");
        string filePath = Console.ReadLine();
        using (Stream stream = File.Open(filePath, FileMode.Open))
        {
            using (var reader = new StreamReader(stream))
            {
                string jsonString = reader.ReadToEnd();
                return JsonSerializer.Deserialize<GoalManager>(jsonString);
            }
        }
    }

    private static void RecordEvent(GoalManager goalManager)
    {
        Console.WriteLine("Enter the description of the goal for the event:");
        string goalDescription = Console.ReadLine();
        goalManager.RecordEvent(goalDescription);
        Console.WriteLine("Event recorded successfully!");
    }
}

// Define your GoalManager, Goal, SimpleGoal, EternalGoal, and ChecklistGoal classes here
