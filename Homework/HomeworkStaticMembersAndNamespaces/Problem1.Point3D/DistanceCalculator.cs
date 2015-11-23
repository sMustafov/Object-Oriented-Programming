using System;

namespace Problem1.Point3D
{
    static public class DistanceCalculator
    {
        static double calculateDistance(Point3D p1, Point3D p2)
        {
            double distance =
                Math.Sqrt(Math.Pow((p2.X - p1.X), 2) + Math.Pow((p2.Y - p1.Y), 2) + Math.Pow((p2.Z - p1.Z), 2));
            return distance;
        }

        public static void Main()
        {
            Console.WriteLine("Starting Point Coordinates: ");
            Console.WriteLine(Point3D.StartingPoint.ToString());

            Console.WriteLine("Point1 Coordinates: ");
            Point3D p1 = new Point3D(-7, -4, 3);
            Console.WriteLine(p1.ToString());

            Console.WriteLine("Point2 Coordinates: ");
            Point3D p2 = new Point3D(17, 6, 2.5);
            Console.WriteLine(p2.ToString());

            Console.WriteLine("Distance between Point1 and Point2: ");
            Console.WriteLine(DistanceCalculator.calculateDistance(p1, p2));

        }
    }
}