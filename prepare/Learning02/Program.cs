using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

//porque es necesario crear insancias aqui?
// mis instancias son como el maquetado para lo que 
//quiero que se muestre
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
        //luego con este metodo lo que se hace es que la informacion
        //que tenemos en las instancias es ordenada como se programo en la clase job
        job1.Display();
        job2.Display();

//aqui hago instancia para acceder a mi resume projecto 
        Resume myResume = new Resume();
        //aqui estoy asignando un valor a la variable miembro de resume _name dandole valor de "David Witmeer'
        myResume._name = "David Witmer";


//aqui otra vez estoy ejecutando el metodo que previamene se designo en resume 
//alla tenemos una listaes decir que jobs se va agrefgr a la lista.
//resume en su clas llama a la lista de trabajos con un loop ya aqui solo lo mostramos alponer myResume.Display.
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();  
    }

}