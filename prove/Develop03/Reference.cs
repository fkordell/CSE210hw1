using System;

public class Reference{

    private string _book;
    private string _chapter;
    private string _verse1;
    private string _verse2;

    
    public Reference( string book, string chapter,  string verse){

        _book = book;
        _chapter = chapter;
        _verse1 = verse;
    }
    public Reference(string book, string chapter, string verse, string verse2){
        _book = book;
        _chapter = chapter;
        _verse1 = verse;
        _verse2 = verse2;
    }

    public string GetReference(){
        string text = _verse1;
        return text;
    }
}