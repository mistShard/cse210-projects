using System;

public class Outdoor : Event
{
    private string _weather;

    public Outdoor(string eventTitle, string description, string date, string time, Address address, 
    string weather, string eventType="Outdoor"):base(eventType, eventTitle, description, date, time, address)
    {
        _weather = weather;
    }

    public override void PrintFullDetails()
    {
        Console.WriteLine(@$"
-- Full Details --
Event Type: {GetEventType()}
    Weather: {_weather}");
    Console.WriteLine(GetStandardDetails());
    }
}