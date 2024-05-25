[Serializable]
public abstract class Goal
{
    public string Name { get; private set; }
    public string Description { get; protected set; }
    public int Points { get; protected set; }
    public bool IsComplete { get; protected set; }

    protected Goal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
        IsComplete = false;
    }

    protected Goal(string description, int pointsPerEvent)
    {
        Description = description;
    }

    public abstract void RecordEvent();
    public virtual string Display()
    {
        return $"{Name} - {Description}: {GetStatus()}";
    }

    protected abstract string GetStatus();
}