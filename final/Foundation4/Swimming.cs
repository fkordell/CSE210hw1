using System;

public class Swimming : Activity{


        public Swimming(double activityLength){
        _activityLength = activityLength;
    }

        public override string getSummary(double numOfLAps){
        DateTime localDate = DateTime.Now;
        string _currentDate = localDate.ToString("dd/MM/yyyy");
        double distance = numOfLAps * 50 / 1000 * 0.62;
        double speed = (distance / _activityLength) * 60;
        double pace = (_activityLength / distance);

        return ($"{_currentDate} Swimming {_activityLength} min {Math.Round(distance)} miles {Math.Round(speed)} mph {Math.Round(pace)} minutes per mile");
    }
}