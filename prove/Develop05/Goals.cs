using System;


public class Goals : Base
{
    private string _goalMenu = @"
The types of goals are:
    1. Simple Goal
    2. Eternal Goal
    3. Checklist Goal
Which type of goal would you like to create: ";
    private int _goalPoints = 0;
    protected List<string> _goalsList = new List<string>();

    public string PrintGoalMenu() {
        Console.Clear();
        Console.Write(_goalMenu);
        string response = Console.ReadLine();
        return response;
    }

    protected virtual void CreateSentence() {
        
    }
    
    public void SetGoalList(string goalSentence) {
        _goalsList.Add(goalSentence);
    }
    public void PrintGoalList() {
        int index = 1;
        if (_goalsList.Count() != 0) {
            foreach (string goal in _goalsList) {
                Console.WriteLine($"{index}. {goal}");
            }
    }
    }
}