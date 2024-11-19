using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<string> scriptureText = new List<string> 
        { 
            "Trust", "in", "the", "Lord", "with", "all", "thine", "heart", 
            "and", "lean", "not", "unto", "thine", "own", "understanding.",
            "In", "all", "thy", "ways", "acknowledge", "him", 
            "and", "he", "shall", "direct", "thy", "paths."
        };

        Program program = new Program("Proverbs 3:5-6", scriptureText);
        program.Start();
    }

    public Program(string reference, List<string> scriptureText)
    {
        this.scripture = new Scripture(reference, scriptureText);
        this.continueProgram = true;
    }
    //for exceeding creativity added Hint feature  to the program that allows users to reveal one word at a time when they get stuck.
    private Scripture scripture;
    private bool continueProgram;

    public void Start()
{
    while (continueProgram && !scripture.AreAllWordsHidden())
    {
        scripture.DisplayScripture();
        Console.WriteLine("\nPress Enter to hide a word, type 'hint' for help, or type 'quit' to exit:");
        string userInput = Console.ReadLine().Trim().ToLower();

        if (userInput == "quit")
        {
            continueProgram = false;
        }
        else if (userInput == "hint")
        {
            scripture.RevealRandomHiddenWord();
        }
        else if (userInput == "")
        {
            scripture.HideRandomWords();
        }
    }

    scripture.DisplayScripture();
    if (!continueProgram)
    {
        Console.WriteLine("You chose to quit.");
    }
    else
    {
        Console.WriteLine("All words are hidden. Program ending.");
    }
}

}