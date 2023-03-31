using System;

public class Running : Exercise
{
    private double _distance;

    public Running(DateTime date, int timeLength, double distance, string activityType="Running" )
    : base(date, timeLength, activityType)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetTimeInMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetTimeInMinutes() / GetDistance();
    }


}