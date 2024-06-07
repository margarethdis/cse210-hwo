using System;
using System.Collections.Generic;

// Clase base para las actividades
class Activity
{
    private DateTime date;
    private int durationMinutes;

    // Constructor
    public Activity(DateTime date, int durationMinutes)
    {
        this.date = date;
        this.durationMinutes = durationMinutes;
    }

    // Método virtual para obtener la distancia
    public virtual double GetDistance()
    {
        return 0; // No se almacena directamente la distancia en la clase base
    }

    // Método virtual para obtener la velocidad
    public virtual double GetSpeed()
    {
        return 0; // No se almacena directamente la velocidad en la clase base
    }

    // Método virtual para obtener el ritmo (pace)
    public virtual double GetPace()
    {
        return 0; // No se almacena directamente el ritmo en la clase base
    }

    // Método para obtener el resumen
    public virtual string GetSummary()
    {
        return $"{date.ToShortDateString()} - {GetType().Name} ({durationMinutes} min): Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}
