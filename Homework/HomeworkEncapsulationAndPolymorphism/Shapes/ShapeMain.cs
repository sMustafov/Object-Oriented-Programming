using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class ShapeMain
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>()
            {
                new Circle(5),
                new Rectangle(4,5),
                new Rhombus(4,6),
                new Circle(9),
                new Rectangle(2,7),
                new Rhombus(3,9),
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.GetType().Name);
                Console.WriteLine("Area: {0:0.00}",shape.CalculateArea());
                Console.WriteLine("Perimeter: {0:0.00}", shape.CalculatePerimeter());
                Console.WriteLine();
            }
        }
    }
}
