class Scripture
{
    public Reference Reference { get; private set; }
    public List<Word> Words { get; private set; }
    public bool AllWordsHidden => Words.All(word => word.IsHidden);

    public Scripture(string reference, string text)
    {
        Reference = new Reference(reference);
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        foreach (var word in Words)
        {
            if (random.Next(2) == 0) // 50% chance to hide each word
            {
                word.Hide();
            }
        }
    }

    public void Display()
    {
        Console.WriteLine(Reference);
        Console.WriteLine(string.Join(" ", Words.Select(word => word.ToString())));
    }
}
