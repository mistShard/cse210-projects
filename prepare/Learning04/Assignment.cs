using System;


public class Assignment
{
    private string _name;
    private string _topic;

    public Assignment()
    {

    }
    public Assignment(string name, string topic)
    {
        _name = name;
        _topic = topic;
    }

    public string GetStudentName() 
    {
        return _name;
    }

    public string GetSummary() {
        return $"{_name}: {_topic}";
    }
}