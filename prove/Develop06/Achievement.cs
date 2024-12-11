public class Achievement
{
    public string Name { get; }
    public string Description { get; }
    public bool IsUnlocked { get; private set; }

    public Achievement(string name, string description)
    {
        Name = name;
        Description = description;
        IsUnlocked = false;
    }

    public void Unlock()
    {
        IsUnlocked = true;
    }

    public string DisplayAchievement()
    {
        return IsUnlocked ? $"[Unlocked] {Name}: {Description}" : $"[Locked] {Name}: {Description}";
    }
}

