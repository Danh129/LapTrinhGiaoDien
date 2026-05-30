using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Bai3_TuLam_C2
{
    public partial class Form1 : Form
    {
        int score = 0;
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            //thiet lap giao dien luc dau  = 0
            lb1.Text = "0";
            lb2.Text = "0";
            lb3.Text = "0";
            lbScore.Text = score.ToString();

        }

        private void lbScore_Click(object sender, EventArgs e)
        {

        }

        //Click Play
        private void btPlay_Click(object sender, EventArgs e)
        {
            int n1 = rand.Next(0, 10);
            int n2 = rand.Next(0, 10);
            int n3 = rand.Next(0, 10);

            lb1.Text = n1.ToString();
            lb2.Text = n2.ToString();
            lb3.Text = n3.ToString();

            if (n1 == n2 && n2 == n3)
            {
                score += 100;
            }
            else
            {
                score -= 100;
            }
            lbScore.Text = score.ToString();
        }

        //Click Exit
        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Ban co muon thoat khong?", "Thong bao", MessageBoxButtons.YesNo);
            if (kq == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
