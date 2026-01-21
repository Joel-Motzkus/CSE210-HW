using System;


public class Job

{
    public string _jobTitle;
    public string _jobHours;
    public int _jobWage;
    public string _companyName;

    public void display()
    {
        Console.WriteLine($"{_jobTitle} {_jobHours} {_jobWage} {_companyName}.");
    }
}
