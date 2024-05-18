using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Well-Being App!");
        Console.WriteLine("Choose an activity:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Quit");
        Console.Write("Select a choice from the menu: ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                BreathingActivity breathingActivity = new BreathingActivity();
                Console.Write("Enter the duration (in seconds): ");
                int breathingDuration = int.Parse(Console.ReadLine());
                breathingActivity.SetDuration(breathingDuration);
                breathingActivity.ExecuteActivity();
                breathingActivity.DisplayEndingMessage();
                break;
            case 2:
                ReflectionActivity reflectionActivity = new ReflectionActivity();
                Console.Write("Enter the duration (in seconds): ");
                int reflectionDuration = int.Parse(Console.ReadLine());
                reflectionActivity.SetDuration(reflectionDuration);
                reflectionActivity.ExecuteActivity();
                reflectionActivity.DisplayEndingMessage();
                break;
            case 3:
                ListingActivity listingActivity = new ListingActivity();
                Console.Write("Enter the duration (in seconds): ");
                int listingDuration = int.Parse(Console.ReadLine());
                listingActivity.SetDuration(listingDuration);
                listingActivity.ExecuteActivity();
                listingActivity.DisplayEndingMessage();
                break;
            case 4:
                Console.WriteLine("Goodbye!");
                break;
            default:
                Console.WriteLine("Invalid choice. Please select 1, 2, 3, or 4.");
                break;
        }
    }
}