namespace Shapes
{
    public class Rhombus : BasicShape
    {
        private double width;
        private double height;

        public Rhombus(double width, double height)
            : base(width, height)
        {

        }
        public override double CalculatePerimeter()
        {
            return Width * 4;
        }

        public override double CalculateArea()
        {
            return Height * Width;
        }
    }
}