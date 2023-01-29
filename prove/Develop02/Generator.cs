using System;

public class Generator
{

    public string [] prompts = {
        "How was your day?",
        "What was the best part of your day?",
        "Who did you talk to today?",
        "What was the worst part of your day?",
        "Did you eat something new?",
        "What do you feel you did best today?",
        "What do you feel you did the worst today?"
    };
    string readText = File.ReadAllText("saveEntries.txt");
    
    public string RandPrompt(){
        int len = prompts.Count();
        Random rnd = new Random();
        int num = rnd.Next(0,len);
        
        
        return prompts[num];
    }
}