using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Address lectureVenue = new Address("12 OakRoad", "Oxford", "London", "England");

        Lecture lecture = new Lecture("Overcoming the Nihilist mindset", 
        "This lecture aims to address the issue of the growing nihilism among young people", 
        "06 May 2023", "11AM", lectureVenue, "Benji Nwangele", 5000);
        
        lecture.PrintHeader();
        lecture.PrintStandardDetails();
        lecture.PrintFullDetails();
        lecture.PrintShortDetails();

        Address receptionVenue = new Address("#1 Onyetugo Close", "Uratta", "Imo", "Nigeria");

        Reception reception = new Reception("Chieftaincy celebration",
        "This is to celebrate our illustrious son on the bestowal of a chieftaincy title on him",
        "04 July 2029", "4PM", receptionVenue, "community@villamail.org");

        reception.PrintHeader();
        reception.PrintStandardDetails();
        reception.PrintFullDetails();
        reception.PrintShortDetails();

        Address outdoorVenue = new Address("Rocky mountains", "Salt Lake City", "Utah", "USA");
        string weather = "The weather forecast predicts a sunny day with 1% chance of rainfall";

        Outdoor outdoor = new Outdoor("Mountain Hiking", 
        "Becoming one with nature and getting exercise in the process",
        "14 April 2023", "6AM", outdoorVenue, weather);

        outdoor.PrintHeader();
        outdoor.PrintStandardDetails();
        outdoor.PrintFullDetails();
        outdoor.PrintShortDetails();
        
    }
}