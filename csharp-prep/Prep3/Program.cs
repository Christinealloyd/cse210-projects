using System;

class Program
{
    static void Main(string[] args)
    {
        using System;

class GuessMyNumber
{
    static void Main()
    {
        // Initialize the random number generator
        Random random = new Random();
        int magicNumber = random.Next(1, 101); // Generate a random number between 1 and 100

        int guess;

        // Loop until the guess matches the magic number
        do
        {
            // Ask the user for a guess
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            // Determine if the guess is too high, too low, or correct
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        } while (guess != magicNumber); // Continue the loop until the guess is correct
    }
}
