using System;

public class Words {
    private List<int> _randomIndexList = new List<int>();
    private List<string> _verseList = new List<string>();
    Random rnd = new Random();

    private void PopulateRandomIndexList() {
        for(int i = 0; i < _verseList.Count(); i++) {
            _randomIndexList.Add(i);
        }
    }

    public void GenerateIndexes() {
        PopulateRandomIndexList();
    }

    public void SetVerseList(List<string> verseList) {
        _verseList = verseList;
    } 

    public List<string> GenerateBlankedList() {
        int upperBound = 5;
        if (upperBound  > _randomIndexList.Count()) {
            upperBound = _randomIndexList.Count();
        }
            for(int i = 0; i < upperBound; i++) {
            int rndNum = rnd.Next(_randomIndexList.Count());
            int indexNum = _randomIndexList[rndNum];
            _verseList[indexNum] = "___";
            _randomIndexList.RemoveAt(rndNum);
        }

        return _verseList;
    }

    public bool IsEmpty() {
        if (_randomIndexList.Count() == 0) {
            return true;
        }
        else {
            return false;
        }
    }

}
