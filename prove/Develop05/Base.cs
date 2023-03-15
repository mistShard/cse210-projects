using System;

public class Base {
    private string _menu = @"
Menu Options:
    1. Create a new Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Quit
Select a choice from the menu: ";

    private int _points = 0;

    public void SetPoints(int points) {
        _points += points;
    }

    public string PrintMenu()
    {
        Console.WriteLine();
        Console.WriteLine($"You have {_points} points.");
        Console.Write(_menu);
        string user = Console.ReadLine();
        return user;
    }
}
