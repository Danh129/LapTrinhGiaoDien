using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1_TuLam_C5
{
    public partial class Form1 : Form
    {
        // Toc do bong
        int dx = 5;
        int dy = 5;

        // Kiem tra start/stop
        bool dangChay = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Di chuyen bong
            picBall.Left += dx;
            picBall.Top += dy;

            // Cham tuong trai/phai
            if (picBall.Left <= 0 ||
                picBall.Right >= this.ClientSize.Width)
            {
                dx = -dx;
            }

            // Cham phia tren
            if (picBall.Top <= 0)
            {
                dy = -dy;
            }

            // Va vao thanh ngang
            if (picBall.Bounds.IntersectsWith(picThanh.Bounds))
            {
                dy = -dy;
            }

            // Rot xuong duoi
            if (picBall.Bottom >= this.ClientSize.Height)
            {
                timer1.Stop();
                MessageBox.Show("Game Over");
                Application.Exit();
                
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Qua trai
            if (e.KeyCode == Keys.Left)
            {
                picThanh.Left -= 20;
            }

            // Qua phai
            if (e.KeyCode == Keys.Right)
            {
                picThanh.Left += 20;
            }

            // Start / Stop bang phim S
            if (e.KeyCode == Keys.S)
            {
                if (dangChay == false)
                {
                    timer1.Start();
                    dangChay = true;
                }
                else
                {
                    timer1.Stop();
                    dangChay = false;
                }
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            picThanh.Left = e.X - picThanh.Width / 2;
        }
    }
}
