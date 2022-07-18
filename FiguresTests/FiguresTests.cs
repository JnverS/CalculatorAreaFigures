namespace FiguresTests
{
    public class TestCircle
    {
        [Fact]
        public void TestValidCreateCircle()
        {
            var radius = 5;
            var circle = new Circle(radius);
            Assert.True(radius == circle.Radius);
        }
        [Fact]
        public void TestNotValidCreateCircle()
        {
            var radius = -5;
            var circle = new Circle(radius);
            Assert.True(circle.Radius == 1);
        }
        [Fact]
        public void TestValidGetAreaCircle()
        {
            var radius = 5;
            var expected = Math.PI * radius * radius;
            var circle = new Circle(radius);
            double area = circle.GetArea();
            Assert.True(expected == area);
        }
        [Fact]
        public void TestNotValidGetAreaCircle()
        {
            var radius = -5;
            var expected = Math.PI;
            var circle = new Circle(radius);
            double area = circle.GetArea();
            Assert.True(expected == area);
        }
    }
    public class TestTriangle
    {
        [Fact]
        public void TestValidCreateTriangle()
        {
            double a = 2;
            double b = 2;
            double c = 2;
            var triangle = new Triangle(a, b, c);
            Assert.True(a == triangle.A);
            Assert.True(b == triangle.B);
            Assert.True(c == triangle.C);
        }
        [Fact]
        public void TestNotValidACreateTriangle()
        {
            double a = -2;
            double b = 2;
            double c = 2;
            var triangle = new Triangle(a, b, c);
            Assert.True(triangle.A == 1);
            Assert.True(triangle.B == 1);
            Assert.True(triangle.C == 1);
        }
        [Fact]
        public void TestNotValidBCreateTriangle()
        {
            double a = 2;
            double b = -2;
            double c = 2;
            var triangle = new Triangle(a, b, c);
            Assert.True(triangle.A == 1);
            Assert.True(triangle.B == 1);
            Assert.True(triangle.C == 1);
        }
        [Fact]
        public void TestNotValidCCreateTriangle()
        {
            double a = 2;
            double b = 2;
            double c = -2;
            var triangle = new Triangle(a, b, c);
            Assert.True(triangle.A == 1);
            Assert.True(triangle.B == 1);
            Assert.True(triangle.C == 1);
        }
        [Fact]
        public void TestValidGetAreaTriangle()
        {
            double a = 2;
            double b = 2;
            double c = 2;
            double expected = (a + b + c) / 2;
            var triangle = new Triangle(a, b, c);
            double area = triangle.GetArea();
            Assert.True(expected == area);
        }
        [Fact]
        public void TestNotValidGetAreaTriangle()
        {
            double a = 2;
            double b = 2;
            double c = -2;
            double expected = 1.5;
            var triangle = new Triangle(a, b, c);
            double area = triangle.GetArea();
            Assert.True(expected == area);
        }
        [Fact]
        public void TestIsRectangular()
        {
            double a = 8;
            double b = 6;
            double c = 10;
            var triangle = new Triangle(a, b, c);
            bool isRectangl = triangle.IsRectangular();
            Assert.True(isRectangl);
        }
        [Fact]
        public void TestIsNotRectangular()
        {
            double a = 3;
            double b = 3;
            double c = 3;
            var triangle = new Triangle(a, b, c);
            bool isRectangl = triangle.IsRectangular();
            Assert.False(isRectangl);
        }
    }
    public class TestSquare
    {
        [Fact]
        public void TestValidCreateSquare()
        {
            double side = 4;
            var square = new Square(side);
            Assert.True(square.Side == side);
        }
        [Fact]
        public void TestNotValidCreateSquare()
        {
            double side = 0;
            var square = new Square(side);
            Assert.True(square.Side == 1);
        }
        [Fact]
        public void TestValidGetAreaSquare()
        {
            double side = 10;
            double expected = side * side;
            var square = new Square(side);
            double area = square.GetArea();
            Assert.True(expected == area);
        }
        [Fact]
        public void TestNotValidGetAreaSquare()
        {
            double side = -10;
            double expected = 1;
            var square = new Square(side);
            double area = square.GetArea();
            Assert.True(expected == area);
        }
    }
}