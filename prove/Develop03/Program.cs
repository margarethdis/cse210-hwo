using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>()
        {
            new Scripture("2 Nephi", 2, 25, "Adam fell that men might be; and men are, that they might have joy."),
            new Scripture("Ether", 12, 27, "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them."),
            new Scripture("Moroni", 10, 32, "Yea, come unto Christ, and be perfected in him, and deny yourselves of all ungodliness; and if ye shall deny yourselves of all ungodliness, and love God with all your might, mind and strength, then is his grace sufficient for you, that by his grace ye may be perfect in Christ; and if by the grace of God ye are perfect in Christ, ye can in nowise deny the power of God.")
        };

        Random rand = new Random();

        // Choose a random scripture
        Scripture scriptureToShow = scriptures[rand.Next(scriptures.Count)];
        Console.WriteLine("Press Enter to reveal the scripture or type 'exit' to quit.");
        Console.WriteLine();

        // Show the reference
        Console.WriteLine($"Reference: {scriptureToShow.Reference}");

        // Show the scripture with hidden words
        scriptureToShow.PrintWithHiddenWords();

        // Wait for user input
        string input = Console.ReadLine();

        // Hide words until all are hidden or user types 'exit'
        while (!scriptureToShow.AllWordsHidden && input.ToLower() != "exit")
        {
            Console.Clear();
            scriptureToShow.PrintWithHiddenWords();
            input = Console.ReadLine();
        }

        // If all words are hidden, exit the program
        if (scriptureToShow.AllWordsHidden)
        {
            Console.WriteLine("All words in the scripture have been hidden. Program will exit now.");
            Environment.Exit(0);
        }
    }
}
