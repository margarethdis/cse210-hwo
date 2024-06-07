
// Clase representar un objetivo genérico
public abstract class Goal
{
    private string _name;
    protected bool _isCompleted;
    protected int _pointsEarned;

    public string Name 
    {
        get { return _name; }
        set { _name = value; }
    }

    public bool IsCompleted 
    {
        get { return _isCompleted; }
    }

    public int PointsEarned 
    {
        get { return _pointsEarned; }
    }

    public Goal(string name)
    {
        _name = name;
        _isCompleted = false;
        _pointsEarned = 0;
    }

    // par registrar un evento relacionado con el objetivo
    public abstract void RecordEvent();

    //paraa mostrar información sobre el objetivo
    public virtual string GetGoalStatus()
    {
        return $"{_name} - {(_isCompleted ? "Completado" : "No completado")}";
    }
}
