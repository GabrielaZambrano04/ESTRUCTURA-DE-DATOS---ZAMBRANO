public class Circulo
{
    private double radio;

    public Circulo(double radio)
    {
        this.radio = radio;
    }

    public double CalcularArea()
    {
        return 3.141592653589793 * radio * radio;
    }

    public double CalcularPerimetro()
    {
        return 2 * 3.141592653589793 * radio;
    }
}

