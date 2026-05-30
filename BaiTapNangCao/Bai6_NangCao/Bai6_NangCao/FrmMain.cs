using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6_NangCao
{
    public partial class FrmMain : Form
    {
        //Bien luu hinh anh
        Image img; 
        //Toa do hinh
        int x = 100, y = 100; 
        //huong duy chuyen
        int dx = 5, dy = 5;   
        bool isRunning = false;
        int speed = 5;

        public FrmMain()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            // Load hinh mac dinh ban dau
            string path = Application.StartupPath + @"\Images\MayTinh.jpg";
            img = Image.FromFile(path);

        }

        //Ham OnPaint
        protected override void OnPaint(PaintEventArgs e)
        {
            if (img != null)
            {
                e.Graphics.DrawImage(img, x, y, 100, 100);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            switch (keyData)
            {
                //Bam S CHAY/DUNG
                case Keys.S:
                    isRunning = !isRunning;
                    timer1.Enabled = isRunning;
                    break;

                //Huong duy chuyen theo mui ten
                case Keys.Left:
                    dx = -speed; dy = 0; break;
                case Keys.Right:
                    dx = speed; dy = 0; break;
                case Keys.Up:
                    dx = 0; dy = -speed; break;
                case Keys.Down:
                    dx = 0; dy = speed; break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            x += dx;
            y += dy;

            //Ra khoi form vao huong doi xung
            if (x > this.ClientSize.Width) x = -100;
            if (x < -100) x = this.ClientSize.Width;
            if (y > this.ClientSize.Height) y = -100;
            if (y < -100) y = this.ClientSize.Height;

            this.Invalidate();
        }

        //Ham Change Picture
        private void menuChangePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Bitmap file|*.bmp;*.jpg;*.png;*.jpeg";
            if (open.ShowDialog() == DialogResult.OK)
            {
                img = Image.FromFile(open.FileName);
                this.Invalidate();
            }
        }

        //Ham Exit
        private void menuExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Exit application?", "Warning!",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes) Application.Exit();
        }
    }
}
