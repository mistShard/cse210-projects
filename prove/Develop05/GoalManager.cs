using System;
using System.IO;
using System.Linq;

public class GoalManager
{
    public bool RecordEventMenu(List<Goal> goalsList) {
        Console.WriteLine("The goals are:");
        
        int index = 1;

        if(goalsList.Count() > 0) {

            foreach(Goal goal in goalsList) {
                Console.WriteLine($"    {index}. {goal.GetGoalName()}");
                index++;
            }

            Console.Write("Which goal did you accomplish? ");
            return true;
        }
        else {
            Console.WriteLine(@"
-- You do not have any events available to record --");
            return false;
        }
    }

    public void ListGoals(List<Goal> goalsList) {
        if(goalsList.Count > 0) {
            Console.WriteLine("The goals are");
            
            int index = 1;

            foreach(Goal goal in goalsList) {
                Console.WriteLine($"{index}. {goal.PrintList()}");
                index++;
            }
        }
        else {
            Console.WriteLine(@"
-- You do not have any goals added or loaded to the list --");
        }
    }

    public void SaveToFile(List<Goal> goalsList, int totalPoints, string filename) { 

        DateTime date = DateTime.Now;

        using (StreamWriter outputFile = new StreamWriter(filename)) 
            {   
                outputFile.WriteLine($"Last modified: {date}");
                outputFile.WriteLine(totalPoints.ToString());

                foreach (Goal goal in goalsList) {
                    outputFile.WriteLine(goal.AddToFileList());
                }
            }
        
        goalsList.Clear();
    }

    public int LoadFromFile(List<Goal> goalsList, string filename) {

        goalsList.Clear();

        string[] lines = File.ReadAllLines(filename);

        string strTotalPoints = lines[1];
        int intTotalPoints = int.Parse(strTotalPoints);

        lines = lines.Skip(2).ToArray();

        foreach (string line in lines)
        {
            bool isComplete = false;

            string[] parts = line.Split(":");

            string goalType = parts[0];
            string goalValues = parts[1];

            string[] valueParts = goalValues.Split(" <> ");

            string goalName = valueParts[0];
            string description = valueParts[1];
            string strPoints = valueParts[2];
            int intPoints = int.Parse(strPoints);

            if(goalType == "SimpleGoal") {
                string checkIfCompleted = valueParts[3];

                if(checkIfCompleted == "True") {
                    isComplete = true;
                }

                SimpleGoal goal = new SimpleGoal(goalName, description, intPoints, isComplete);
                goalsList.Add(goal);
            }

            else if(goalType == "EternalGoal") {
                EternalGoal goal = new EternalGoal(goalName, description, intPoints, isComplete);
                goalsList.Add(goal);
            }

            else if(goalType == "ChecklistGoal") {

                string strBonusPoints = valueParts[3]; int intBonusPoints = int.Parse(strBonusPoints);
                string strTimesToComplete = valueParts[4]; int intTimesToComplete = int.Parse(strTimesToComplete);
                string strTimesCompleted = valueParts[5]; int intTimesCompleted = int.Parse(strTimesCompleted);

                if(intTimesCompleted >= intTimesToComplete) {
                    isComplete = true;
                }

                ChecklistGoal goal = new ChecklistGoal(goalName, description, intPoints, intBonusPoints, intTimesToComplete, intTimesCompleted, isComplete);
                goalsList.Add(goal);
            }
        }
        return intTotalPoints;
    }
}