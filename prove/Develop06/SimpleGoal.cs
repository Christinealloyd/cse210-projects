public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int pointValue) : base(name, pointValue) { }

    public override void RecordEvent()
    {
        isComplete = true; // A simple goal is complete once recorded
    }

    public override string DisplayGoal()
    {
        return isComplete ? $"[X] {name} (+{pointValue} points)" : $"[ ] {name}";
    }
}