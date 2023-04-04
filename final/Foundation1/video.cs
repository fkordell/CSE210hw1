using System;

public class Video{

    List<Comment> _comments;

    private string _title;

    private string _author;

    private double _vidLength;

    public Video(string title, string author, double vidLength){
        _author = author;
        _title = title;
        _vidLength = vidLength;
        _comments = new List<Comment>();
    }

    public int GetNumComments(){
        return _comments.Count();
    }

    public void Addcomment(string commentName, string commentText ){
        _comments.Add(new Comment(commentName, commentText));
    }
    public void DisplayComments(){
        foreach(Comment comment in _comments)
            Console.WriteLine($"{comment.GetComment()}");
        }
    public void DisplayVideo(){
        Console.WriteLine();
        Console.WriteLine($"Video Title: {_title}, Author: {_author}, Video Length: {_vidLength} minutes, Number of comments: {GetNumComments()} ");
        Console.WriteLine();
        DisplayComments();
        Console.WriteLine();
    }
    
   

}
