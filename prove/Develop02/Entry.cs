using System;

public class Entry
{
    public string _prompt;
    public string _text;
    public string _date;
    public void Display()
    {
        
    }
    override public string ToString(){
        return _prompt + "\n" + _text + "\n" + _date + "\n\n";
    }
}