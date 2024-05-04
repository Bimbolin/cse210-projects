public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(string prompt, string response, string filename)
    {
        _entries.Add(new Entry(prompt, response, filename ));
    }

    public void DisplayJournal()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveJournal(string filename)
    {
        using (StreamWriter file = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                file.WriteLine(entry);
            }
        }
    }

    public void LoadJournal(string filename)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            AddEntry(parts[1].Trim(), parts[2].Trim(), filename);
        }
    }
}
