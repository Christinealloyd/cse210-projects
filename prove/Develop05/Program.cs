using MindfulnessApp.Activities;

class Program
{
    static void Main(string[] args)
    {
            while (true)
        {
            Console.WriteLine("\nMindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Gratitude Activity");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            ActivityBase activity = choice switch
            {
                "1" => new BreathingActivity(),
                "2" => new ReflectionActivity(),
                "3" => new ListingActivity(),
                "4" => new GratitudeActivity(),
                "5" => null,
                _ => throw new InvalidOperationException("Invalid choice")
            };

            if (activity == null)
            {
                Console.WriteLine("Exiting the program. Stay mindful!");
                break;
            }

            Console.Write("Enter the duration (seconds): ");
            if (int.TryParse(Console.ReadLine(), out int duration))
            {
                activity.Duration = duration;
                activity.Start();
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }
        }

    }
}



