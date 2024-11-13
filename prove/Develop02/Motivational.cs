using System;
    // created a new class for exceeding creativity requirements
    public class Motivational
    {
        
        private static string[] messages = new string[]
        {
            "The best way to predict your future is to create it.",
            "Don't stop when you're tired. Stop when you're done.",
            "Your story is not over yet.",
            "Believe in yourself and all that you are.",
            "You are stronger than you think.",
            "Small progress is still progress. Keep going.",
            "The only way to do great work is to love what you do."
        };

       
        public static void DisplayMotivation()
        {
            Random rand = new Random();
            string message = messages[rand.Next(messages.Length)];
            Console.WriteLine("\nMotivational Message: " + message + "\n");
        }
    }
