public class EternalGoal : Goal
{
    public EternalGoal(string name, int pointValue) : base(name, pointValue) { }

    public override void RecordEvent()
    {
        // Each time an eternal goal is recorded, no change in completion state
    }

    public override string DisplayGoal()
    {
        return $"[ ] {name} (+{pointValue} points each time)";
    }
}