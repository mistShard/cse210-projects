using System;

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string eventTitle, string description, string date, string time, Address address, string speaker, 
    int capacity, string eventType="Lecture"):base(eventType, eventTitle, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override void PrintFullDetails()
    {
        Console.WriteLine(@$"
-- Full Details --
Event Type: {GetEventType()}
    Speaker: {_speaker}
    Capacity: {_capacity}");
    Console.WriteLine(GetStandardDetails());
    }
}