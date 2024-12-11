using System;

public abstract class Goal
{
    protected string name;
    protected int pointValue;
    protected bool isComplete;

    public Goal(string name, int pointValue)
    {
        this.name = name;
        this.pointValue = pointValue;
        this.isComplete = false;
    }

    public abstract void RecordEvent();
    public abstract string DisplayGoal();
    public bool IsComplete => isComplete;
    public int PointValue => pointValue;

    public string Name => name;
}
