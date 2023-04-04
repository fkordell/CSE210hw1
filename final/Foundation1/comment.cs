using System;

public class Comment{

    private string _commentText;

    private string _commentName;


    public Comment(string commentName, string commentText){
        _commentName = commentName;
        _commentText = commentText;
    }

    public string GetComment(){
        return $"Name: {_commentName}, Comment: {_commentText}";
    }
}