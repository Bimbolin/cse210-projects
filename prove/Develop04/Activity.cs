public abstract class Activity
{
    private string name;
    private string description;
    protected int durationSeconds;

    public Activity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public void SetDuration(int duration)
    {
        durationSeconds = duration;
    }

    public abstract void ExecuteActivity();

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Great job! You've completed the " + name + ".");
        Console.WriteLine($"Total duration: {durationSeconds} seconds");
    }
}
