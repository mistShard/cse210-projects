using System;

public class Event
{
    private string _eventType;
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    private string _standardDetails;

    public Event(string eventType, string eventTitle, string description, string date, string time, Address address) 
    {   
        _eventType = eventType;
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetEventType() {
        return _eventType;
    }

    public void PrintHeader() {
        Console.WriteLine($"\n----- {_eventType.ToUpper()} -----");
    }
    public void PrintStandardDetails() {
        _standardDetails = (@$"Event Title: {_eventTitle}
    Description: {_description}
    Date: {_date}
    Time: {_time}
    Venue: {_address.GetAddress()}");

    Console.WriteLine($"\n-- Standard Details --");
    Console.WriteLine(_standardDetails);
    }

    public string GetStandardDetails() {
        return _standardDetails;
    }

    public virtual void PrintFullDetails() {
        Console.WriteLine("");
    }

    public void PrintShortDetails() {
        Console.WriteLine(@$"
-- Short Details --
Event Type: {_eventType}
    Title: {_eventTitle}
    Date: {_date}");
    }
}