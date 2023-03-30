using System;

public class Reception : Event
{
    private string _email;

    public Reception(string eventTitle, string description, string date, string time, Address address, 
    string email, string eventType="Reception"):base(eventType, eventTitle, description, date, time, address)
    {
        _email = email;
    }

    public override void PrintFullDetails()
    {
        Console.WriteLine(@$"
-- Full Details --
Event Type: {GetEventType()}
    RSVP: {_email}");
        Console.WriteLine(GetStandardDetails());
    }
}