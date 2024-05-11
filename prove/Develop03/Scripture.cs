public class Scripture
{
    private Reference Reference { get; set; }
    private List<Word> Words { get; set; }
    public bool IsFullyHidden => Words.All(w => w.IsHidden);

    public Scripture(string reference, string text)
    {
        Reference = new Reference(reference);
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords()
    {
        var random = new Random();
        foreach (var word in Words)
        {
            if (random.Next(2) == 0) word.Hide();
        }
    }

    public override string ToString()
    {
        return $"{Reference} {string.Join(" ", Words.Select(w => w.ToString()))}";
    }
}
