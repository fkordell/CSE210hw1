using System;

public abstract class Goals{

    protected string _goalName;
    protected string _goalDescription;

    protected int _pointValue;
    

    public string displayGoals(){

        return($"{_goalName} / {_goalDescription} / {_pointValue}");
    }

    public virtual void doGoal(){

    }
    public virtual bool completeGoal(){
        return false;
    }

    public abstract string toFileLine();

    public abstract void fromFileLine( string fileline);
    protected List<Goals> _recordedGoals = new List<Goals>();
    public void Display(){
        foreach(Goals entry in _recordedGoals){
            Console.WriteLine(entry._goalName);
            Console.WriteLine(entry._goalDescription);
            Console.WriteLine(entry._pointValue);
        }
    }
    public void Save(string fileName){
        using (StreamWriter outputFile = new StreamWriter(fileName)){

            foreach(Goals entry in _recordedGoals){
                outputFile.WriteLine(entry.toFileLine());
            }
        }
    }
    


}