using system; 

public class Breathing : Activity{

    private string _activityDescription;
    private string _timerIn;
    private string _timerOut;

    public Breathing(string startMessage string finishMesage string getReadyMessage string duration string activityDescription string timerIn string timerOut): base(startMessage finishMessage getReadyMessage duration)
    {

        _activityDescription = activityDescription;
        _timerIn = timerIn;
        _timerOut =timerOut;

    }
    public string GetActivityDescription(){

        return _activityDescription;
    }
    public string GetTimerIn(){

        return _timerIn;
    }
    public string GetTimerOut(){

        return _timerOut;
    }

}