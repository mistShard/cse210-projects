using System;

public class Scripture {
    private string _key;
    private string _blankedVerse;
    private Dictionary<string, string> scriptures = new Dictionary<string, string>(){
        {"Isaiah 2:2-3", @"So do not fear, for I am with you; do not be dismayed, for I am your God. I will strengthen you and help you; I will uphold you with my righteous right hand."}
    };
    private string _finalVerse;

    public Scripture() {
        _key = "Isaiah 2:2-3";
        //scriptures.Add(_key, @"So do not fear, for I am with you; do not be dismayed, for I am your God. I will strengthen you and help you; I will uphold you with my righteous right hand.");
    }
   
    public void SetReference(string Reference) {
        _key = Reference;
   }

   public void SetBlankedVerse(string blankedVerse) {
        _blankedVerse = blankedVerse;
   }

    public string GetVerse() {
        if (scriptures.ContainsKey(_key)) {
            _finalVerse = scriptures[_key];
            return _finalVerse;
        }
        else {
            return "Key not found";
        }
    }

    public void DisplayVerse() {
        Console.WriteLine(_finalVerse);
    }

    public string DisplayBlankedVerse() {
        Console.WriteLine(_blankedVerse);
        string quit = Console.ReadLine();
        return quit;
    }

}
