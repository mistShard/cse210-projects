using System;

public class Scripture {
    private string _key;
    private string _blankedVerse;
    private string _finalVerse;
     private string _passage;
    private Dictionary<string, string> scriptures = new Dictionary<string, string>(){
        {"Isaiah 2:2-3", @"So do not fear, for I am with you; do not be dismayed, for I am your God. 
I will strengthen you and help you; I will uphold you with my righteous right hand."},
        {"Hebrews 4:15", @"For we have not an high priest which cannot be touched with the feeling of our infirmities; 
but was in all points tempted like as we are, yet without sin"},
        {"D&C 62:1", @"Behold, and hearken, O ye elders of my church, saith the Lord your God, even Jesus Christ, your 
advocate, who knoweth the weakness of man and how to succor them who are tempted."}
    };

    public Scripture() {
        _key = "Isaiah 2:2-3";
    }
   
    public void SetReference(string Reference) {
        _key = Reference;
   }

   public void SetBlankedVerse(string blankedVerse) {
        _blankedVerse = blankedVerse;
   }

    public string GetVerse() {
        try {
        int _num = int.Parse(_key);
        if(_num > scriptures.Count() || _num <= 0) {
            Console.WriteLine("\nIndexError: Please input a valid index number");
            return "Key not found";
        }
        else {Console.WriteLine(_num); Console.WriteLine("This number is available: ");
                      
            _finalVerse = scriptures.ElementAt(_num - 1).Value;
            _passage = scriptures.ElementAt(_num - 1).Key;
            return _finalVerse;
        }
        }
        catch  {
            Console.WriteLine("\nTypeError: Please input an integer");
            return "Key not found";
        }
    }

    public string DisplayMenu() {
        string menu = CreateMenu();
        return menu;
    }

    public string DisplayVerse() {

        string response = Print(_finalVerse);
        return response;

    }

    public string DisplayBlankedVerse() {
        
        string response = Print(_blankedVerse);
        return response;
    }

    private string Print(string verse) {
        Console.Clear();
        Console.WriteLine($"{_passage}  {verse}");
        Console.WriteLine("\nPress enter to continue or type 'quit' to finish: ");
        string quit = Console.ReadLine();
        return quit;
    }

    private string CreateMenu() {
        Console.WriteLine("\nScriptures Available for Memorization:");
        int index = 1;
        foreach(KeyValuePair<string, string> entry in scriptures) {
            
            Console.WriteLine($"{index}. {entry.Key}");
            index++;
        }

        Console.Write("\nSelect Scripture Index: ");

        string response = Console.ReadLine();

        return response;
    }

}
