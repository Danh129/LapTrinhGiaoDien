using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1_TuLam_C3
{
    public partial class Form1 : Form
    {
        PhanSo ps1, ps2, ketQuaDung;
        Random rand = new Random();
        int diem = 0;
        public Form1()
        {
            InitializeComponent();
            TaoCauHoi();
        }

        //Click nut CauHoiTiep
        private void btCauMoi_Click(object sender, EventArgs e)
        {
            TaoCauHoi();
        }

        private void TaoCauHoi()
        {
            // Sinh ngẫu nhiên tử/mẫu từ 1-10
            ps1 = new PhanSo(rand.Next(1, 11), rand.Next(1, 11));
            ps2 = new PhanSo(rand.Next(1, 11), rand.Next(1, 11));

            // Sinh phép toán ngẫu nhiên
            string[] phepToan = { "+", "-", "*", "/" };
            string chon = phepToan[rand.Next(0, 4)];
            lbPhepTinh.Text = chon;

            // Hiển thị lên giao diện
            lbTu1.Text = ps1.TuSo.ToString();
            lbMau1.Text = ps1.MauSo.ToString();
            lbTu2.Text = ps2.TuSo.ToString();
            lbMau2.Text = ps2.MauSo.ToString();

            // Tính toán bằng phương thức STATIC
            if (chon == "+") ketQuaDung = PhanSo.Cong(ps1, ps2);
            else if (chon == "-") ketQuaDung = PhanSo.Tru(ps1, ps2);
            else if (chon == "*") ketQuaDung = PhanSo.Nhan(ps1, ps2);
            else ketQuaDung = PhanSo.Chia(ps1, ps2);

            // Reset ô nhập
            txtTuAn.Clear();
            txtMauAn.Clear();
            lbThongBao.Text = "Nhập đáp án của bạn...";
            lbThongBao.ForeColor = Color.Black;
        }

        //Click nút KiemTra
        private void btKiemTra_Click(object sender, EventArgs e)
        {
            try
            {
                int t = int.Parse(txtTuAn.Text);
                int m = int.Parse(txtMauAn.Text);
                PhanSo psUser = new PhanSo(t, m);

                if (psUser.Equals(ketQuaDung))
                {
                    diem += 10;
                    lbThongBao.Text = "CHÍNH XÁC! (+10)";
                    lbThongBao.ForeColor = Color.Green;
                    lbDiem.Text +=  diem;
                }
                else
                {
                    lbThongBao.Text = "SAI RỒI! Đáp án: " + ketQuaDung.ToString();
                    lbThongBao.ForeColor = Color.Red;
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số nguyên vào ô đáp án!");
            }
        }
    }
}
