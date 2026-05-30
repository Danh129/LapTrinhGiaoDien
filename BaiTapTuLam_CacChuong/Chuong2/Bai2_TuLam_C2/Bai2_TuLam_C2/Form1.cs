using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2_TuLam_C2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Hàm giải phương trình bậc 2
        private string GiaiPhuongTrinhBac2(double a, double b, double c)
        {
            if (a == 0) // Trường hợp phương trình bậc 1
            {
                if (b == 0)
                    return (c == 0) ? "Vô số nghiệm" : "Vô nghiệm";
                return "x = " + (-c / b).ToString("0.##");
            }

            double delta = b * b - 4 * a * c;
            if (delta < 0) return "Phương trình vô nghiệm";
            if (delta == 0) return "x1 = x2 = " + (-b / (2 * a)).ToString("0.##");

            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            return $"x1 = {x1:0.##}; x2 = {x2:0.##}";
        }

        private void btGiai_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Lấy dữ liệu từ TextBox
                // Nếu txtA.Text là "abc" hoặc để trống, dòng này sẽ văng lỗi FormatException
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                double c = double.Parse(txtC.Text);

                // 2. Gọi hàm đã viết ở trên và gán vào ô Kết quả
                lbKQ.Text = GiaiPhuongTrinhBac2(a, b, c);
            }
            catch (FormatException)
            {
                // Xử lý khi nhập sai định dạng (chữ, ký tự đặc biệt)
                MessageBox.Show("Lỗi: Vui lòng nhập số thực vào các ô a, b, c!", "Thông báo");
                txtA.Focus(); // Đưa con trỏ về ô A để nhập lại
            }
            catch (Exception ex)
            {
                // Các lỗi phát sinh khác nếu có
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }

        }
    }
}
