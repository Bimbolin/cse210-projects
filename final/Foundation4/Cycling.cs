public class Cycling : Activity
{
    public double Speed { get; private set; } // in kilometers per hour

    public Cycling(DateTime date, int durationInMinutes, double speed)
        : base(date, durationInMinutes)
    {
        Speed = speed;
    }

    public override double GetDistance() => (Speed * DurationInMinutes) / 60;
    public override double GetSpeed() => Speed;
    public override double GetPace() => 60 / Speed;
}