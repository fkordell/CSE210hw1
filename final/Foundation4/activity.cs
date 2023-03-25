using System;

public class Activity{

    protected string _currentDate;

    protected double _activityLength;
    protected double _distance;


    public virtual void doActivity(){

    }
    public double getDuration(){
        return _activityLength;
    }
    // public double getDistance(){
        
    // }
}