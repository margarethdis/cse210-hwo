using System;
using System.Collections.Generic;


public class Prompt
{
    public List<string> _questions = new List<string>();
    public Random _randomPrompt = new Random();


    public Prompt()
    {
        _questions.Add("Did you have any meaningful conversations today? What made that conversation special?");
        _questions.Add("What was your biggest achievement today, no matter how small?");
        _questions.Add("Did anything surprise you today? What was it and why did it surprise you?");
        _questions.Add("How did you feel about yourself today compared to other days?");
        _questions.Add("What did you do today to take care of your emotional, physical, or mental well-being?");

    }

    public string GetRandomQuestion()
    {
        int index = _randomPrompt.Next(_questions.Count);
        return _questions[index];
    }
    

  
}