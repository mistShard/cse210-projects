using System;

public class Mindfulness
{
    private string _menu = @"Menu Options
    1. Start breathing activity
    2. Start reflection activity
    3. Start listing activity
    4. Quit
Select a choice from the menu: ";
    private string _userResponse;
    private string _time;
    protected int _intTime;
    private string _activity;
    private string _activityDescription;

    public Mindfulness()
    {

    }
    public Mindfulness(string activity)
    {
        _activity = activity;
    }

    
    public void SetResponseAndTime(string menuResponse, string time)
    {
        _userResponse = menuResponse;
        _intTime = int.Parse(time);
    }

    protected void PopulateRandomIndexList(List<string> sourceList, List<int> randomList) {
        if (randomList.Count() == 0) {

            for(int i = 0; i < sourceList.Count(); i++) {

                randomList.Add(i);
            }
        }
        
    }

    protected void GenerateRandomPrompt(Random rnd, List<string> sourceList, List<int> randomList, string message = "", bool dashes = true) {
        PopulateRandomIndexList(sourceList, randomList);
        int rndNum = rnd.Next(randomList.Count());
        int indexNum = randomList[rndNum];
        randomList.RemoveAt(rndNum);

        if (message != "") {
            Console.WriteLine(message);
        }

        if(dashes) {
            Console.WriteLine($"\n------{sourceList[indexNum]}------");
        }
        
    }

    protected void DisplayTimer(int moreTime = 0, bool WriteLine = true) {
        for (int i = 5 + moreTime; i > 0; i--) {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            if (i > 9 || i < 0) {
                Console.Write("\b \b \b \b");
            }
        }

        if (WriteLine) {
            Console.WriteLine();
        }
    }

    protected void DisplayDots(int addedSeconds = 0) {
        for (int i = 0; i < 5 + addedSeconds; i++) {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        for(int x = 0; x < 5 + addedSeconds; x++) {
            Console.Write("\b \b");
        }

    }
    public void SetActivity(string userResponse) {
        if(userResponse == "1") {
            _activity = "Breathing";
            _activityDescription = @"This activity will help you relax by walking you through breathing in and out slowly.
Clear your mind and focus on your breathing."; 
        }
        else if (userResponse == "2") {
            _activity = "Reflection";
            _activityDescription = @"This activity will help you reflect on times in your life when you have shown strength and resilience. 
This will help you recognize the power you have and how you can use it in other aspects of your life.";
        }
        else if (userResponse == "3") {
            _activity = "Listing";
            _activityDescription = @$"This activity will help you reflect on the good things in life by having you list as
many things as you can in a certain area.";
        }
    }


    public void DisplayMessage1() {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activity} activity\n");
        Console.WriteLine(_activityDescription);
        Console.WriteLine();
        Console.Write("How long do you want this activity to last in seconds: ");
       
    }

    protected void DisplayEnd() {
        Console.WriteLine("\nWell Done!!");
        DisplayDots();

        Console.WriteLine($"You have completed another {_intTime} seconds of the {_activity} activity.");
        DisplayDots();
    }

    private void StrToInt() {
        _intTime = int.Parse(_time);
    }

    protected int GetTime() {
        return _intTime;
    }

    public string PrintMenu()
    {
        Console.Clear();
        Console.Write(_menu);
        string user = Console.ReadLine();
        return user;
    }
}
