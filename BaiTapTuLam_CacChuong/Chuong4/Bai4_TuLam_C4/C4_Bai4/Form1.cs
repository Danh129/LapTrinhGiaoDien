using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C4_Bai4
{
    public partial class Form1 : Form
    {
        bool thoat = false;
        public Form1()
        {
            InitializeComponent();
            this.Opacity = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.05;
            }
            else
                timer1.Stop(); 
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!thoat)
            {
                if (MessageBox.Show("Ban co muon thoat?",
                    "Exit", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    e.Cancel = true;
                    timer2.Start();
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.05;
            }
            else
            { 
                thoat = true;
                timer2.Stop();
                this.Close();
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btTapTin_Click(object sender, EventArgs e)
        {
            
            if(openFileDialog1.ShowDialog()  == DialogResult.OK)
            {
                txtNodung.Text = openFileDialog1.FileName;
            }
        }

        private void btNhieuTapTin_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtNodung.Clear();
                foreach (string s in openFileDialog1.FileNames)
                {
                    txtNodung.AppendText(s +  Environment.NewLine);
                }
            }
        }

        private void btThuMuc_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtNodung.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btMauNen_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog(this) == DialogResult.OK)
            {
                txtNodung.BackColor = colorDialog1.Color;
            }
        }

        private void btMauChu_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txtNodung.ForeColor = colorDialog1.Color;
            }
        }

        private void btFont_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK )
            {
                txtNodung.Font = fontDialog1.Font;
            }
        }
    }
}
