// Clase para representar un objetivo de lista de verificación con un valor de puntos por evento y un bono adicional al completarlo
public class ChecklistGoal : Goal
{
    private int _pointsPerEvent;
    private int _totalRequired;
    private int _completedCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, int pointsPerEvent, int totalRequired, int bonusPoints) : base(name)
    {
        _pointsPerEvent = pointsPerEvent;
        _totalRequired = totalRequired;
        _completedCount = 0;
        _bonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        _completedCount++;

        if (_completedCount >= _totalRequired)
        {
            _isCompleted = true;
            _pointsEarned = (_pointsPerEvent * _totalRequired) + _bonusPoints;
        }
        else
        {
            _pointsEarned += _pointsPerEvent;
        }
    }

    public override string GetGoalStatus()
    {
        return base.GetGoalStatus() + $" (Completado {_completedCount}/{_totalRequired} veces)";
    }
}
