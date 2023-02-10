using System;

// To exceed requirements I presented the user with a list of available scriptures
// and gave him the option of choosing any scripture based on its umber in the list.

class Program
{
    static void Main(string[] args)
    {   
        Scripture s = new Scripture();
        string reference = s.DisplayMenu();
        s.SetReference(reference);
        string verseStr = s.GetVerse();

        

        if (verseStr != "Key not found") {
            Verse v = new Verse(verseStr);
            Words w = new Words();

            List<string> verseList = v.GetVerseList();
            string quit = s.DisplayVerse();;

            w.SetVerseList(verseList);
            w.GenerateIndexes();

            while(quit != "quit" && w.IsEmpty() == false) {
                string blankedVerseStr = v.GetBlankedVerseStr(w.GenerateBlankedList());

                s.SetBlankedVerse(blankedVerseStr);

                quit = s.DisplayBlankedVerse();
            
            }
        }

    }
}