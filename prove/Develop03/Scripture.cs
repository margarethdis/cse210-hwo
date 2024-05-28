class Scripture
{
    public Reference Reference { get; private set; }
    private List<Word> Words { get; set; }
    public bool AllWordsHidden => Words.All(word => word.IsHidden);

    public Scripture(string book, int chapter, int verse, string text)
    {
        Reference = new Reference(book, chapter, verse);
        Words = CreateWordsList(text);
    }

    private List<Word> CreateWordsList(string text)
    {
        List<Word> wordsList = new List<Word>();
        string[] textWords = text.Split(' ');
        foreach (string wordText in textWords)
        {
            wordsList.Add(new Word(wordText));
        }
        return wordsList;
    }

    public void PrintWithHiddenWords()
    {
        foreach (Word word in Words)
        {
            word.Print();
        }
        HideRandomWord();
    }

    private void HideRandomWord()
    {
        Random rand = new Random();
        List<Word> visibleWords = Words.Where(w => !w.IsHidden).ToList();
        if (visibleWords.Count > 0)
        {
            int index = rand.Next(0, visibleWords.Count);
            visibleWords[index].Hide();
        }
    }
}