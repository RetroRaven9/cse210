using System;

class Scripture
{
    private string reference;
    private List<Word> words;
    private Random random;

    public Scripture(string reference, string text)
    {
        this.reference = reference;
        words = text.Split(' ').Select(word => new Word(word)).ToList();
        random = new Random();
    }

    public void HideRandomWord()
    {
        var visibleWords = words.Where(word => !word.Hidden).ToList();
        if (visibleWords.Count == 0)
            return;

        int index = random.Next(0, visibleWords.Count);
        visibleWords[index].Hide();
    }

    public string GetVisibleText()
    {
        return $"{reference}: {string.Join("", words.Select(word => word.Hidden ? "-" : word.Text))}";
    }
}
