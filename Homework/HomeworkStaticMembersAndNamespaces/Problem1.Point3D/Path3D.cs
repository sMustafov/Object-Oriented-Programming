using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Problem1.Point3D;

namespace Problem1.Point3D
{
    class Path3D
    {
        private IList<Point3D> paths;

        public Path3D(params Point3D[] points3D)
        {
            this.paths = points3D.ToList();
        }

        public IList<Point3D> Paths
        {
            get { return this.paths; }
            set
            {
                if (null == value)
                {
                    throw new ArgumentNullException();
                }
                this.paths = value;
            }
        }

        public int Count
        {
            get { return Paths.Count; }
        }

        public Point3D this[int index]
        {
            get { return this.Paths[index]; }
            set
            {
                if (null == value) throw new ArgumentNullException();
                this.Paths[index] = value;
            }
        }
        public void Add(Point3D point)
        {
            this.Paths.Add(point);
        }
        public override string ToString()
        {
            StringBuilder pathsSB = new StringBuilder();
            for (int i = 0; i < this.Count; i++)
            {
                pathsSB.Append(this[i].ToString());
                if (i != this.Count - 1) { pathsSB.Append(","); }
            }
            return pathsSB.ToString();
        }
    }
}

static class Storage
{
    public static void Save(string fileName, Path3D path)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.Write(path);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            throw ex.InnerException;
        }
    }


    public static Path3D Load(string fileName)
    {
        Path3D path = new Path3D();

        using (StreamReader sr = new StreamReader(fileName))
        {
            string input = sr.ReadToEnd();

            string pattern = "{([\\d,.]+), ([\\d,.]+), ([\\d,.]+)}";

            var reg = new Regex(pattern);
            var matches = reg.Matches(input);

            if (matches.Count <= 0)
            {
                throw new ApplicationException("Invalid data in file " + fileName);
            }

            foreach (Match match in matches)
            {
                double x = double.Parse(match.Groups[1].Value);
                double y = double.Parse(match.Groups[2].Value);
                double z = double.Parse(match.Groups[3].Value);

                Point3D p = new Point3D(x, y, z);
                path.Add(p);
            }
        }

        return path;
    }
}

