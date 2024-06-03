public class OutdoorGathering : Event
{
    public string WeatherForecast { get; private set; }

    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        WeatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Outdoor Gathering\nWeather: {WeatherForecast}";
    }

    public override string GetShortDescription()
    {
        return $"Outdoor Gathering: {Title} on {Date.ToShortDateString()}";
    }
}