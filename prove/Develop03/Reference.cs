using System;

public class Reference
{
    public string ReferenceText { get; set; }
    public bool IsRange { get; set; }
    public string StartVerse { get; set; }
    public string EndVerse { get; set; }

    // Constructor for single reference
    public Reference(string referenceText)
    {
        this.ReferenceText = referenceText;
        this.IsRange = referenceText.Contains("-");
        ParseReference();
    }

    // Constructor for range of verses
    public Reference(string startVerse, string endVerse)
    {
        this.StartVerse = startVerse;
        this.EndVerse = endVerse;
        this.IsRange = true;
        this.ReferenceText = $"{startVerse}-{endVerse}";
    }

    // Parse reference to extract start and end verses
    private void ParseReference()
    {
        if (this.IsRange)
        {
            string[] parts = this.ReferenceText.Split('-');
            this.StartVerse = parts[0];
            this.EndVerse = parts[1];
        }
    }

    // Returns formatted reference
    public string GetFormattedReference()
    {
        return this.ReferenceText;
    }
}
