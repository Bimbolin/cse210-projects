    using System;
using System.Threading;

public class ReflectionActivity : Activity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
        // Add more prompts as needed
    };

    public ReflectionActivity() : base("Reflection Activity", "Reflect on times in your life when you've shown strength and resilience. Recognize your power and how you can apply it in other aspects of your life.")
    {
    }

    public override void ExecuteActivity()
    {
        Console.WriteLine("Prepare to begin the Reflection Activity.");
        Console.WriteLine("Think about the following prompts:");

        Random random = new Random();
        for (int i = 0; i < durationSeconds; i++)
        {
            string prompt = prompts[random.Next(prompts.Length)];
            Console.WriteLine(prompt);

            // Allow user input (you can display a spinner during pause)
            PauseWithSpinner();
        }

        Console.WriteLine("You've completed the Reflection Activity. Take a moment to reflect.");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey(); // Wait for user input before ending
    }

    private void PauseWithSpinner()
    {
        Console.Write("Processing");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(".");
            Thread.Sleep(3000); 
        }
        Console.WriteLine();
    }
}
