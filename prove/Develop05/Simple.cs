using System;

public class Simple : Goals
{
    private string _goal;
    private string _description;
    private int _points;
    private string _goalSentence;

    public void StartSimpleGoals() {
        SimpleQuestions();
        CreateSentence();
    }
    private void SimpleQuestions() {
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

    protected override void CreateSentence() {
        string check = "X";
        string notCheck = "";
        _goalSentence = $"[{notCheck}] {_goal} ({_description})";
    }

    public string GetGoalSentence() {
        return _goalSentence;
    }
}