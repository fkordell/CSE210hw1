using System;

public class Cycling : Activity{


    public Cycling(double activityLength){
    _activityLength = activityLength;
    }

    public override string getSummary(double speed){
        DateTime localDate = DateTime.Now;
        string _currentDate = localDate.ToString("dd/MM/yyyy");
        double distance = (speed / 60) * _activityLength;
        double pace = (_activityLength / distance);

        return ($"{_currentDate} Cycling {_activityLength} min {Math.Round(distance, 1)} miles {Math.Round(speed, 1)} mph {Math.Round(pace, 1)} minute per mile");
    }
}