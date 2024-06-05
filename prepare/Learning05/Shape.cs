public class Shape
{
    private string color;

    public Shape(string color)
    {
        this.color = color;
    }

    public string GetColor()
    {
        return color;
    }

    public virtual double GetArea()
    {
        return 0; // Base implementation for unknown shapes
    }
}
