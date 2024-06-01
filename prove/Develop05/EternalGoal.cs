public class EternalGoal : Goal
{
    private int _pointsPerEvent;

    public EternalGoal(string name, string description, int pointsPerEvent) : base(name, description, pointsPerEvent)
    {
        _pointsPerEvent = pointsPerEvent;
    }

    public override void RecordEvent()
    {
        Points += _pointsPerEvent; 
    }

    protected override string GetStatus()
    {
        return $"[ ] {Points} points";
    }
}