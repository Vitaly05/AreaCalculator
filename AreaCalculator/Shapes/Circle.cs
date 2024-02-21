namespace AreaCalculator.Shapes
{
    public class Circle : BaseShape
    {
        private double radius;

        public Circle(double radius)
        {
            if (radius < 0) throw new ArgumentOutOfRangeException("The radius must be greater than or equals to 0");
            this.radius = radius;
        }

        public override double GetArea() =>
            Math.PI * Math.Pow(radius, 2);
    }
}
