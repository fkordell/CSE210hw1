using System; 

public class Breathing : Activity{

    public Breathing()
    {

        _startMessage = "This activity will help you by walking you through breathing in and out slowly. CLear your mind and focus on your breathing";
        _activityType = "The breathing activity";
        _finishMessage = "Well Done!";

    }
    public override void doActivity(){
        GetStartMessage();
        GetReady();

        float seconds = Convert.ToInt32(_duration);
        for (int i = 0; i < Math.Ceiling(seconds/8); i++){
            Console.WriteLine("Breathe in ");
            Console.WriteLine();
            Thread.Sleep(4000);
            Console.WriteLine("Breathe Out");
            Console.WriteLine();
            Thread.Sleep(4000);
        }
        GetEndMessage();



    }

}