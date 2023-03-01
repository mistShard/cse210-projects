using System;

//          EXCEEDING REQUIREMENTS
// I implemented a way to make sure random suggestions
// are not repeated until all the suggestions have been presented.
// I added an Activity Log displays immendiately the user quits the program.

class Program
{
    static void Main(string[] args)
    {   
        Mindfulness m = new Mindfulness();
        Breathing b = new Breathing("Breathing");
        Reflection r = new Reflection("Reflection");
        Listing l = new Listing("Listing");

        string menuResponse = m.PrintMenu();

        int totalBreathingSessions = 0;
        int totalReflectionSessions = 0;
        int totalListingSessions = 0;
        int totalBreathingTime = 0;
        int totalReflectionTime = 0;
        int totalListingTime = 0;

        while(menuResponse != "4") {
            if (menuResponse == "1" || menuResponse == "2" || menuResponse == "3" || menuResponse == "4") {

                m.SetActivity(menuResponse);
                m.DisplayMessage1();
                string time = Console.ReadLine();

                if(menuResponse == "1") {
                    b.SetResponseAndTime(menuResponse, time);
                    b.StartBreathing();

                    totalBreathingSessions++;
                    totalBreathingTime += int.Parse(time);
                }

                else if(menuResponse == "2") {
                    r.SetResponseAndTime(menuResponse, time);
                    r.StartReflection();

                    totalReflectionSessions++;
                    totalReflectionTime += int.Parse(time);
                }

                else if(menuResponse == "3") {
                    l.SetResponseAndTime(menuResponse, time);
                    l.StartListing();

                    totalListingSessions++;
                    totalListingTime += int.Parse(time);
                }
                menuResponse = m.PrintMenu();
            } else {
                Console.Clear();
                Console.WriteLine("---- Please select an option from the menu ('1', '2', '3', or '4') ----");
                Thread.Sleep(5000);
                menuResponse = m.PrintMenu();
            }
            
        }
        int totalNumOfSessions = totalBreathingSessions + totalReflectionSessions + totalListingSessions;
        int totalTime = totalReflectionTime + totalListingTime + totalBreathingTime;

        Console.Clear();
        Console.WriteLine(@$"----- ACTIVITY LOG -----
Total number of sessions: {totalNumOfSessions}
Total time spent in seconds: {totalTime}");
        Console.WriteLine();
        Console.WriteLine(@$"Total Breathing sessions: {totalBreathingSessions}
Total Breathing activity time: {totalBreathingTime}
Total Reflection sessions: {totalReflectionSessions}
Total Reflection activity time: {totalReflectionTime}
Total Listing sessions: {totalListingSessions}
Total Listing activity time: {totalListingTime}");
    }
}