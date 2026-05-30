using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_TuLam_C3
{
    internal class Diem
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Diem(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double KhoangCach(Diem d)
        {
            return Math.Sqrt(Math.Pow(X - d.X, 2) + Math.Pow(Y - d.Y, 2));
        }
        public override string ToString()
        {
            return "(" + X + " ; " + Y + ")";
        }
    }
}
