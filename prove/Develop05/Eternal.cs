using System;

public class Eternal : Goals 
{
    private string _goal;
    private string _description;
    private int _points;
    

    public string StartEternalGoals() {
        Questions();
        return CreateSentence(_goal, _description, isComplete:false);
    }
    protected override void Questions() {
        Console.Write("What is the name of you goal? ");
        string goal = Console.ReadLine();
        _goal = goal;
        Console.Write( "What is a short description of it? ");
        string description = Console.ReadLine();
        _description = description;
        Console.Write("What is the amount of points associated with this goal? ");
        string strPoints = Console.ReadLine();
        _points = int.Parse(strPoints);
    }
    
    public override string CreateFileStr()
    {
        return $"EternalGoal:{_goal}<>{_description}<>{_points}";
    }
}