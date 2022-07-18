
public class Square : Figure
{
    public double Side { get; private set; }
    public Square(double side)
    {
        if (side > 0)
            Side = side;
        else
        {
            Side = 1;
            Console.WriteLine("Square with parametrs is not exist");
        }
    }
    public override double GetArea()
    {
        return (Side * Side);
    }

}

