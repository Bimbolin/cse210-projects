public class ListingActivity : Activity
{
    private string[] listingPrompts = {
        "Who are people that you appreciate?",
        "What are your personal strengths?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
        
    };

    public ListingActivity() : base("Listing Activity", "Reflect on the good things in your life by listing as many things as you can in a certain area.")
    {
    }

    public override void ExecuteActivity()
    {
        Console.WriteLine("Prepare to begin the Listing Activity.");
        Console.WriteLine("Think about the following prompts:");

        Random random = new Random();
        for (int i = 0; i < durationSeconds; i++)
        {
            string prompt = listingPrompts[random.Next(listingPrompts.Length)];
            Console.WriteLine(prompt);
            PauseWithSpinner();
        }

        Console.WriteLine("You've completed the Listing Activity. Take a moment to reflect.");
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
