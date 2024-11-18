public class Word
{
    public string WordText { get; set; }
    public bool IsHidden { get; set; }
    public string HiddenWord { get; set; }

    // Constructor for word
    public Word(string wordText)
    {
        this.WordText = wordText;
        this.IsHidden = false;
        this.HiddenWord = new string('_', wordText.Length); // Replaces word with underscores
    }

    // Hide the word by setting IsHidden to true
    public void HideWord()
    {
        this.IsHidden = true;
    }
}

