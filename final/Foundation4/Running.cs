// Clase para correr
class Running : Activity
{
    private double distance;

    // Constructor
    public Running(DateTime date, int durationMinutes, double distance) : base(date, durationMinutes)
    {
        this.distance = distance;
    }

    // Método para obtener la distancia
    public override double GetDistance()
    {
        return distance;
    }

    // Método para obtener la velocidad
    public override double GetSpeed()
    {
        return distance / durationMinutes * 60;
    }

    // Método para obtener el ritmo (pace)
    public override double GetPace()
    {
        return durationMinutes / distance;
    }
}