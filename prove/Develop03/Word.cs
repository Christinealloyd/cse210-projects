public class Word
{
    public string WordText { get; set; }
    public bool IsHidden { get; set; }
    public string HiddenWord { get; set; }

    
    public Word(string wordText)
    {
        this.WordText = wordText;
        this.IsHidden = false;
        this.HiddenWord = new string('_', wordText.Length); 
    }

   
    public void HideWord()
    {
        this.IsHidden = true;
    }
}
