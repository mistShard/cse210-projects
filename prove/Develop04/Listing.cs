using System;

public class Listing : Mindfulness
{
    private string _message = "List as many responses as you can to the following prompt.";
    private List<string> _promptList = new List<string>(){
        "When have you felt the Holy Ghost today?",
        "What are some things you liked about today?",
        "How did you try today to share the Saviour's love?",
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private List<int> _randomList = new List<int>();

    private Random _rnd = new Random();
    public Listing(string activity) : base(activity)
    {

    }
    
    public void StartListing() {
    Console.WriteLine("\nGet ready...");

        DisplayDots();
        Console.Clear();
        StartExercise(GetTime());

        DisplayEnd();
    }

    private void StartExercise(int timeInSec) {
        GenerateRandomPrompt(_rnd, _promptList, _randomList, _message);
        Console.Write("You may begin in: "); DisplayTimer();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(timeInSec);

        int count = 0;
        while (DateTime.Now < endTime) {

            Console.Write("> ");
            string response = Console.ReadLine();
            if (response != "") {
                count++;
            }
        }

        Console.WriteLine($"\nCongratulations! You listed {count} sentences");
        
    }

}