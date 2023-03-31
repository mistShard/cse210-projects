using System;

public class Swimming : Exercise
{
    private double _laps;

    public Swimming(DateTime date, int timeLength, double laps, string activityType="Swimming") 
    : base(date, timeLength, activityType)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetTimeInMinutes()) * 60;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}