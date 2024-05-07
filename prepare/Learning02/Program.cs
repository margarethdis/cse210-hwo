using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

//porque es necesario crear insancias aqui?
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2010;
        job1._endYear =2014;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // Llama al método Display de la clase Job 
        job1.Display();
        job2.Display();

        Resume myResume = new Resume();
        myResume._name = "David Witmer";



        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();  
    }

}