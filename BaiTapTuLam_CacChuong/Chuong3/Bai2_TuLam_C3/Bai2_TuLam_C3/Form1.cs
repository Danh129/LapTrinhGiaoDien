using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2_TuLam_C3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btTinh_Click(object sender, EventArgs e)
        {
            if (txtCanhA.Text == "" || txtCanhB.Text == "" || txtCanhC.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ 3 cạnh!", "Lỗi");
                return;
            }
            try
            {
                double a = double.Parse(txtCanhA.Text);
                double b = double.Parse(txtCanhB.Text);
                double c = double.Parse(txtCanhC.Text);
                TamGIac tg = new TamGIac(a, b, c);
                lbKq.Text = "";
                lbKq.Text += "\r\n";
                if (tg.LaTamGiac())
                {
                    lbKq.Text += "✓ Ba cạnh tạo thành tam giác\r\n";
                    lbKq.Text += "\r\n";
                    lbKq.Text += "• Loại tam giác: " + tg.LoaiTamGiac() + "\r\n";
                    lbKq.Text += "• Chu vi: " + tg.ChuVi().ToString("F2") + "\r\n";
                    lbKq.Text += "• Diện tích: " + tg.DienTich().ToString("F2") + "\r\n";
                }
                else
                {
                    lbKq.Text += "✗ Ba cạnh KHÔNG tạo thành tam giác!\r\n";
                    lbKq.Text += "\r\n";
                    lbKq.Text += "Gợi ý: Tổng 2 cạnh phải lớn hơn cạnh còn lại\r\n";
                    lbKq.Text += "Và các cạnh phải lớn hơn 0";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!\nVí dụ: 3, 4.5, 6", "Lỗi");
            }

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            txtCanhA.Text = "";
            txtCanhB.Text = "";
            txtCanhC.Text = "";
            lbKq.Text = "";
            txtCanhA.Focus();
        }
    }
}
