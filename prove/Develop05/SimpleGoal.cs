// Clase para representar un objetivo simple con un valor de puntos fijo
public class SimpleGoal : Goal
{
    private int _points;

    public SimpleGoal(string name, int points) : base(name)
    {
        _points = points;
    }

    public override void RecordEvent()
    {
        _isCompleted = true;
        _pointsEarned = _points;
    }
}