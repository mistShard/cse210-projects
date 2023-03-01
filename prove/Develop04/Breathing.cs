using System;

public class Breathing : Mindfulness
{
    
    public Breathing() {

    }
    public Breathing(string activity) : base(activity)
    {

    }

    public void StartBreathing() {
        Console.Clear();
        Console.WriteLine("\nGet ready...");

        DisplayDots();
        StartExercise(GetTime());

        DisplayEnd();
    }

    private void StartExercise(int timeInSec) {
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(timeInSec);
        
        int loop = 1;
        while (DateTime.Now < endTime) {
            if(loop % 2 == 0) {
                Console.WriteLine();
                Console.Write("Now breathe out...");
            }
            else{
                Console.WriteLine();
                Console.Write("\nBreathe in...");
            }
            
            DisplayTimer(WriteLine:false);
            loop++;

        }

        Console.WriteLine();
        
    }

}