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

    public override void SetTimesCompleted(int timesCompleted) {
        _timesCompleted += timesCompleted;
    }

    public override int GetTimesToComplete() {
        return _timesToComplete;
    }

    public override int GetTimesCompleted() {
        return _timesCompleted;
    }

    public override int GetBonusPoints()
    {
        return _bonusPoints;
    }

    public override string PrintList()
    {
        string sentence;
        if(_timesCompleted == _timesToComplete) {
            sentence = ($"[X] {GetGoalType()} ({GetDescription()}) -- Currently Completed: {_timesCompleted}/{_timesToComplete}");
        }
        else {
            sentence = ($"[ ] {GetGoalType()} ({GetDescription()}) -- Currently Completed: {_timesCompleted}/{_timesToComplete}");
        }

        return sentence;
    }

    public override string AddToFileList() 
    {
        return $"{GetGoalType()}:{GetGoalName()} <> {GetDescription()} <> {GetPoints()} <> {_bonusPoints} <> {_timesToComplete} <> {_timesCompleted}";
    }

}