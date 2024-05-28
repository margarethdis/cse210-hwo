class Word
{
    private string Text { get; set; }
    public bool IsHidden { get; private set; }

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }

    public void Print()
    {
        if (IsHidden)
        {
            Console.Write("_".PadRight(Text.Length) + " ");
        }
        else
        {
            Console.Write(Text + " ");
        }
    }

    public void Hide()
    {
        IsHidden = true;
    }
}