using System;
using System.IO;

// To exceed requirements I included a timestamp at the beginning of the file to take not of
// when the file was last modified. I also modified the code in 'ChecklistGoal' to give a bonus
// everytime a multiple of the timesToComplete goal is reached.

class MainProgram
{
    static void Main(string[] args)
    {
        int totalPoints = 0;
        List<Goal> goalsList = new List<Goal>();
        GoalManager manager = new GoalManager();

        string NameOfGoal()
        {
            Console.Write("What is the name of the goal? ");
            string user = Console.ReadLine();
            
            return user;
        }

        string DescriptionOfGoal() 
        {
            Console.Write("What a short description of it? ");
            string user = Console.ReadLine();

            return user; 
        }

        string GoalPoints()
        {
            Console.Write("What is the amount of points associated with this goal? ");
            string user = Console.ReadLine();

            return user;
        }

        void MainMenu(int totalPoints)
        {
            Console.Write(@$"You have {totalPoints} points

Menu Options:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Quit
Select a choice from the Menu: ");
        }

        void GoalMenu()
        {
            Console.Write(@"The type of Goals are:
    1. Simple Goal
    2. Eternal Goal
    3. Checklist Goal
What kind of goal o you want to create: ");
        }


        MainMenu(totalPoints);
        string mainMenuResponse = Console.ReadLine();

        while(mainMenuResponse != "6") 
        {
            if(mainMenuResponse == "1") {
                GoalMenu();
                string goalMenuResponse = Console.ReadLine();

                if(goalMenuResponse == "1") {
                    string name = NameOfGoal();
                    string description = DescriptionOfGoal();
                    string points = GoalPoints();

                    SimpleGoal simple = new SimpleGoal(name, description, int.Parse(points), false);
                    goalsList.Add(simple);
                }
                if (goalMenuResponse == "2") {
                    string name = NameOfGoal();
                    string description = DescriptionOfGoal();
                    string points = GoalPoints();

                    EternalGoal eternal = new EternalGoal(name, description, int.Parse(points));
                    goalsList.Add(eternal);
                }
                if(goalMenuResponse == "3") {
                    string name = NameOfGoal();
                    string description = DescriptionOfGoal();
                    string points = GoalPoints();

                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    string timesToComplete = Console.ReadLine();

                    Console.Write("What is the bonus for accomplishing it that many number of times? ");
                    string bonusPoints = Console.ReadLine();

                    ChecklistGoal checklist = new ChecklistGoal(name, description, int.Parse(points), int.Parse(timesToComplete), int.Parse(bonusPoints));
                    goalsList.Add(checklist);
                }
            }

            else if(mainMenuResponse == "2") {
                manager.ListGoals(goalsList);
            }

            else if(mainMenuResponse == "3") {
                Console.Write("Which file would you like to save your goals to? ");
                string filename = Console.ReadLine();

                manager.SaveToFile(goalsList, totalPoints, filename);
            }

            else if(mainMenuResponse == "4") {
                Console.Write("Which file would you like to load your goals from? ");
                string filename = Console.ReadLine();

                totalPoints = manager.LoadFromFile(goalsList, filename);
                
            }

            else if(mainMenuResponse == "5") {
                bool check = manager.RecordEventMenu(goalsList);

                if(check) {
                    string recordResponse = Console.ReadLine();

                    totalPoints += manager.RecordEvent(goalsList, recordResponse);
                }
            }

            MainMenu(totalPoints);
            mainMenuResponse = Console.ReadLine();
        }
    }
}