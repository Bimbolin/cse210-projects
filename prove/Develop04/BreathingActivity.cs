 using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by guiding you through slow breathing exercises. Clear your mind and focus on your breath.")
    {
    }

    public override void ExecuteActivity()
    {
        Console.WriteLine("Prepare to begin the Breathing Activity.");
        Console.WriteLine("Get comfortable and follow the instructions:");

        for (int i = 0; i < durationSeconds; i++)
        {
            Console.WriteLine("Breathe in...");
            PauseWithSpinner();
            Console.WriteLine("Breathe out...");
            PauseWithSpinner();
        }

        Console.WriteLine("You've completed the Breathing Activity. Take a moment to relax.");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey(); 
    }

    private void PauseWithSpinner()
    {     
        Console.Write("Processing");
        for (int i = 0; i < 3; i++)
        {
            Console.Write(".");
            Thread.Sleep(3000);
        }
        Console.WriteLine();
    }
}
