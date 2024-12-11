public class ChecklistGoal : Goal
{
    private int timesCompleted;
    private int requiredTimes;

    public ChecklistGoal(string name, int pointValue, int requiredTimes) : base(name, pointValue)
    {
        this.requiredTimes = requiredTimes;
        this.timesCompleted = 0;
    }

    public override void RecordEvent()
    {
        timesCompleted++;
        if (timesCompleted >= requiredTimes)
        {
            isComplete = true; // Set complete if reached required times
        }
    }

    public override string DisplayGoal()
    {
        return isComplete ? $"[X] {name} (+{pointValue} points) Completed {timesCompleted}/{requiredTimes} times" : $"[ ] {name} (+{pointValue} points) Completed {timesCompleted}/{requiredTimes} times";
    }

    public int GetBonusPoints()
    {
        return isComplete ? 500 : 0; // Bonus is only given when fully completed
    }
}
