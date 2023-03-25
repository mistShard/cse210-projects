using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Base b = new Base();
        Goals g = new Goals();
        Simple s = new Simple();
        Eternal e = new Eternal();
        Checklist c = new Checklist();
        List<string> goalsList = new List<string>();
        List<string> goalsToFileList = new List<string>();
        List<string> loadList = new List<string>();
        

        string menuResponse = b.PrintMenu();

        while (menuResponse != "6") {   
            if (menuResponse == "1") {
                string goalMenuResponse = g.PrintGoalMenu();
                    if (goalMenuResponse == "1") {
                        goalsList.Add(s.StartSimpleGoals());
                        goalsToFileList.Add(s.CreateFileStr());
                        
                    }
                    else if (goalMenuResponse == "2") {
                        goalsList.Add(e.StartEternalGoals());
                        goalsToFileList.Add(e.CreateFileStr());
                        
                    }
                    else if (goalMenuResponse == "3") {
                        goalsList.Add(c.StartChecklistGoals());
                        goalsToFileList.Add(c.CreateFileStr());
                        
                    }
            }

            if (menuResponse == "2") {
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

            if (menuResponse == "3") {

                g.SaveToFile(goalsToFileList, goalsList);   
            }

            if (menuResponse == "4") {
                g.LoadFromFile(goalsToFileList, goalsList);
            }
            
            menuResponse = b.PrintMenu();
        }
    }
}