// Clase para ciclismo
class Cycling : Activity
{
    private double speed;

    // Constructor
    public Cycling(DateTime date, int durationMinutes, double speed) : base(date, durationMinutes)
    {
        this.speed = speed;
    }

    // Método para obtener la velocidad
    public override double GetSpeed()
    {
        return speed;
    }

    // Método para obtener la distancia
    public override double GetDistance()
    {
        return speed * durationMinutes / 60;
    }

    // Método para obtener el ritmo (pace)
    public override double GetPace()
    {
        return 60 / speed;
    }
}
