using System;
using System.IO;
using System.Linq;


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
        Console.WriteLine();
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

    public void SaveToFile(List<string> goalsToFileList, List<string>goalsList, List<int> totalPoints) {  
        goalsList.Clear();

        Console.Write("Which file would you like to save your goals to? ");
        string filename = Console.ReadLine(); 
        int totPoints = totalPoints.Sum();

        using (StreamWriter outputFile = new StreamWriter(filename)) 
            {   
                outputFile.WriteLine(totPoints.ToString());
                foreach (string goal in goalsToFileList) {
                    outputFile.WriteLine(goal);
                }
            }
        
        goalsToFileList.Clear();
        
        
    }

    public virtual string CreateFileStr() {
        return "";
    }

    public string LoadFromFile(List<int> totalPoints, List<string> goalsToFileList, List<string> goalsList, bool checkIfLoaded, List<string> loadedFiles) {
        goalsList.Clear();
        goalsToFileList.Clear();
        Console.Write("Which file do you want to load from? ");
        totalPoints.Clear();

        string filename = Console.ReadLine(); 
        string[] lines = File.ReadAllLines(filename);
        string recordedPoints = lines[0];
        totalPoints.Add(int.Parse(recordedPoints));

        lines = lines.Skip(1).ToArray();

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
                if (valueParts[valueParts.Length - 1] == "True") {
                check = "X";
                }
                strGoalList = $"[{check}] {goal} ({description})";

                string bonusPoints = valueParts[3];
                string bonusGoal = valueParts[4];
                string numOfTimesCompleted = valueParts[5];

                goalsList.Add(strGoalList);

                bool truth = false;
                if(bonusGoal == numOfTimesCompleted) {
                    truth = true;
                }
                
                string strGoalToFileList = $"{goalType}:{goal}<>{description}<>{points}<>{bonusPoints}<>{bonusGoal}<>{numOfTimesCompleted}<>{truth}";
                
                if (checkIfLoaded is false) {
                    goalsToFileList.Add(strGoalToFileList);
                }
            }

            else if (goalType == "SimpleGoal") {
                if (valueParts[valueParts.Length - 1] == "True") {
                check = "X";
                }
                strGoalList = $"[{check}] {goal} ({description})";

                string isComplete = valueParts[valueParts.Length - 1];
                goalsList.Add(strGoalList);
                string strGoalToFileList = $"{goalType}:{goal}<>{description}<>{points}<>{isComplete}";
                if (checkIfLoaded is false) {
                    goalsToFileList.Add(strGoalToFileList);
                }
            }

            else if (goalType == "EternalGoal") {
                goalsList.Add(strGoalList);
                string strGoalToFileList = $"{goalType}:{goal}<>{description}<>{points}";
                if (checkIfLoaded is false) {
                    goalsToFileList.Add(strGoalToFileList);
                }
            }
        }
        return filename;
    }

    public void ListGoals(List<string> goalsList) {
        if (goalsList.Count() == 0) {
            Console.WriteLine("\n!!! You do not have any goals recorded !!!");
        }
        else {
            int index = 1;
            Console.WriteLine("These are the goals:");
            foreach (string goal in goalsList) {
                Console.Write("    " + index + ". ");
                Console.WriteLine(goal);
                index++;
            }
        }
    }

    public int RecordGoals(List<string> goalsList, List<string> goalsToFileList ) {
        Console.Write("Which goal's achievement would you like to record? ");
        string strRecord = Console.ReadLine();
        int intRecord = int.Parse(strRecord);
        int index = intRecord - 1;
        string goal = goalsToFileList[index];

        string[] parts = goal.Split(":");

        string goalType = parts[0];
        string goalValues = parts[1];

        string[] valueParts = goalValues.Split("<>");
        
        string points = valueParts[2];
        if (goalType == "ChecklistGoal") {
            string bonusPoints = valueParts[3];
            string bonusGoal = valueParts[4];
            string numOfTimesCompleted = valueParts[5];
            int completed = int.Parse(numOfTimesCompleted) + 1;
            string numCompleted = completed.ToString();

            string newGoal = goal.Replace(numOfTimesCompleted, numCompleted);

            if (bonusGoal == numCompleted) {
                string finishedGoal = newGoal.Replace("False", "True");
                goalsToFileList.Insert(goalsToFileList.IndexOf(goal), finishedGoal);
                goalsToFileList.RemoveAt(goalsToFileList.IndexOf(finishedGoal) + 1);
                Console.WriteLine($"Congratulations you received a bonus of: {bonusPoints} points");
                return int.Parse(points) + int.Parse(bonusPoints);
            }
            else {
                goalsToFileList.Insert(goalsToFileList.IndexOf(goal), newGoal);
                goalsToFileList.RemoveAt(goalsToFileList.IndexOf(newGoal) + 1);
                return int.Parse(points);
            }
            
        }

        else {
            if (goalType == "SimpleGoal") {
                string newGoal = goal.Replace("False", "True");
                goalsToFileList.Insert(goalsToFileList.IndexOf(goal), newGoal);
                goalsToFileList.RemoveAt(goalsToFileList.IndexOf(newGoal) + 1);
            }
            
            return int.Parse(points);
        }
    }
}