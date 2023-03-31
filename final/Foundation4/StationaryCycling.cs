using System;

public class StationaryCycling : Exercise
{
    private double _speed;

    public StationaryCycling(DateTime date, int timeLength, double speed, string activityType="Stationary Cycling") 
    : base(date, timeLength, activityType)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return GetSpeed() * GetTimeInMinutes();
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}