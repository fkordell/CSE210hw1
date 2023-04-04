using System;

public abstract class Activity{

    protected string _currentDate;

    protected string _activityType;

    protected double _activityLength;

    public virtual void getSpeed(){

    }
    public virtual void getPace(){

    }
    public abstract string getSummary(double input);
}