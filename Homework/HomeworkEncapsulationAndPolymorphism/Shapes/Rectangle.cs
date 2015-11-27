namespace Shapes
{
    public class Rectangle : BasicShape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height) : base (width,height)
        {
            
        }
        public override double CalculatePerimeter()
        {
            return (Height * 2) + (Width * 2);
        }

        public override double CalculateArea()
        {
            return Height * Width;
        }
    }
}