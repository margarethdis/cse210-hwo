// Clase para representar un objetivo eterno con un valor de puntos fijo por evento
public class EternalGoal : Goal
{
    private int _pointsPerEvent;

    public EternalGoal(string name, int pointsPerEvent) : base(name)
    {
        _pointsPerEvent = pointsPerEvent;
    }

    public override void RecordEvent()
    {
        // Lógica para registrar el evento y otorgar puntos
        _pointsEarned += _pointsPerEvent;
    }
}
