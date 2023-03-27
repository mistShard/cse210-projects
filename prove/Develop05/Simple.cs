using System;

public class Simple : Goals
{
    private string _goal;
    private string _description;
  
    bool _isComplete = false;

    public string StartSimpleGoals() {
        Questions();
        return CreateSentence(_goal, _description, _isComplete);
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
        return $"SimpleGoal:{_goal}<>{_description}<>{_points}<>{_isComplete}";
    }
}