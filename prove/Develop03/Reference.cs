public class Reference
{
    public string Book { get; private set; }
    public int Chapter { get; private set; }
    public int StartVerse { get; private set; }
    public int? EndVerse { get; private set; }

    public Reference(string reference)
    {
        var parts = reference.Split(' ');
        Book = parts[0];
        var chapterAndVerse = parts[1].Split(':');
        Chapter = int.Parse(chapterAndVerse[0]);
        var verses = chapterAndVerse[1].Split('-');
        StartVerse = int.Parse(verses[0]);
        EndVerse = verses.Length > 1 ? int.Parse(verses[1]) : (int?)null;
    }

    public override string ToString()
    {
        return $"{Book} {Chapter}:{StartVerse}" + (EndVerse != null ? $"-{EndVerse}" : "");
    }
}