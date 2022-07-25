namespace FiguresTests
{
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