public abstract class Event
{
    public string Title { get; private set; }
    public string Description { get; private set; }
    public DateTime Date { get; private set; }
    public TimeSpan Time { get; private set; }
    public Address EventAddress { get; private set; }

    protected Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        Title = title;
        Description = description;
        Date = date;
        Time = time;
        EventAddress = address;
    }

    public string GetStandardDetails()
    {
        return $"{Title}\n{Description}\nDate: {Date.ToShortDateString()}\nTime: {Time}\nAddress: {EventAddress}";
    }

    public abstract string GetFullDetails();
    public abstract string GetShortDescription();

        
}