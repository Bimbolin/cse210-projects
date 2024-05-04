public class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }
    public string Filename { get; set; }

    public Entry(string prompt, string response, string filename )
    {
        Prompt = prompt;
        Response = response;
        Date = DateTime.Now.ToString("yyyy-MM-dd");
        Filename = filename;
    }

    public override string ToString()
    {
        return $"{Date} | {Prompt} | {Response}";
    }
}