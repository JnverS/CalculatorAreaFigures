class Program
{
    static void Main(string[] args)
    {
        //valid
        Circle circle = new Circle(10);
        Console.WriteLine("Площадь круга с радиусом 10 = " + circle.GetArea());

        Triangle triangle = new Triangle(8, 6, 10);
        Console.WriteLine("Площадь треугольника со сторонами 6,8,10 = " + triangle.GetArea());
        Console.WriteLine("Является ли данный треугольник прямоугольным? " + triangle.IsRectangular());

        Triangle triangle2 = new Triangle(2, 2, 2);
        Console.WriteLine("Площадь треугольника со сторонами 2,2,2 = " + triangle2.GetArea());
        Console.WriteLine("Является ли данный треугольник прямоугольным? " + triangle2.IsRectangular());

        Square square = new Square(5);
        Console.WriteLine("Площадь квадрата со строной 5 = " + square.GetArea());
        //not valid
        Circle circle1 = new Circle(-1);
        Triangle triangle1 = new Triangle(1, 2, 3);
        Square square1 = new Square(-1);
    }
}
