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

        bool preLoaded = false;
        List<int> totalPoints = new List<int>();

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
                g.ListGoals(goalsList);
            }

            if (menuResponse == "3") {

                g.SaveToFile(goalsToFileList, goalsList, totalPoints);  
                b.SetPoints(0); 
            }

            if (menuResponse == "4") {
                string files= g.LoadFromFile(totalPoints, goalsToFileList, goalsList, preLoaded, loadList);
                b.SetPointsList(totalPoints);
                loadList.Add(files);
        
            }

            if (menuResponse == "5") {
                //g.LoadFromFile(totalPoints, goalsToFileList, goalsList, preLoaded, loadList);
                g.ListGoals(goalsList);
                int earnedPoints = g.RecordGoals(goalsList, goalsToFileList);
                totalPoints.Add(earnedPoints);
                b.SetPointsList(totalPoints);
                g.SaveToFile(goalsToFileList, goalsList, totalPoints);
                b.SetPoints(0);
            }
            
            menuResponse = b.PrintMenu();
        }
    }
}