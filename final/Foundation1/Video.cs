using System;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();

    public int GetNumOfComments() {
        return _comments.Count();
    }
}