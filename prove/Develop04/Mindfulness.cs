using System;
using System.Threading;

public class MindfulnessActivity
{
   
    protected string activityName;
  
    protected string description;
  
    protected int duration;

      public MindfulnessActivity(string activityName, string description)
    {
        this.activityName = activityName;
        this.description = description;
    }

    
    public virtual void StartActivity()
    {
        Console.WriteLine($"Starting {activityName}...");
        Console.WriteLine(description);
        SetDuration();
        Console.WriteLine($"Duration: {duration} seconds");
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(3000); 
    }

    
    protected virtual void SetDuration()
    {
        Console.Write("Enter duration (in seconds): ");
        duration = Convert.ToInt32(Console.ReadLine());
    }

    // mensaje de finalización común a todas las actividades
    public virtual void EndActivity()
    {
        Console.WriteLine($"Congratulations! You've completed {activityName}.");
        Console.WriteLine($"Duration: {duration} seconds");
        Thread.Sleep(3000); 
    }
}
