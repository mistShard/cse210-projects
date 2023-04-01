using System;


// To exceed requirements I added a menu to make it easier for the user to navigate through
//  the available activities.
class Program
{
    static void Main(string[] args)
    {
        void Menu() {
            Console.WriteLine(@"
MENU
        1. Lecture
        2. Reception
        3. Outdoor
        4. Quit
        ");
        }

        void Prompt() {
            Console.Write("Which activity's information would you like to view? ");
        }
 
        Console.Clear();
        Console.WriteLine(@"!! WELCOME TO THE ACTIVITY PROGRAM !!");
        Menu();
        Prompt();
        string userResponse = Console.ReadLine();

        while(userResponse != "4")
        {
            if(userResponse == "1") {
                Address lectureVenue = new Address("12 OakRoad", "Oxford", "London", "England");

                Lecture lecture = new Lecture("Overcoming the Nihilist mindset", 
                "This lecture aims to address the issue of the growing nihilism among young people", 
                "06 May 2023", "11AM", lectureVenue, "Benji Nwangele", 5000);
                
                lecture.PrintHeader();
                lecture.PrintStandardDetails();
                lecture.PrintFullDetails();
                lecture.PrintShortDetails();
            }

            else if (userResponse == "2") {
                Address receptionVenue = new Address("#1 Onyetugo Close", "Uratta", "Imo", "Nigeria");

                Reception reception = new Reception("Chieftaincy celebration",
                "This is to celebrate our illustrious son on the bestowal of a chieftaincy title on him",
                "04 July 2029", "4PM", receptionVenue, "community@villamail.org");

                reception.PrintHeader();
                reception.PrintStandardDetails();
                reception.PrintFullDetails();
                reception.PrintShortDetails();
            }

            else if(userResponse == "3") {
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

            else {
                Console.Clear();
                Console.WriteLine("Please make a choice from the Menu by inputting (1, 2 etc)");
                Thread.Sleep(7000);
                Console.Clear();
            }

            Menu();
            Prompt();
            userResponse = Console.ReadLine();
        }      
    }
}