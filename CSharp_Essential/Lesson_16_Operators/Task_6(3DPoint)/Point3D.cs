using System;
using System.Collections.Generic;
using System.Text;

namespace Task_6_3DPoint_
{
    public struct Point3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public static Point3D operator +( Point3D p1, Point3D p2)
        {
            return new Point3D(p1.X + p2.X, p1.Y + p2.Y, p1.Z + p2.Z);
        }
        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }
    }
}
