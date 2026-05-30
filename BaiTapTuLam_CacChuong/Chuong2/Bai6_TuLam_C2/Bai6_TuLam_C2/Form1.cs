using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6_TuLam_C2
{
    public partial class Form1 : Form
    {
        class SinhVien
        {
            public string Ma { get; set; }
            public string Ho { get; set; }
            public string Ten { get; set; }
        }

        // Danh sach sinh vien
        List<SinhVien> ds = new List<SinhVien>();
        public Form1()
        {
            InitializeComponent();
        }

        // Ham hien thi len DataGridView
        void HienThi(List<SinhVien> dssv)
        {
            dgvSinhVien.DataSource = null;
            dgvSinhVien.DataSource = dssv;
        }

        //Click Them
        private void btThem_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.Ma = txtMa.Text;
            sv.Ho = txtHo.Text;
            sv.Ten = txtTen.Text;

            ds.Add(sv);

            HienThi(ds);

            txtMa.Clear();
            txtHo.Clear();
            txtTen.Clear();

            txtMa.Focus();
        }

        //Click Tim Ma
        private void btTimMa_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text.Trim();

            List<SinhVien> kq = ds.Where(sv =>
                sv.Ma.Trim() == ma
            ).ToList();

            HienThi(kq);
        }

        //Click Tim Ten
        private void btTimTen_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text.Trim().ToLower();

            List<SinhVien> kq = ds.Where(sv =>
                sv.Ten.Trim().ToLower() == ten
            ).ToList();

            HienThi(kq);

            
        }

        //Click Sap Xep
        private void btSapXep_Click(object sender, EventArgs e)
        {
            ds = ds.OrderBy(sv => sv.Ten).ToList();
            HienThi(ds);
        }
    }
}
