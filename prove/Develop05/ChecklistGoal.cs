using System;

public class ChecklistGoal : Goal
{
    private int _timesToComplete;
    private int _timesCompleted = 0;
    private int _bonusPoints;
    public ChecklistGoal()
    {

    }

    public ChecklistGoal(string goalName, string description, int points, int bonusPoints, int timesToComplete,
    int timesCompleted = 0, bool isComplete = false, string type = "ChecklistGoal"):base (type, goalName, description, points, isComplete)
    {
        _timesToComplete = timesToComplete;
        _timesCompleted = timesCompleted;
        _bonusPoints = bonusPoints;
    }

    public override string PrintList()
    {
        string sentence;
        if(_timesCompleted == _timesToComplete) {
            sentence = ($"[X] {GetGoalName()} ({GetDescription()}) -- Currently Completed: {_timesCompleted}/{_timesToComplete}");
        }
        else {
            sentence = ($"[ ] {GetGoalName()} ({GetDescription()}) -- Currently Completed: {_timesCompleted}/{_timesToComplete}");
        }

        return sentence;
    }

    public override string AddToFileList() 
    {
        return $"{GetGoalType()}:{GetGoalName()} <> {GetDescription()} <> {GetPoints()} <> {_bonusPoints} <> {_timesToComplete} <> {_timesCompleted}";
    }

    public override int RecordEvent()
    {
        _timesCompleted += 1;
        
        int points = GetPoints();

        if(_timesCompleted % _timesToComplete == 0) {
            SetIsComplete(true);

            Console.WriteLine($"Congratulations you earned a bonus of {_bonusPoints} points");

            return _bonusPoints + points;

        }

        return points;
    }
}