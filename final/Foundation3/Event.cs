using System;

public class Event{

    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;

    private Address _address;
    private string _eventType;
    private string _eventSpecificInfo;

    


    public Event(string eventTitle, string description, string date, string time, Address address, string eventType, string eventSpecificInfo){
        _eventType = eventType;
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _eventSpecificInfo = eventSpecificInfo;

    }
   

    public string GetStandard(){

         return $"Title: {_eventTitle}\n Description: {_description}\n Date: {_date}\n Time: {_time}\n Address: {_address}";
    }
    public string GetFull(){

        return $"Title: {_eventTitle}\n Description: {_description}\n Date: {_date}\n Time: {_time}\n Address: {_address}\n Event Type: {_eventType}\n Info: {_eventSpecificInfo}";
    }
    public string GetShort(){
        return $"Title: {_eventTitle} Event Type: {_eventType} Date: {_date}";
    }


}