using System;

public class Reflecting : Activity{

Activity activity = new Activity();
public Reflecting(){

    _startMessage = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    _activityType = "Reflecting Activity";
    _finishMessage = "Well Done";

}

public override void doActivity(){
    GetStartMessage();
    GetReady();

    Console.WriteLine("Think about the following question for a few seconds");
    Console.WriteLine();
    string prompt = activity.GetRandPrompt1();
    Console.WriteLine(prompt);
    Console.WriteLine();
    Thread.Sleep(8000);

     float seconds = Convert.ToInt32(_duration);
     Console.WriteLine("Now think about these follow up questions");
     Console.WriteLine();
        for (int i = 0; i < Math.Ceiling(seconds/8); i++){
            string prompt1 = activity.GetRandPrompt2();
            Console.WriteLine(prompt1);
            Thread.Sleep(8000);
            Console.WriteLine();
        }

    GetEndMessage();
}
    
}