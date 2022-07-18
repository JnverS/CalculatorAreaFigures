
public class Circle : Figure
{
    public double Radius { get; private set; }
    public Circle(double radius)
    {
        if (radius > 0)
            Radius = radius;
        else
        {
            Radius = 1;
            Console.WriteLine("Circle with parametrs is not exist");
        }
    }
    public override double GetArea()
    {
        return (Math.PI * Radius * Radius);
    }

}
