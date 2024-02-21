using AreaCalculator.Shapes;

namespace AreaCalculator.Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void GetArea_PositiveRadius_DefaultRound_ReturnsCorrectArea()
        {
            double radius = 5;
            double expected = 78.5;

            var result = AreaCalculator.GetArea(new Circle(radius));

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetArea_PositiveRadius_RoundFour_ReturnsCorrectArea()
        {
            double radius = 5;
            int digits = 4;
            double expected = 78.5398;

            var result = AreaCalculator.GetArea(new Circle(radius), digits);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetArea_ZeroRadius_DefaultRound_ReturnsZeroArea()
        {
            double radius = 0;
            double expected = 0;

            var result = AreaCalculator.GetArea(new Circle(radius));

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetArea_NegativeRadius_DefaultRound_ReturnsZeroArea()
        {
            double radius = -5;

            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                AreaCalculator.GetArea(new Circle(radius));
            });
        }
    }
}