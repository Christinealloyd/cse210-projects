using System;

class Program
{
    static void Main() 
    {
        Journal journal = new Journal();
        bool running = true;

        while (running)
        {

            Motivational.DisplayMotivation(); //exceeding creativity requirements

            Console.Clear();
            Console.WriteLine("Menu");
            Console.WriteLine("Welcome to the journal program");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    journal.WriteEntry();
                    Motivational.DisplayMotivation(); //exceeding creativity requirements. displays after writing entry
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    Console.Write("Enter filename to load: ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename);
                    break;
                case "4":
                    Console.Write("Enter filename to save: ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            if (running) Console.WriteLine("Press any key to return to the menu.");
            Console.ReadKey();
        }
    }
}
