using System; 

public class Activity{

    protected string _startMessage;

    protected string _activityType;
    protected string _finishMessage;
    private string _getReadyMessage;
    protected string _duration;

    protected string [] _prompts1 = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    protected string [] _prompts2 = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    protected string [] _prompts3 ={
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public void GetStartMessage(){
        Console.WriteLine($"Welcome to the {_activityType}");
        Console.WriteLine();
        Console.WriteLine(_startMessage);
        Console.WriteLine();
        Console.WriteLine("How long in seconds would you like to do this activity?");
        Console.WriteLine();
        _duration = Console.ReadLine();
    }

    public virtual void doActivity(){

    }

    public void GetEndMessage(){
        Console.WriteLine(_finishMessage);
        Console.WriteLine();
        Console.WriteLine($"Thank You for completing {_duration} seconds of {_activityType}");
        Console.WriteLine();
    }

    public void GetReady(){
        Console.WriteLine();
        Console.WriteLine("Get ready: ");
        Console.WriteLine();


        Console.Write("-");
        Thread.Sleep(1000);
        Console.Write("\b \b"); 
        Console.Write("+");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("-");

    }
    public string GetDuration(){

        return _duration;

    }
    public string GetRandPrompt1(){
        int len = _prompts1.Count();
        Random rnd = new Random();
        int num = rnd.Next(0,len);

        return _prompts1 [num];
        
        
      }

    public string GetRandPrompt2(){
        int len = _prompts2.Count();
        Random rnd = new Random();
        int num = rnd.Next(0,len);

        return _prompts2 [num];
    }

    public string GetRandPropmt3(){
        int len = _prompts3.Count();
        Random rnd = new Random();
        int num = rnd.Next(0,len);

        return _prompts3 [num];
    }
}