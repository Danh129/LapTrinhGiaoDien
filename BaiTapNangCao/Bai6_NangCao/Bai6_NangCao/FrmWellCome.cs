using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Bai6_NangCao
{
    public partial class FrmWellCome : Form
    {
        int count = 10;

        public FrmWellCome()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // 1. Vẽ nền pha trộn 2 màu (Đỏ - Vàng)
            LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle, Color.Red, Color.Yellow, LinearGradientMode.Horizontal);
            g.FillRectangle(brush, this.ClientRectangle);

            // 2. Vẽ chuỗi MSSV và Họ tên
            Font fontName = new Font("Arial", 25, FontStyle.Bold | FontStyle.Italic);
            string text = "2451050005_Le Thanh Danh";

            // Tính toán để vẽ chữ ra giữa
            SizeF size = g.MeasureString(text, fontName);
            g.DrawString(text, fontName, Brushes.Blue, (this.Width - size.Width) / 2, (this.Height - size.Height) / 2 - 20);

            // 3. Vẽ số đếm ngược
            Font fontCount = new Font("Arial", 20, FontStyle.Regular);
            g.DrawString(count.ToString(), fontCount, Brushes.Purple, (this.Width / 2) - 10, (this.Height / 2) + 40);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            count--;
            // Vẽ lại form để cập nhật số mới
            this.Invalidate(); 

            if (count == 0)
            {
                timer1.Stop();
                this.Hide(); 
                FrmMain f = new FrmMain();
                // Mở form chính
                f.ShowDialog(); 
                this.Close(); 
            }
        }
    }
}
