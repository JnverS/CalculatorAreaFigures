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
}