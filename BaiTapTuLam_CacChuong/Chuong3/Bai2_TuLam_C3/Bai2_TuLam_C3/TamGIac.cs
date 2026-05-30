using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_TuLam_C3
{
    internal class TamGIac
    {
        public double CanhA { get; set; }
        public double CanhB { get; set; }
        public double CanhC { get; set; }

        public TamGIac(double a, double b, double c)
        {
            CanhA = a;
            CanhB = b;
            CanhC = c;
        }

        public bool LaTamGiac()
        {
            return (CanhA + CanhB > CanhC) &&
                   (CanhA + CanhC > CanhB) &&
                   (CanhB + CanhC > CanhA) &&
                   (CanhA > 0 && CanhB > 0 && CanhC > 0);
        }

        public double ChuVi()
        {
            return CanhA + CanhB + CanhC;
        }

        public double DienTich()
        {
            double p = ChuVi() / 2;
            return Math.Sqrt(p * (p - CanhA) * (p - CanhB) * (p - CanhC));
        }

        public string LoaiTamGiac()
        {
            if (!LaTamGiac()) return "Không phải tam giác";

            if (CanhA == CanhB && CanhB == CanhC)
                return "Tam giác đều";

            if (CanhA == CanhB || CanhA == CanhC || CanhB == CanhC)
            {
                if (KiemTraVuong())
                    return "Tam giác vuông cân";
                return "Tam giác cân";
            }

            if (KiemTraVuong())
                return "Tam giác vuông";

            return "Tam giác thường";
        }

        private bool KiemTraVuong()
        {
            double a2 = CanhA * CanhA;
            double b2 = CanhB * CanhB;
            double c2 = CanhC * CanhC;

            return Math.Abs(a2 + b2 - c2) < 0.0001 ||
                   Math.Abs(a2 + c2 - b2) < 0.0001 ||
                   Math.Abs(b2 + c2 - a2) < 0.0001;
        }
    }
}
