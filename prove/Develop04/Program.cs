using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
           
            ShowSpinner(3); 

            
            ShowMenu();
        }
    }

    static void ShowMenu()
    {
        Console.WriteLine("Mindfulness Program");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Exit");

        int choice = ReadChoice();

        
        switch (choice)
        {
            case 1:
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.StartActivity();
                break;
            case 2:
                ReflectionActivity reflectionActivity = new ReflectionActivity();
                reflectionActivity.StartActivity();
                break;
            case 3:
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.StartActivity();
                break;
            case 4:
                Environment.Exit(0); 
                break;
            default:
                Console.WriteLine("Invalid choice. Please select a valid activity.");
                break;
        }
    }

    static int ReadChoice()
    {
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
        }
        return choice;
    }

    static void ShowSpinner(int seconds)
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
