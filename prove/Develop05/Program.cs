using System;

class Program
{
    static void Main(string[] args)
    {
        // Crear una instancia del programa Eternal Quest
        EternalQuestProgram program = new EternalQuestProgram();

        // Mostrar los puntos iniciales al iniciar el programa
        Console.WriteLine("Welcome to Eternal Quest Program!");
        program.ShowTotalPoints();

        // Variable para controlar si el programa sigue en ejecución
        bool isRunning = true;

        // Bucle principal del programa
        while (isRunning)
        {
            // Mostrar el menú de opciones
            Console.WriteLine("\nMenu options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            // Solicitar al usuario que ingrese una opción del menú
            Console.Write("Enter your choice: ");
            string input = Console.ReadLine();

            // Procesar la opción seleccionada por el usuario
            switch (input)
            {
                case "1":
                    // Crear un nuevo objetivo
                    Console.WriteLine("Enter the name of the new goal: ");
                    string goalName = Console.ReadLine();
                    Console.WriteLine("Enter the points for the new goal: ");
                    int points = int.Parse(Console.ReadLine());
                    program.CreateSimpleGoal(goalName, points);
                    break;
                case "2":
                    // Listar los objetivos y mostrar la puntuación total
                    Console.WriteLine("List of Goals:");
                    program.ShowGoals();
                    Console.WriteLine($"Total Score: {program.GetTotalScore()} points");
                    break;
                case "3":
                    // Guardar los objetivos en un archivo
                    Console.WriteLine("Enter the file name to save goals: ");
                    string saveFileName = Console.ReadLine();
                    program.SaveGoals(saveFileName);
                    break;
                case "4":
                    // Cargar los objetivos desde un archivo
                    Console.WriteLine("Enter the file name to load goals: ");
                    string loadFileName = Console.ReadLine();
                    program.LoadGoals(loadFileName);
                    break;
                case "5":
                    // Registrar un evento relacionado con un objetivo
                    Console.WriteLine("Enter the name of the goal to record event: ");
                    string eventName = Console.ReadLine();
                    program.RecordEvent(eventName);
                    break;
                case "6":
                    // Salir del programa
                    isRunning = false;
                    break;
                default:
                    // Mensaje de error para opciones inválidas
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
                    break;
            }
        }

        // Mensaje de despedida al salir del programa
        Console.WriteLine("Thank you for using Eternal Quest Program!");
    }
}
