using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3_TuLam_C3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btTinhToan_Click(object sender, EventArgs e)
        {
            if (txtTamX.Text == "" || txtTamY.Text == "" || txtR.Text == "" ||
               txtDiemX.Text == "" || txtDiemY.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi");
                return;
            }
            try
            {
                double tamX = double.Parse(txtTamX.Text);
                double tamY = double.Parse(txtTamY.Text);
                double bankinh = double.Parse(txtR.Text);
                double diemX = double.Parse(txtDiemX.Text);
                double diemY = double.Parse(txtDiemY.Text);
                if (bankinh <= 0)
                {
                    MessageBox.Show("Bán kính phải lớn hơn 0!", "Lỗi");
                    return;
                }
                Diem tam = new Diem(tamX, tamY);
                HinhTron ht = new HinhTron(tam, bankinh);
                Diem diem = new Diem(diemX, diemY);
                txtKq.Text = "";
                txtKq.Text += "========== KẾT QUẢ ==========\r\n\r\n";
                txtKq.Text += "HÌNH TRÒN:\r\n";
                txtKq.Text += "• Tâm: " + tam.ToString() + "\r\n";
                txtKq.Text += "• Bán kính: " + bankinh + "\r\n";
                txtKq.Text += "• Chu vi: " + ht.ChuVi().ToString("F2") + "\r\n";
                txtKq.Text += "• Diện tích: " + ht.DienTich().ToString("F2") + "\r\n\r\n";
                txtKq.Text += "ĐIỂM KIỂM TRA:\r\n";
                txtKq.Text += "• Tọa độ: " + diem.ToString() + "\r\n\r\n";
                if (ht.DiemNamTrong(diem))
                {
                    if (ht.DiemNamTren(diem))
                        txtKq.Text += "✓ Điểm NẰM TRÊN đường tròn!";
                    else
                        txtKq.Text += "✓ Điểm NẰM TRONG hình tròn!";
                }
                else
                {
                    txtKq.Text += "✗ Điểm NẰM NGOÀI hình tròn!";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!\nVí dụ: 2.5, -3, 4", "Lỗi");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            txtTamX.Text = "";
            txtTamY.Text = "";
            txtR.Text = "";
            txtDiemX.Text = "";
            txtDiemY.Text = "";
            txtKq.Text = "";
            txtTamX.Focus();
        }
    }
}
