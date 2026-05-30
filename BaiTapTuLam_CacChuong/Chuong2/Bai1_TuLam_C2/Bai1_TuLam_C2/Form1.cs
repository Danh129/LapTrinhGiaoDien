using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1_TuLam_C2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert1_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Kiểm tra nếu để trống
                if (string.IsNullOrWhiteSpace(txtAsciiInput.Text))
                {
                    throw new Exception("Vui lòng nhập mã ASCII!");
                }

                // 2. Ép kiểu sang số nguyên
                int asciiCode = int.Parse(txtAsciiInput.Text);

                // 3. Kiểm tra phạm vi mã ASCII (0-255)
                if (asciiCode < 0 || asciiCode > 255)
                {
                    throw new Exception("Mã ASCII phải nằm trong khoảng từ 0 đến 255!");
                }

                // 4. Chuyển đổi và hiển thị (ép kiểu int sang char)
                char resultChar = (char)asciiCode;
                lblCharResult.Text = resultChar.ToString();
            }
            catch (FormatException)
            {
                // Lỗi khi nhập chữ vào ô số
                MessageBox.Show("Vui lòng chỉ nhập số nguyên!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Các lỗi logic khác
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnConvert2_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Kiểm tra nếu để trống
                string input = txtCharInput.Text;
                if (string.IsNullOrEmpty(input))
                {
                    throw new Exception("Vui lòng nhập ký tự!");
                }

                // 2. Kiểm tra nếu nhập nhiều hơn 1 ký tự
                if (input.Length > 1)
                {
                    throw new Exception("Chỉ được nhập duy nhất một ký tự!");
                }

                // 3. Chuyển đổi và hiển thị (ép kiểu char sang int)
                char inputChar = input[0];
                int asciiResult = (int)inputChar;
                lblAsciiResult.Text = asciiResult.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
