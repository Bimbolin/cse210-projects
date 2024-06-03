public class Swimming : Activity
{
    public int NumberOfLaps { get; private set; }

    public Swimming(DateTime date, int durationInMinutes, int numberOfLaps)
        : base(date, durationInMinutes)
    {
        NumberOfLaps = numberOfLaps;
    }

    public override double GetDistance() => NumberOfLaps * 50 / 1000.0;
    public override double GetSpeed() => GetDistance() / (DurationInMinutes / 60.0);
    public override double GetPace() => DurationInMinutes / GetDistance();
}