using System;

public class EternalGoal : Goal
{
    public EternalGoal()
    {

    }

    public EternalGoal(string goalName, string description, int points, bool isComplete = false, string type = "EternalGoal"):
    base (type, goalName, description, points, isComplete)
    {

    }

    public override string PrintList()
    {
        return base.PrintList();
    }

    public override string AddToFileList() 
    {
        return $"{GetGoalType()}:{GetGoalName()} <> {GetDescription()} <> {GetPoints()}";
    }

}