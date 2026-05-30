using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3_NangCao
{
    public partial class Form1 : Form
    {
        //Random quay so
        Random rand = new Random();
        int diemSo = 0;
        //Dem so lan timer chay tao hieu ung cham
        int countTick = 0; 
        //Bien luu lable
        Label currentLabel;

        public Form1()
        {
            InitializeComponent();
            //Goi ham SetupInitialState();
            SetupInitialState();
        }

        
        private void SetupInitialState()
        {
            //Gia tri va diem so = 0
            lbSo1.Text = lbSo2.Text = lbSo3.Text = "0";
            lbDiem.Text = diemSo.ToString();

            //So 1 khong bi vo hieu hoa
            btSo1.Enabled = true;
            //So2, So3, TiepTuc bi vo hieu hoa 
            btSo2.Enabled = false;
            btSo3.Enabled = false;
            btTiepTuc.Enabled = false;

            //Duoc phep chon cac radi..
            groupBox1.Enabled = true; 
        }
        
        //Xu li Click So1
        private void btSo1_Click(object sender, EventArgs e)
        {
            //kiem tra ban da chon dap an hay chua
            if (!rd1.Checked && !rd3.Checked &&
                !rd2.Checked && !rd4.Checked)
                //hien thi hop thoai canh bao
            {
                MessageBox.Show("Ban chua chon dap an!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            StartSpin(lbSo1, btSo1, btSo2);
            //vo hieu hoa DroupBox
            groupBox1.Enabled = false;
        }

        //Ham kich hoat quay so
        private void StartSpin(Label lb, Button btCurrent, Button btnNext)
        {
            //Gan bao bien tam
            currentLabel = lb;
            //Vo hieu hoa nut vua bam 
            btCurrent.Enabled = false;

            // Logic cho Timer
            countTick = 0;
            timer1.Interval = 200;
            timer1.Start();

            // Luu nut bam
            timer1.Tag = btnNext;
        }

        //Click So2
        private void btSo2_Click(object sender, EventArgs e)
        {
            StartSpin(lbSo2, btSo2, btSo3);
        }

        private void btSo3_Click(object sender, EventArgs e)
        {
            StartSpin(lbSo3, btSo3, btTiepTuc);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            countTick++;
            //Nhay so ngau nhien 0 - 9
            currentLabel.Text = rand.Next(0, 10).ToString(); 

            // Tao hieu ung cham dan
            timer1.Interval += 200;

            if (countTick >= 5) 
            {
                timer1.Stop();
                Button nextBtn = (Button)timer1.Tag;
                nextBtn.Enabled = true;

                // Random den so cuoi thi tinh diem
                if (currentLabel == lbSo3)
                {
                    KiemTraKetQua();
                }
            }
        }

        //Ham kiem tra ket qua
        private void KiemTraKetQua()
        {
            int s1 = int.Parse(lbSo1.Text);
            int s2 = int.Parse(lbSo2.Text);
            int s3 = int.Parse(lbSo3.Text);
            bool win = false;

            //kiem tra dieu kien radioButton
            if (rd1.Checked && (s1 == s2 && s2 == s3)) win = true;
            else if (rd3.Checked && (s1 == s3)) win = true;
            else if (rd2.Checked && (s1 < s2 && s2 < s3)) win = true;
            else if (rd4.Checked && (s1 > s2 && s2 > s3)) win = true;

            //Win  + 10d
            if (win) diemSo += 10;
            //Thua  - 10d
            else diemSo -= 10;

            //Cap nhat diem so
            lbDiem.Text = diemSo.ToString();
        }

        //Click TiepTuc
        private void btTiepTuc_Click(object sender, EventArgs e)
        {
            SetupInitialState();
        }
    }
}
