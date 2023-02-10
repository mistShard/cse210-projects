using System;

public class Verse {
    private string _verse;
    
    public Verse(string verse) {
        _verse = verse;
    }

    public List<string> GetVerseList() {
        List<string> VerseList = _verse.Split(" ").ToList();
        return VerseList;
    }

    public string GetBlankedVerseStr(List<string> verseList) {
        string blankedVerse = String.Join(" ", verseList);

        return blankedVerse;
    }
}
     