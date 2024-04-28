using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int userNumber; //definimos la varibale out loop , [ara poder utilizarlo despues
        //si estuvier dentro solo ahi lo podria utilizr]

        //mira el loop ya no necesitas definir la vaiable otra vez     
        do
        {
            Console.Write("Enter a number: ");
            string number = Console.ReadLine();
            userNumber = int.Parse(number);// aqui el programa le asigna el valor de int
            numbers.Add(userNumber);

        }while(userNumber != 0);

        int sum = 0;

        foreach(int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = sum/numbers.Count;
        Console.WriteLine($"The average  is: {average}.");
        
        int maxNumber = numbers.Max();

        Console.WriteLine($"The larger number is :{maxNumber}.");

        




        
        







    }
}