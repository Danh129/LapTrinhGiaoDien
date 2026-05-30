using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_TuLam_C3
{
    internal class HinhTron
    {
        public Diem Tam { get; set; }
        public double BanKinh { get; set; }
        public HinhTron(Diem tam, double bankinh)
        {
            Tam = tam;
            BanKinh = bankinh;
        }
        public double ChuVi()
        {
            return 2 * Math.PI * BanKinh;
        }
        public double DienTich()
        {
            return Math.PI * BanKinh * BanKinh;
        }
        public bool DiemNamTrong(Diem d)
        {
            double khoangCach = Tam.KhoangCach(d);
            return khoangCach <= BanKinh;
        }
        public bool DiemNamTren(Diem d)
        {
            double khoangCach = Tam.KhoangCach(d);
            return Math.Abs(khoangCach - BanKinh) < 0.0001;
        }
        public override string ToString()
        {
            return "Hình tròn tâm " + Tam.ToString() + ", bán kính = " + BanKinh;
        }
    }
}
