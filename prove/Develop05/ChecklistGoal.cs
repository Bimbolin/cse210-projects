[Serializable]
public class ChecklistGoal : Goal
{
    private int TargetCount;
    private int CurrentCount;
    private int BonusPoints;

    public ChecklistGoal(string name, string description, int pointsPerEvent, int targetCount, int bonusPoints) : base(name, description, pointsPerEvent)
    {
        TargetCount = targetCount;
        BonusPoints = bonusPoints;
        CurrentCount = 0;
    }

    public override void RecordEvent()
    {
        if (CurrentCount < TargetCount)
        {
            CurrentCount++;
            Points += Points;
            if (CurrentCount == TargetCount)
            {
                Points += BonusPoints;
                IsComplete = true;
                Console.WriteLine($"{Name} goal reached! Bonus earned: {BonusPoints} points.");
            }
        }
    }

    protected override string GetStatus()
    {
        return IsComplete ? $"[X] Completed {CurrentCount}/{TargetCount} times" : $"[ ] Completed {CurrentCount}/{TargetCount} times";
    }
}