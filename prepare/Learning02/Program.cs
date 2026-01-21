using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "TGMS Technician";
        job1._companyName = "TI";
        job1._jobWage = 72000;
        job1._jobHours = "6-4" ;

        

        Resume myResume = new Resume();
        myResume._name = "Joel Motzkus";

        myResume._jobs.Add(job1);
        

        myResume.Display();
    }
}