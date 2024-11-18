using System;

public class Reference
{
    public string ReferenceText { get; set; }
    public bool IsRange { get; set; }
    public string StartVerse { get; set; }
    public string EndVerse { get; set; }

    
    public Reference(string referenceText)
    {
        this.ReferenceText = referenceText;
        this.IsRange = referenceText.Contains("-");
        ParseReference();
    }

   
    public Reference(string startVerse, string endVerse)
    {
        this.StartVerse = startVerse;
        this.EndVerse = endVerse;
        this.IsRange = true;
        this.ReferenceText = $"{startVerse}-{endVerse}";
    }

    
    private void ParseReference()
    {
        if (this.IsRange)
        {
            string[] parts = this.ReferenceText.Split('-');
            this.StartVerse = parts[0];
            this.EndVerse = parts[1];
        }
    }

   
    public string GetFormattedReference()
    {
        return this.ReferenceText;
    }
}