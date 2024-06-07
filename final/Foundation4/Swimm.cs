// Clase para nadar
class Swimming : Activity
{
    private int laps;

    // Constructor
    public Swimming(DateTime date, int durationMinutes, int laps) : base(date, durationMinutes)
    {
        this.laps = laps;
    }

    // Método para obtener la distancia
    public override double GetDistance()
    {
        return laps * 50 / 1000 * 0.62; // Convertir metros a millas
    }

    // Método para obtener la velocidad
    public override double GetSpeed()
    {
        return GetDistance() / durationMinutes * 60;
    }

    // Método para obtener el ritmo (pace)
    public override double GetPace()
    {
        return durationMinutes / GetDistance();
    }
}
