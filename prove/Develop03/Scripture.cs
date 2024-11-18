using System;
using System.Collections.Generic;

public class Scripture
{
    public Reference Reference { get; set; }
    public List<Word> Words { get; set; }
    public bool AllWordsHidden { get; private set; }

    // Constructor for single or range verses
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

    // Constructor for scripture with text and reference
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

    // Displays the full or partially hidden scripture
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

    // Hide random words in the scripture
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

    // Check if all words are hidden
    public bool AreAllWordsHidden()
    {
        return this.AllWordsHidden;
    }
}

    
