using System;
using System.IO;

public class Journal
{
  public List<Entry> _entries = new List<Entry>();
  public void Display(){
    Console.WriteLine("Displaying the journal");
    foreach (Entry entry in _entries){
      Console.WriteLine(entry._prompt);
      Console.WriteLine(entry._text);
      Console.WriteLine(entry._date);
    }
  }

  public void Save(string fileName){
    using (StreamWriter outputFile = new StreamWriter(fileName))
    {
      foreach (Entry entry in _entries){
      outputFile.WriteLine(entry.ToString());
      }
      
    }
  }
  public void Load(string fileName)
  {
    _entries = new List<Entry>();

  string[] lines = System.IO.File.ReadAllLines(fileName);
  string file = String.Join("\n", lines);
  string [] entries = file.Split("\n\n");
  foreach (string entry in entries)
  {
    if (entry =="")
    {
      break;
    }
      string[] parts = entry.Split("\n");

      string prompt = parts[0];
      string text = parts[1];
      string date = parts[2];
      Entry E = new Entry();
                E._date = date;
                E._prompt = prompt;
                E._text = text;
      _entries.Add(E);
  }
  }
    
}














