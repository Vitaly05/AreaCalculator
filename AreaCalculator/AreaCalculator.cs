using AreaCalculator.Shapes;

namespace AreaCalculator
{
    public static class AreaCalculator
    {
        public static double GetArea(BaseShape shape, int digits = 1) => 
            Math.Round(shape.GetArea(), digits);
    }
}
