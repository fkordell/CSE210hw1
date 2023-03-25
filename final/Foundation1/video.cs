using System;

public class video{

    List<comment> _comments;

    public string _title;

    public string _author;

    public double _vidLength;

    public video(string title, string author, double vidLength){
        _author = author;
        _title = title;
        _vidLength = vidLength;
    }

    public int GetComment(){
        return _comments.Count();
    }

    public string Addcomment(){
        _comments.Add();
    }

}
