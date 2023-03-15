using System;

class Program
{
    static void Main(string[] args)
    {
        Base b = new Base();
        Goals g = new Goals();
        Simple s = new Simple();
        string menuResponse = b.PrintMenu();

        while (menuResponse != "6") {   
            if (menuResponse == "1") {
                string goalMenuResponse = g.PrintGoalMenu();
                    if (goalMenuResponse == "1") {
                        s.StartSimpleGoals();
                        g.SetGoalList(s.GetGoalSentence());
                    }
            }

            if (menuResponse == "2") {
                s.PrintGoalList();
            }
            
            menuResponse = b.PrintMenu();
        }
    }
}