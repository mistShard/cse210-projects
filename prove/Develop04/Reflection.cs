using System;

public class Reflection : Mindfulness
{
    private List<string> _initialPromptsList = new List<string>(){
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<int> _randomInitialList = new List<int>();
    private List<string> _followupPromptsList = new List<string>(){
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private List<int> _randomFollowupList = new List<int>();

    private string _message = "Consider the following prompt:";

    private string _message2 = @"Now ponder on each of these messages as they related to this experience.
You may begin in: ";

    private Random _rnd = new Random();
    
    public Reflection(string activity) : base(activity)
    {

    }

    public void StartReflection() {
        Console.WriteLine("\nGet ready...");

        DisplayDots();
        Console.Clear();
        StartExercise(GetTime());

        
        DisplayEnd();
    }

    private void StartExercise(int timeInSec) {
        GenerateRandomPrompt(_rnd, _initialPromptsList, _randomInitialList, _message);
        Console.WriteLine("\nWhen you have something in mind press enter to continue.");
        Console.ReadLine();

        PopulateRandomIndexList(_followupPromptsList, _randomFollowupList);
        Console.Write(_message2);

        DisplayTimer();
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(timeInSec);
        Console.Clear();

        while (DateTime.Now < endTime) {
            if(_randomFollowupList.Count() == 0) {
                PopulateRandomIndexList(_followupPromptsList, _randomFollowupList);
            }
            int rndNum = _rnd.Next(_randomFollowupList.Count());
            int indexNum = _randomFollowupList[rndNum];
            _randomFollowupList.RemoveAt(rndNum);

            Console.Write($"> {_followupPromptsList[indexNum]} ");
            DisplayTimer(10);

        }
        
    }
}