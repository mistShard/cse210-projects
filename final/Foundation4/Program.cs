using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        List<Exercise> exercises = new List<Exercise>();

        DateTime runningDate = new DateTime(2023,11,3);
        Running running = new Running(runningDate, 30, 3);
        exercises.Add(running);

        DateTime cyclingDate = new DateTime(2023, 08, 11);
        StationaryCycling cycling = new StationaryCycling(cyclingDate, 20, 40);
        exercises.Add(cycling);

        DateTime swimmingDate = new DateTime(2023,05,28);
        Swimming swimming = new Swimming(swimmingDate, 15, 4);
        exercises.Add(swimming);

        foreach(Exercise exercise in exercises) {
            double distance = exercise.GetDistance();
            double speed = exercise.GetSpeed();
            double pace = exercise.GetPace();
            string strDate = exercise.GetDate();
            int time = exercise.GetTimeInMinutes();

            string summary = exercise.GetSummary(strDate, distance, speed, pace);
            Console.WriteLine(summary);
        }
        
    }
}