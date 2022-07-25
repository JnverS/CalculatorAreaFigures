namespace FiguresTests
{
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
}