using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.Write("Scripture Verse: ");
        string reference = Console.ReadLine();
        Scripture s = new Scripture();
        s.SetReference(reference);
        string verseStr = s.GetVerse();

        s.DisplayVerse();

        if (s.GetVerse() != "Key not found") {
            Verse v = new Verse(verseStr);
            Words w = new Words();

            List<string> verseList = v.GetVerseList();
            string quit = "";

            w.SetVerseList(verseList);

            do {
                
                string blankedVerseStr = v.GetBlankedVerseStr(w.GenerateBlankedList());

                s.SetBlankedVerse(blankedVerseStr);

                quit = s.DisplayBlankedVerse();
            }
            while(quit != "quit");
        }

    }
}