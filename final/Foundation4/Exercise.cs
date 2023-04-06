using System;

public abstract class Exercise
{
    private DateTime _date = DateTime.UtcNow;
    private int _timeInMinutes;
    private string _activityType;

    public Exercise(DateTime date, int timeInMinutes, string activityType)
    {
        _date = date;
        _timeInMinutes = timeInMinutes;
        _activityType = activityType;
    }

    public string GetDate() {
        string longDate = _date.ToLongDateString();
        string[] splitLongDate = longDate.Split(", ");
        string year = splitLongDate[2];
        string[] dayMonth = splitLongDate[1].Split(" ");
        string day = dayMonth[1];
        string month = dayMonth[0];
        string firstThree= month[0..3];

        return $"{day} {firstThree} {year}";
    }

    public int GetTimeInMinutes() {
        return _timeInMinutes;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public string GetSummary(string date, double distance, double speed, double pace) {
        return $"{date} {_activityType} ({_timeInMinutes} min)- Distance: {distance} miles, Speed: {speed}mph, Pace: {pace} min per mile ";
    }
}