using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video();
        video1._title = "Keeping white sneakers white";
        video1._author = "Kagan";
        video1._length = 200;

        Comment comment1Video1 = new Comment();
        comment1Video1._name = "Ken";
        comment1Video1._comment = "This was very helpful";

        Comment comment2Video1 = new Comment();
        comment2Video1._name = "Simbi";
        comment2Video1._comment = "I wished you talked more about the effects of bleach";

        Comment comment3Video1 = new Comment();
        comment3Video1._name = "Peace";
        comment3Video1._comment = "Nice job";

        video1._comments.Add(comment1Video1);
        video1._comments.Add(comment2Video1);
        video1._comments.Add(comment3Video1);

        videos.Add(video1);

        Video video2 = new Video();
        video2._title = "Benefits of bathing twice a day";
        video2._author = "Interesting Science";
        video2._length = 360;

        Comment comment1Video2 = new Comment();
        comment1Video2._name = "Kramer";
        comment1Video2._comment = "Why would I want to do that? Its freezing here";

        Comment comment2Video2 = new Comment();
        comment2Video2._name = "Ikem";
        comment2Video2._comment = "Here, we have been doing that since forever";

        Comment comment3Video2 = new Comment();
        comment3Video2._name = "Johnson";
        comment3Video2._comment = "Preach sister!";

        Comment comment4Video2 = new Comment();
        comment4Video2._name = "Santiago";
        comment4Video2._comment = "Buenos!";

        video2._comments.Add(comment1Video2);
        video2._comments.Add(comment2Video2);
        video2._comments.Add(comment3Video2);
        video2._comments.Add(comment4Video2);

        videos.Add(video2);

        Video video3 = new Video();
        video3._title = "Most dangerous animals of the African savannah";
        video3._author = "Geeking Nature";
        video3._length = 860;

        Comment comment1Video3 = new Comment();
        comment1Video3._name = "Dimitri";
        comment1Video3._comment = "Who knew wild dogs could be such efficient killers";

        Comment comment2Video3 = new Comment();
        comment2Video3._name = "Son Lee";
        comment2Video3._comment = "Wow! Would love to see some of those animals in person";

        Comment comment3Video3 = new Comment();
        comment3Video3._name = "Mhlongo";
        comment3Video3._comment = "Africa aint playing";

        video3._comments.Add(comment1Video3);
        video3._comments.Add(comment2Video3);
        video3._comments.Add(comment3Video3);

        videos.Add(video3);

        foreach(Video video in videos) {
            Console.WriteLine(@$"Title: {video._title}
Author: {video._author}
Length: {video._length}
Comment Count: {video.GetNumOfComments()}");
            Console.WriteLine("__ Comments __");
            foreach(Comment comment in video._comments) {
                Console.WriteLine($"{comment._name}: {comment._comment}");
            }
        Console.WriteLine();
        }
    }
}