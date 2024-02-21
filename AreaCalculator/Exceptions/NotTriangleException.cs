namespace AreaCalculator.Exceptions
{
    public class NotTriangleException : Exception
    {
        public NotTriangleException() : base() { }
        public NotTriangleException(string message) : base(message) { }
        public NotTriangleException(string message, Exception inner) : base(message, inner) { }
    }
}
