public class Fraction
{
    //creo mis atributos o variables para numero superior e inferior
    private int _top;
    private int _bottom;

    //dentro de las llaves escrbimos los constructore

    public Fraction()
    {
       _top = 1;
       _bottom = 1; 
    }

    public Fraction(int numerator)
    {
        //_top es privada asi que estamos teniendo acceso medante el 
        //constructor  asignandole otro nombre desde donde ahora si podemos 
        //acceder a esta variable privada.

        _top = numerator;
        _bottom = 1;
    }

    public Fraction(int top , int bottom)
    {
        _top = top;
        _bottom = bottom;
    }



    public string GetFractionString()
    {
        string formatFraction = $"{_top} / {_bottom}";
        return formatFraction;
    }

    public double GetDecimalValue()
    {
        return (double) _top /(double)_bottom;
    }


}