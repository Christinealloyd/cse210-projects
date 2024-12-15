using System;

public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int durationMinutes, double distance)
        : base(date, durationMinutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / DurationMinutes) * 60;
    }

    public override double GetPace()
    {
        return DurationMinutes / _distance;
    }

    public override string GetSummary()
    {
        return $"{Date.ToShortDateString()} Running ({DurationMinutes} min): " +
               $"Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}

