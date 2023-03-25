using System;
using System.IO;


public class Goals : Base
{
    private string _goalMenu = @"
The types of goals are:
    1. Simple Goal
    2. Eternal Goal
    3. Checklist Goal
Which type of goal would you like to create: ";
    private int _goalPoints = 0;
  

    public string PrintGoalMenu() {
        Console.Clear();
        Console.Write(_goalMenu);
        string response = Console.ReadLine();
        return response;
    }

    protected virtual string CreateSentence(string goal, string description, bool isComplete ) {
        string check = "X";
        string notCheck = "";
        if (isComplete == true) {
            return $"[{check}] {goal} ({description})";
        }else {
            return $"[{notCheck}] {goal} ({description})";
        }
    }
    
    protected virtual void Questions() {

    }

    public void SaveToFile(List<string> goalsToFileList, List<string>goalsList) {  
        goalsList.Clear();

        Console.Write("What is the filename for the goals file? ");
        string filename = Console.ReadLine(); 

        using (StreamWriter outputFile = new StreamWriter(filename)) 
            {   
                foreach (string goal in goalsToFileList) {
                    outputFile.WriteLine(goal);
                }
            }
    }

    public virtual string CreateFileStr() {
        return "";
    }

    public void LoadFromFile(List<string> goalsToFileList, List<string> goalsList) {
        Console.Write("What is the filename for the goals file? ");
        goalsList.Clear();

        string filename = Console.ReadLine(); 
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(":");

            string goalType = parts[0];
            string goalValues = parts[1];

            string[] valueParts = goalValues.Split("<>");
            string check = "";

            string goal = valueParts[0];
            string description = valueParts[1];
            string points = valueParts[2];

            string strGoalList = $"[{check}] {goal} ({description})";

            if (goalType == "ChecklistGoal") {
                string bonusPoints = valueParts[3];
                string bonusGoal = valueParts[4];
                string numOfTimesCompleted = valueParts[5];

                goalsList.Add(strGoalList);
                string strGoalToFileList = $"{goalType}:{goal}<>{description}<>{points}<>{bonusPoints}<>{bonusGoal}<>{numOfTimesCompleted}";
                goalsToFileList.Add(strGoalToFileList);
            }

            else if (goalType == "SimpleGoal") {
                if (valueParts[valueParts.Length - 1] == "True") {
                check = "X";
                }
                strGoalList = $"[{check}] {goal} ({description})";

                string isComplete = valueParts[valueParts.Length - 1];
                goalsList.Add(strGoalList);
                string strGoalToFileList = $"{goalType}:{goal}<>{description}<>{points}<>{isComplete}";
                goalsToFileList.Add(strGoalToFileList);
            }

            else if (goalType == "EternalGoal") {
                goalsList.Add(strGoalList);
                string strGoalToFileList = $"{goalType}:{goal}<>{description}<>{points}";
                goalsToFileList.Add(strGoalToFileList);
            }
        }
    }
}