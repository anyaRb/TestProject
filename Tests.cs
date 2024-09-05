using NUnit.Framework;
using AreaCalcLib;

namespace GeometryLibTests
{
    public class GeometryLibTests
    {
        [Test]
        public void TestCircleArea()
        {
            var circle = new Circle(10);
            double area = circle.CalculateArea();
            Assert.AreEqual(Math.PI * 100, area, 0.0001);
        }

        [Test]
        public void TestTriangleArea()
        {
            var triangle = new Triangle(3, 4, 5);
            double area = triangle.CalculateArea();
            Assert.AreEqual(6, area, 0.0001);
        }

        [Test]
        public void TestRightTriangleCheck()
        {
            var triangle = new Triangle(3, 4, 5);
            bool isRight = triangle.IsRightTriangle();
            Assert.IsTrue(isRight);
        }

        [Test]
        public void TestAreaCalculatorWithCircle()
        {
            Shape circle = new Circle(10);
            double area = AreaCalculator.CalculateArea(circle);
            Assert.AreEqual(Math.PI * 100, area, 0.0001);
        }

        [Test]
        public void TestAreaCalculatorWithTriangle()
        {
            Shape triangle = new Triangle(3, 4, 5);
            double area = AreaCalculator.CalculateArea(triangle);
            Assert.AreEqual(6, area, 0.0001);
        }

        [Test]
        public void TestInvalidTriangle()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 3));
        }
    }
}