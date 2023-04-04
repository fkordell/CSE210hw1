using System;

class Program
{
    static void Main(string[] args)
    {

        List<Event> events = new List<Event>();
        Lectures lecture = new Lectures("How to properly recycle water", "This lecture will cover the important topics of recycling in the modern day in regards to how to effectively and properly recycle water", 
        "April 18, 2023", "5:00 p.m.", new Address("151 W 7th S.", "Rexburg", "Idaho", "83440"), "Lecture", "John Smith, Board of Directors, 350");
        Outdoors outdoor = new Outdoors("Ward Camping Trip", "This is going to be the annual ward camping trip for 2023", "August 15 2023", "12:00 p.m.", new Address("2100 HWY 395", "Palisades", "Idaho", "83452"), "Outdoors", "Slightly Overcast");
        Receptions reception = new Receptions("Wedding Reception", "This will be the wedding reception for Alex and Sarah", "June 12, 2023", "8 p.m.", new Address("210 w 12 st.", "Idaho Falls", "Idaho", "83404"), "Reception", "RSVP: alex&sarah@gmail.com");
        events.Add(lecture);
        events.Add(outdoor);
        events.Add(reception);

        foreach(Event evnt in events){
            Console.WriteLine();
            Console.WriteLine(evnt.GetShort());
            Console.WriteLine();
            Console.WriteLine(evnt.GetStandard());
            Console.WriteLine();
            Console.WriteLine(evnt.GetFull());
            Console.WriteLine();

        }
       
    }
}