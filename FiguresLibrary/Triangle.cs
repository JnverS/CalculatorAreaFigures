
public class Triangle : Figure
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }
    public Triangle(double a, double b, double c)
    {
        if (a + b > c && a + c > b && b + c > a)
        {
            A = a;
            B = b;
            C = c;
        }
        else
        {
            Console.WriteLine("Triangle with parametrs is not exist");
            A = 1;
            B = 1;
            C = 1;
        }
    }

    public override double GetArea()
    {
        var p = (A + B + C) / 2;
        return Math.Sqrt(p * (p - A) * (p - B) *(p - C));
    }
    public bool IsRectangular()
    {
        return Math.Pow(C, 2) == Math.Pow(A, 2) + Math.Pow(B, 2);
    }
}

