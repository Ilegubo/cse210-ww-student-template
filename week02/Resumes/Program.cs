using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Job job1 = new Job();

        //Testing the class Job

        //First job
        job1._company = "Ghana Telecom";
        job1._jobTitle = "Student";
        job1._startYear = 2024;
        job1._endYear = 2027;
        job1.Display();

        //Second job
        Job job2 = new Job();
        job2._company = "MTN Ghana";
        job2._jobTitle = "Backend Engineer";
        job2._startYear = 2026;
        job2._endYear = 2030;
        job2.Display();
        
        //Testing the class Resume

    }
}