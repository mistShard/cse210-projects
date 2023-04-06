using System;

public class SimpleGoal : Goal
{
    public SimpleGoal()
    {

    }

    public SimpleGoal(string goalName, string description, int points, bool isComplete, string type = "SimpleGoal"):
    base (type, goalName, description, points, isComplete)
    {

    }

    public override string PrintList()
    {
        return base.PrintList();
    }

    public override string AddToFileList() 
    {
        return base.AddToFileList();
    }

    public override int RecordEvent()
    {
        SetIsComplete(true);
        int points = GetPoints();

        return points;
    }
}