using System;
using System.Collections.Generic;


public class Journal
{
    public List<Entry> entries = new List<Entry>();
    public Prompt _prompt = new Prompt();

    public void WriteEntry()
    {
        Console.WriteLine("Write a new entry: ");

        string _promptText = _prompt.GetRandomQuestion();
        Console.WriteLine(_promptText);

        Console.Write("Your answer: ");
        string _entryText = Console.ReadLine();

        Entry _newEntry = new Entry
        {
            _text = _entryText,
            _prompt = _promptText,
            _date = DateTime.Now
        };

        entries.Add(_newEntry);

        Console.WriteLine("Entry saved successfully!");
    }

    public void DisplayEntries()
    {
        Console.WriteLine("Journal Entries: ");
        foreach (var entry in entries)
        {
            Console.WriteLine($"Date: {entry._date}");
            Console.WriteLine($"Prompt: {entry._prompt}");
            Console.WriteLine($"Entry: {entry._text}");
            Console.WriteLine();
        }
    }

    public void LoadEntries(string filename)
    {
        try
        {
            string [] lines = System.IO.File.ReadAllLines(filename);

            foreach(string line in lines)
            {
                string[] parts = line.Split(",");

                string firstName = parts[0];
                string lastName = parts[1];

                Entry entry =  new Entry
                {
                    _date = DateTime.Now,
                    _prompt = $"{firstName},{lastName}",
                    _text = " "
                };

                entries.Add(entry);
            }

            Console.WriteLine($"Entries loaded from {filename}");
        }

        catch (Exception ex)
        {
            Console.WriteLine("Error loading entries: " + ex.Message);
        }
    }

   

    public void SaveEntries(string filename)
    {
        try
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach(var entry in entries)
                {
                    outputFile.WriteLine($"{entry._date},{entry._prompt},{entry. _text}");
                }
            }

            Console.WriteLine($"Entries saved to {filename}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error saving entries: "+ ex.Message);
        }
    }

} 