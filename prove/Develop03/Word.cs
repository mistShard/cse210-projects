using System;

public class Words {
    private List<int> _randomIndexList = new List<int>();
    private List<string> _verseList = new List<string>();
    Random rnd = new Random();

    public void SetVerseList(List<string> verseList) {
        _verseList = verseList;
    } 

    public List<string> GenerateBlankedList() {
        
        for(int i = 0; i < _verseList.Count(); i++) {
            _randomIndexList.Add(i);
        }

        //for(int i = 0; i < 3; i++) {
            int rndNum = rnd.Next(_randomIndexList.Count());
            int indexNum = _randomIndexList[rndNum];
            _verseList[indexNum] = "___";
            _randomIndexList.RemoveAt(rndNum);
       // }
        return _verseList;
    }

}
