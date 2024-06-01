public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points) { }

    public override void RecordEvent()
    {
        if (!IsComplete)
        {
            IsComplete = true;
            Points = Points; 
            Console.WriteLine($"{Name} completed!");
        }
    }

    protected override string GetStatus()
    {
        return IsComplete ? "[X]" : "[ ]";
    }
}