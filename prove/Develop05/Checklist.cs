using System;

public class Checklist : Goals 
{
    private string _goal;
    private string _description;
    private int _numOfTimesCompleted = 0;
    private int _bonusGoal;
    private int _bonusPoints;
    bool _isComplete;


    public string StartChecklistGoals() {
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
        Console.Write("How many times does the goal need to be completed for a bonus? ");
        string strBonusGoal = Console.ReadLine();
        _bonusGoal = int.Parse(strBonusGoal);
        Console.Write("What is the bonus for accomplishing it that many times? ");
        string strBonusPoints = Console.ReadLine();
        _bonusPoints = int.Parse(strBonusPoints);

    }

    protected override string CreateSentence(string goal, string description, bool isComplete) {
        string check = "X";
        string notCheck = "";
        if (isComplete == true) {
            return $"[{check}] {goal} ({description}) -- Currently completed {_numOfTimesCompleted}/{_bonusGoal}";
        }else {
            return $"[{notCheck}] {goal} ({description}) -- Currently completed {_numOfTimesCompleted}/{_bonusGoal}";
        }
    }

    public override string CreateFileStr()
    {
        return $"ChecklistGoal:{_goal}<>{_description}<>{_points}<>{_bonusPoints}<>{_bonusGoal}<>{_numOfTimesCompleted}<>{false}";
    }
    
}