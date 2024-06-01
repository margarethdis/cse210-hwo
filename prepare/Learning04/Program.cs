using System;

class Program
{
    static void Main(string[] args)
    {
       

        Reference reference = new Reference();
        string title = reference.GetBookTitle();
        string chapter = reference.GetChapter();
        string verse = reference.GetVerse();
        Console.WriteLine($"{title} {chapter}:{verse}");


    }
}
