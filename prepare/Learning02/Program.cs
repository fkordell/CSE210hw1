using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._jobTitle = "Delivery Driver";
        job1._company = "Jimmy Johns";
        job1._startYear = 2022;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Cutter Operator";
        job2._company = "McCain";
        job2._startYear = 2020;
        job2._endYear = 2021;

        Job job3 = new Job();
        job3._jobTitle = "Warehouse Lead";
        job3._company = "Monkey Bars";
        job3._startYear = 2017;
        job3._endYear = 2018;

        Resume myResume = new Resume();
        myResume._name = "Kordell Farley";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);

        myResume.Display();
    }
}