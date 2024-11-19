using System;
using System.Collections.Generic;

public class Scripture
{
    public Reference Reference { get; set; }
    public List<Word> Words { get; set; }
    public bool AllWordsHidden { get; private set; }

  
    public Scripture(string reference, List<string> scriptureText)
    {
        this.Reference = new Reference(reference);
        this.Words = new List<Word>();
        foreach (var word in scriptureText)
        {
            this.Words.Add(new Word(word));
        }
        this.AllWordsHidden = false;
    }

    
    public Scripture(string reference, string verseText)
    {
        this.Reference = new Reference(reference);
        this.Words = new List<Word>();
        foreach (var word in verseText.Split(' '))
        {
            this.Words.Add(new Word(word));
        }
        this.AllWordsHidden = false;
    }

    
    public void DisplayScripture()
    {
        Console.Clear();
        Console.WriteLine(this.Reference.GetFormattedReference());
        foreach (var word in this.Words)
        {
            Console.Write(word.IsHidden ? word.HiddenWord : word.WordText);
            Console.Write(" ");
        }
        Console.WriteLine();
    }

    
    public void HideRandomWords()
    {
        Random rand = new Random();
        List<Word> hiddenWords = this.Words.FindAll(w => !w.IsHidden);
        if (hiddenWords.Count > 0)
        {
            int index = rand.Next(hiddenWords.Count);
            hiddenWords[index].HideWord();
        }
        else
        {
            this.AllWordsHidden = true;
        }
    }

    ////for exceeding creativity added Hint feature  to the program that allows users to reveal one word at a time when they get stuck.
    public bool AreAllWordsHidden()
    {
        return this.AllWordsHidden;
    }

    public void RevealRandomHiddenWord()
{
    List<Word> hiddenWords = this.Words.FindAll(w => w.IsHidden);
    if (hiddenWords.Count > 0)
    {
        Random rand = new Random();
        int index = rand.Next(hiddenWords.Count);
        hiddenWords[index].IsHidden = false; 
        Console.WriteLine($"Hint: The word '{hiddenWords[index].WordText}' has been revealed.");
    }
    else
    {
        Console.WriteLine("All words are already revealed!");
    }
}

}

 
    
