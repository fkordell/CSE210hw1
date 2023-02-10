using System;

public class Scripture{
    
    private string _reference;
    private string _text;
    private List<string> _hiddenWords;

    public Scripture(string _reference, string _text){
        this._reference = _reference;
        this._text = _text;
        this._hiddenWords = new List<string>();
    }

    public void DisplayScripture(){
        //Display the text and reference of the scripture
        Console.WriteLine(_reference);
        string[] words = _text.Split(' ');
        foreach( string word in words){

            //Check to see if the word is hidden
            if(_hiddenWords.Contains(word)){
                Console.WriteLine("____");
            }
            else{
                Console.WriteLine(word + " ");
            }
        }
        Console.WriteLine();
    }

    public void HideWord(){
        //Select a random word from the scripture text
        string[] words = _text.Split(' ');
        Random rnd = new Random();
        int index = rnd.Next(words.Length);
        string wordToHide = words[index];

        //Add the word to the list of hidden words
        _hiddenWords.Add(wordToHide);
    }
    public bool AllWordsHidden(){
        //Check if all the words in the scripture text are in the list of hidden words
        string[] words = _text.Split(' ');
        return _hiddenWords.Count == words.Length;

    }
}