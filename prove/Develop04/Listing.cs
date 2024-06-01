using System;
using System.Threading;


public class ListingActivity : MindfulnessActivity
{
   
    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by listing as many things as you can in a certain area.") { }

    
    private string[] listingMessages = new string[]
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Spirit this month?",
        "Who are some of your personal heroes?"
    };

    public override void StartActivity()
    {
        base.StartActivity();

        Console.WriteLine("Get ready to start listing...");
        Thread.Sleep(3000); 

        Random random = new Random();
        int totalItems = 0;

        while (totalItems < duration)
        {
            // Selecciona un mensaje aleatorio
            string randomMessage = listingMessages[random.Next(listingMessages.Length)];
            Console.WriteLine(randomMessage);
            
            
            Countdown(5); // La cuenta regresiva

            Console.WriteLine("Start listing items:");
            Thread.Sleep(duration * 1000);

            Console.WriteLine($"You listed {duration} items.");

            totalItems += duration; 
        }

        EndActivity();
    }

    
    private void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"Starting in {i}...");
            Thread.Sleep(1000); 
        }
    }
}
