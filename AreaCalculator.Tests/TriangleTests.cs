using AreaCalculator.Exceptions;
using AreaCalculator.Shapes;

namespace AreaCalculator.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void GetArea_ValidSides_DefaultRound_ReturnsCorrectArea()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 6;

            var result = AreaCalculator.GetArea(new Triangle(a, b, c));

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetArea_ValidSides_RoundFour_ReturnsCorrectArea()
        {
            double a = 9;
            double b = 10;
            double c = 11;
            int digits = 4;
            double expected = 42.4264;

            var result = AreaCalculator.GetArea(new Triangle(a, b, c), digits);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetArea_ZeroSides_DefaultRound_ThrowsExpection()
        {
            double a = 0;
            double b = 0;
            double c = 0;

            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                AreaCalculator.GetArea(new Triangle(a, b, c));
            });
        }

        [TestMethod]
        public void GetArea_NegativeSides_DefaultRound_ThrowsExpection()
        {
            double a = -3;
            double b = -4;
            double c = -5;

            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                AreaCalculator.GetArea(new Triangle(a, b, c));
            });
        }

        [TestMethod]
        public void GetArea_NotTriangle_DefaultRound_ThrowsExpection()
        {
            double a = 1;
            double b = 1;
            double c = 10;

            Assert.ThrowsException<NotTriangleException>(() =>
            {
                AreaCalculator.GetArea(new Triangle(a, b, c));
            });
        }
    }
}
