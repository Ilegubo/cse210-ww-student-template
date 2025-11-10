using System;
using System.Runtime.Versioning;

class Resume
{
    public string _name;
    public List<Job> jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine("Jobs:");
        foreach(Job job in jobs)
        {
            Console.WriteLine(job);
        }
    }
}