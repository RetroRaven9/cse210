using System;


class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company =  "Microsoft";
        job1._startYear = 1985;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._jobTitle = "Game Developer";
        job2._company =  "Sony Entertainment";
        job2._startYear = 2002;
        job2._endYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "Tylar Hill";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();



       
    }
}