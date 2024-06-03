public class Running : Activity
{
    public double Distance { get; private set; } // in kilometers

    public Running(DateTime date, int durationInMinutes, double distance)
        : base(date, durationInMinutes)
    {
        Distance = distance;
    }

    public override double GetDistance() => Distance;
    public override double GetSpeed() => (Distance / DurationInMinutes) * 60;
    public override double GetPace() => DurationInMinutes / Distance;
}