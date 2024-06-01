using System;
using System.Threading;


public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by inhaling and exhaling slowly. Clear your mind and focus on your breath.") { }
    
    // M  ejecutar la actividad de respiración
    public override void StartActivity()
    {
        base.StartActivity();

        // M spinner line

        int breathDuration = 5;
        int totalBreaths = duration / breathDuration; 

        for (int breathCount = 0; breathCount < totalBreaths; breathCount++)
        {
            Console.Write("Inhale");
            CountDown(breathDuration); 

            Console.Write("Exhale");
            CountDown(breathDuration); 
        }

        EndActivity();
    }

    private void CountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(" .");
            Thread.Sleep(1000); 
        }
        Console.WriteLine();
    }

    private void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/\r");
            Thread.Sleep(250); // Espera 0.25 zeg
            Console.Write("-\r");
            Thread.Sleep(250);
            Console.Write("\\\r");
            Thread.Sleep(250); 
            Console.Write("|\r");
            Thread.Sleep(250); 
        }
    }
}
