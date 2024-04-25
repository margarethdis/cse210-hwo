using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Which is you final grade?: ");
        string grade = Console.ReadLine();
        int calification = int.Parse(grade);

        string letter = "";

        if (calification >= 90)
        {
            letter = "A";
        }
        else if (calification >= 80)
        {
            letter = "B";
        }
        else if (calification >=70)
        {
            letter = "C";
        }
        else  if (calification >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        {
            Console.WriteLine($"your grade is {letter}");
        }

        if (calification >=70)
        {
            Console.WriteLine("Congratulaions! You aproved his course!");
        }
        else
        {
            Console.WriteLine("Seems like you didn't pass this class, but hey, we've all been there. Keep your chin up and keep moving forward.");
        }


        
    }
}