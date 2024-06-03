public class Reception : Event
{
    public string EmailForRSVP { get; private set; }

    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string emailForRSVP)
        : base(title, description, date, time, address)
    {
        EmailForRSVP = emailForRSVP;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Reception\nRSVP Email: {EmailForRSVP}";
    }

    public override string GetShortDescription()
    {
        return $"Reception: {Title} on {Date.ToShortDateString()}";
    }
}