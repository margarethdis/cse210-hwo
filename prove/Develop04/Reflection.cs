using System;
using System.Threading;


public class ReflectionActivity : MindfulnessActivity
{
    
    private string[] reflectionMessages = new string[]
    {
        "Think of a moment when you defended someone.",
        "Think of a moment when you did something really difficult.",
        "Think of a moment when you helped someone in need.",
        "Think of a moment when you did something truly selfless."
    };

   
    private string[] reflectionQuestions = new string[]
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

   
    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on moments in your life where you have demonstrated strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.") { }

   
    public override void StartActivity()
    {
        base.StartActivity();

        Console.WriteLine("Get ready to start reflecting...");
        Thread.Sleep(3000);

        Random random = new Random();
        int totalSeconds = 0;

        while (totalSeconds < duration)
        {
            
            string randomMessage = reflectionMessages[random.Next(reflectionMessages.Length)];
            Console.WriteLine(randomMessage);

            
            Console.WriteLine("Press Enter when you have something in mind...");
            Console.ReadLine();

           
            string randomQuestion = reflectionQuestions[random.Next(reflectionQuestions.Length)];
            Console.WriteLine(randomQuestion);

            //pausa ,muestra una rueda giratoria
            ShowSpinner(5); 
            totalSeconds += 5; 
        }

        EndActivity();
    }


    private void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/\r");
            Thread.Sleep(250); 
            Console.Write("-\r");
            Thread.Sleep(250); 
            Console.Write("\\\r");
            Thread.Sleep(250); 
            Console.Write("|\r");
            Thread.Sleep(250); 
        }
    }
}
