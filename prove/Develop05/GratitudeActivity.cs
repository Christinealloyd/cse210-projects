using System;

namespace MindfulnessApp.Activities
{
    public class GratitudeActivity : ActivityBase
    {
        private static readonly string[] Prompts =
        {
            "Think of someone who made a positive impact on your life. Why are you grateful for them?",
            "What is something about today that you’re grateful for?",
            "What is a place that makes you feel safe or happy?",
            "Recall a challenge you overcame. How has it shaped you?"
        };

        public GratitudeActivity()
        {
            Name = "Gratitude";
            Description = "This activity helps you focus on what you’re thankful for and boosts positivity.";
        }

        public override void Start()
        {
            base.Start();

            Random random = new Random();
            string prompt = Prompts[random.Next(Prompts.Length)];
            Console.WriteLine("\n--- Gratitude Prompt ---");
            Console.WriteLine(prompt);

            PauseWithAnimation(3);

            Console.WriteLine("\nTake a moment to reflect and, if you'd like, write a response:");
            Console.WriteLine("(Press Enter to continue after each response. Type 'done' to finish.)");

            int count = 0;
            while (true)
            {
                Console.Write("Your thought: ");
                string response = Console.ReadLine();
                if (response?.Trim().ToLower() == "done")
                {
                    break;
                }
                if (!string.IsNullOrEmpty(response))
                {
                    count++;
                }
            }

            Console.WriteLine($"\nYou expressed gratitude for {count} things! Well done.");
            End();
        }
    }
}

