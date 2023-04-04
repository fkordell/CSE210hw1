using System;

public class Running : Activity{

    public Running(double activityLength){
        _activityLength = activityLength;
    }
    public override string getSummary(double distance){
        DateTime localDate = DateTime.Now;
        string _currentDate = localDate.ToString("dd/MM/yyyy");
        double speed = (distance / _activityLength) * 60;
        double pace = (_activityLength / distance);

        return ($"{_currentDate} Running {(_activityLength)} min, {Math.Round(distance, 1)} miles, {Math.Round(speed, 1)} mph, {Math.Round(pace, 1)} minute per mile");
    }
}
