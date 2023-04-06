using System;

public abstract class Goal
{
    private string _type;
    private string _goalName;
    private string _description;
    private int _points;
    private bool _isComplete = false;

    public Goal()
    {

    }

    public Goal(string type, string goalName, string description, int points, bool isComplete)
    {
        _type = type;
        _goalName = goalName;
        _description = description;
        _points = points;
        _isComplete = isComplete;
    }

    public string GetGoalName() {
        return  _goalName;
    }

    protected string GetDescription() {
        return _description;
    }

    public int GetPoints() {
        return _points;
    }

    public string GetGoalType() {
        return _type;
    }

    protected bool isComplete() {
        return _isComplete;
    }

    public void SetIsComplete(bool isComplete) {
        _isComplete = isComplete;
    }

    public virtual string PrintList() {
        string sentence;
        if(isComplete() == true && _type != "EternalGoal") {
            sentence = ($"[X] {_goalName} ({_description})");
        }
        else {
            sentence = ($"[ ] {_goalName} ({_description})");
        }

        return sentence;
    }

    public virtual string AddToFileList() {
        return $"{_type}:{_goalName} <> {_description} <> {_points} <> {_isComplete}";
    }

    public virtual void SetTimesCompleted(int timesCompleted) {
        
    }

    public virtual int GetTimesToComplete() {
        return -1;
    }

    public virtual int GetTimesCompleted() {
        return -1;
    }

    public virtual int GetBonusPoints() {
        return -1;
    }
}