using System;

public abstract class Activity
{
    private DateTime _date;
    private int _durationMinutes;

    public Activity(DateTime date, int durationMinutes)
    {
        _date = date;
        _durationMinutes = durationMinutes;
    }

    public DateTime Date => _date;
    public int DurationMinutes => _durationMinutes;

    public abstract double GetDistance(); 
    public abstract double GetSpeed();    
    public abstract double GetPace();     

    public virtual string GetSummary()
    {
        return $"{Date.ToShortDateString()} Activity ({DurationMinutes} min): " +
               $"Distance: {GetDistance():0.0}, Speed: {GetSpeed():0.0}, Pace: {GetPace():0.0}";
    }
}
