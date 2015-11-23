using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Problem1.Point3D
{
    class Point3D
    {
        private double x;
        private double y;
        private double z;

        public Point3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Point3D StartingPoint = new Point3D(0,0,0);

        public double X
        {
            get { return x; }
        }
        public double Y
        {
            get { return y; }
        }
        public double Z
        {
            get { return z; }
        }

        public override string ToString()
        {
            string coordinate = String.Format("x = {0}\ny = {1}\nz = {2}",X,Y,Z);
            return coordinate;
        }
    }
}
