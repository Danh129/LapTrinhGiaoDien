using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Bai1_TuLam_C3
{

    internal class PhanSo
    {
        public int TuSo { get; set; }
        public int MauSo { get; set; }

        public PhanSo(int tu = 0, int mau = 1)
        {
            TuSo = tu;
            // Tránh mẫu số bằng 0
            MauSo = (mau == 0) ? 1 : mau;
            RutGon();
        }
        private int UCLN(int a, int b)
        {
            a = Math.Abs(a); b = Math.Abs(b);
            while (b != 0) { a %= b; int t = a; a = b; b = t; }
            return a;
        }

        public void RutGon()
        {
            int uoc = UCLN(TuSo, MauSo);
            TuSo /= uoc;
            MauSo /= uoc;
            if (MauSo < 0) { TuSo = -TuSo; MauSo = -MauSo; }
        }

        // 4. CÁC PHƯƠNG THỨC TĨNH (STATIC) - Theo yêu cầu đề bài
        public static PhanSo Cong(PhanSo p1, PhanSo p2)
        {
            return new PhanSo(p1.TuSo * p2.MauSo + p2.TuSo * p1.MauSo, p1.MauSo * p2.MauSo);
        }

        public static PhanSo Tru(PhanSo p1, PhanSo p2)
        {
            return new PhanSo(p1.TuSo * p2.MauSo - p2.TuSo * p1.MauSo, p1.MauSo * p2.MauSo);
        }

        public static PhanSo Nhan(PhanSo p1, PhanSo p2)
        {
            return new PhanSo(p1.TuSo * p2.TuSo, p1.MauSo * p2.MauSo);
        }

        public static PhanSo Chia(PhanSo p1, PhanSo p2)
        {
            return new PhanSo(p1.TuSo * p2.MauSo, p1.MauSo * p2.TuSo);
        }

        // 5. So sánh bằng
        public bool Equals(PhanSo p)
        {
            return this.TuSo == p.TuSo && this.MauSo == p.MauSo;
        }

        public override string ToString() => MauSo == 1 ? $"{TuSo}" : $"{TuSo}/{MauSo}";
    }
}
