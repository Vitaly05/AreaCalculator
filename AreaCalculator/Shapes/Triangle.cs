using AreaCalculator.Exceptions;

namespace AreaCalculator.Shapes
{
    public class Triangle : BaseShape
    {
        private double a;
        private double b;
        private double c;

        public Triangle(double a, double b, double c)
        {
            if (!isValid(a, b, c))
                throw new ArgumentOutOfRangeException("The triangle sides must be greater than 0");
            if (!isTriangle(a, b, c))
                throw new NotTriangleException();

            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double GetArea()
        {
            var p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        // I don't understand why this library, which calculates the areas of shapes, needs to check for a rectangular triangle

        private bool isValid(double a, double b, double c) =>
            a > 0 || b > 0 || c > 0;

        private bool isTriangle(double a, double b, double c) =>
            a + b > c && b + c > a && c + a > b;
    }
}
