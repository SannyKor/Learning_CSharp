using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    public class Block
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public double SideD { get; set; }

        public Block(double a, double b, double c, double d)
        {
            SideA = a;
            SideB = b;
            SideC = c;
            SideD = d;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Block other = (Block)obj;

            return SideA == other.SideA &&
                   SideB == other.SideB &&
                   SideC == other.SideC &&
                   SideD == other.SideD;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(SideA, SideB, SideC, SideD);
        }
        public override string ToString()
        {
            return $"Блок: Сторона A = {SideA}, B = {SideB}, C = {SideC}, D = {SideD}";
        }
    }

}
