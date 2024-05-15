class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();


        Console.WriteLine("Welcome to the Journal program!");

        int choice;
        do
        {
            Console.WriteLine("Please Select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");


            choice = int.Parse(Console.ReadLine());


            if (choice == 1)
            {
                journal.WriteEntry();
            }
            else if (choice == 2)
            {
                journal.DisplayEntries();
            }
            else if (choice == 3)
            {
                Console.WriteLine("Enter the filename to load enties from: ");
                string filename = Console.ReadLine();
                journal.LoadEntries(filename);
            }
            else if (choice == 4)
            {
                Console.WriteLine("Enter the filename to save entries to:");
                string filename = Console.ReadLine();
                journal.SaveEntries(filename);
            }
            else if (choice == 5)
            {
                Console.WriteLine("Exiting...");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
            

        }while (choice != 5);
    }
}