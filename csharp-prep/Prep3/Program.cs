using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("What is the magic number?: ");
        //string magic = Console.ReadLine();
        //int magicNumber = int.Parse(magic);


      do
      {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(0, 101);
        int intentos = 0;
        string hint= "";
        


        do // ponemos este while abarcando todo nuestro programa porque al cumplirse la con
        //condicion del primer while si el usuario desea continua este do hara que el programa se repita.
        {  
            
            Console.Write("What is your guess?: ");
            string guess = Console.ReadLine();
            int yourGuess = int.Parse(guess);

            intentos++;

            
        if (yourGuess<magicNumber)
        {
            hint= "Higher";
            Console.WriteLine($"{hint}!");
            
        }
        else if (yourGuess>magicNumber)
        {
            hint = "Lower";
            Console.WriteLine($"{hint}!");
        }
        else
        {
            hint = "You guessed it!";
            Console.WriteLine($"{hint}!");

               

        }} while ( hint != "You guessed it!");
        Console.Write("Inform: ");
        Console.WriteLine($"You tried {intentos} times.");
        Console.Write("Do you want to play again? (yes/no): ");
    } while (Console.ReadLine().ToLower() == "yes");

    Console.WriteLine("Thanks for playing! ;)");
    
        
        
    }
}