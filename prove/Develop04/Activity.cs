using system; 

public class Activity{

    private string _startMessage;
    private string _finishMessage;
    private string _getReadyMessage;
    private string _duration;


    public Activity(string startMessage string finishMessage string getReadyMessage string duration){

        _startMessage = startMessage;
        _finishMessage = finishMessage;
        _getReadyMessage = getReadyMessage;
        _duration = duration;
    }
    
    public string GetStartMessage(){

        return _startMessage;
    }

    public string GetFinishMessage(){

        return _finishMessage;
    }

    public string GetReady(){

        return _getReadyMessage;
    }
    public string GetDuration(){

        return _duration;

    }


}

