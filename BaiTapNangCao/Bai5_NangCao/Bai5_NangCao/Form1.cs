using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5_NangCao
{

    public partial class Form1 : Form
    {
        //Bien luu toa do va van toc cua bong
        int Ball_X = 100, Ball_Y = 100;
        //Ban dau di chuyen sang trai -5
        int dx = -5, dy = 0;
        int Ball_Size = 50;

        int speed = 5;
        bool ktra = false;
        //Hinh qua bong
        Image ballImage = null;
        public Form1()
        {
            InitializeComponent();
            //Dung DoubleBuffered de ve muot
            this.DoubleBuffered = true;
        }

        //Chuc nang S, mui ten
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                //Nhan phim S de chay hoac dung
                case Keys.S: 
                    ktra = !ktra;
                    timer1.Enabled = ktra;
                    break;

                //Nhan mui ten de doi chieu
                case Keys.Left: 
                    dx = -speed; dy = 0; break;
                case Keys.Right:
                    dx = speed; dy = 0; break;
                case Keys.Up:
                    dx = 0; dy = -speed; break;
                case Keys.Down:
                    dx = 0; dy = speed; break;

                //Nhan PageUp tang toc
                case Keys.PageUp: 
                    speed += 2;
                    CapNhatVanToc();
                    break;

                //Nhan PageDown de giam toc do
                case Keys.PageDown: 
                    if (speed > 2) speed -= 2;
                    //Goi lai ham CapNhatVanToc
                    CapNhatVanToc();
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        //Ham cap nhat van toc
        private void CapNhatVanToc()
        {
            if (dx > 0) dx = speed; else if (dx < 0) dx = -speed;
            if (dy > 0) dy = speed; else if (dy < 0) dy = -speed;
        }

        //Ham thay doi anh
        private void changeImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ballImage = Image.FromFile(openFileDialog1.FileName);
                this.Invalidate();
            }
        }

        //Ham xu li chuyen dong
        private void timer1_Tick(object sender, EventArgs e)
        {
            Ball_X += dx;
            Ball_Y += dy;

            // Khi hinh roi khoi form no se xuat hien o phia doi dien
            if (Ball_X + Ball_Size < 0) Ball_X = this.ClientSize.Width;
            else if (Ball_X > this.ClientSize.Width) Ball_X = -Ball_Size;

            if (Ball_Y + Ball_Size < 0) Ball_Y = this.ClientSize.Height;
            else if (Ball_Y > this.ClientSize.Height) Ball_Y = -Ball_Size;

            //Ve lai form
            this.Invalidate();
        }

        //Ham Ve hinh va chu
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //Chu duoc ve tren form
            Font font = new Font("Arial", 20, FontStyle.Bold);
            string txtTop = "Nhấn phím S để chạy/dừng";
            string txtBottom = "Nhấn các phím mũi tên để đổi chiều chuyển động";

            g.DrawString(txtTop, font, Brushes.Purple, new Point(this.Width / 2 - 150, 50));
            g.DrawString(txtBottom, font, Brushes.Brown, new Point(this.Width / 2 - 300, this.Height - 150));

            // Ve hinh tron mau xanh thay cho bong
            if (ballImage != null)
                g.DrawImage(ballImage, Ball_X, Ball_Y, Ball_Size, Ball_Size);
            else
                g.FillEllipse(Brushes.Blue, Ball_X, Ball_Y, Ball_Size, Ball_Size);
        }

        //Ham thay doi nen
        private void changeBackgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
        }

        //Ham Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Đóng ứng dụng?", "Cảnh báo",
                                   MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
