using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai7_NangCao
{
    public partial class Form1 : Form
    {
        // Random toc do
        Random rd = new Random();

        // Thoi gian
        double tgRua = 0;
        double tgTho = 0;
        double tgCho = 0;

        //Ktra con vat da ve dich hay chua
        bool ruaFinish = false;
        bool thoFinish = false;
        bool choFinish = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btChuanBi_Click(object sender, EventArgs e)
        {
            //reset trang thai ve dich
            ruaFinish = false;
            thoFinish = false;
            choFinish = false;

            // Dua cac con vat ve ben trai
            picRua.Left = 0;
            picTho.Left = 0;
            picCho.Left = 0;

            // Reset thoi gian
            tgRua = 0;
            tgTho = 0;
            tgCho = 0;

            lbRua.Text = "0.0";
            lbTho.Text = "0.0";
            lbCho.Text = "0.0";

            // Xoa ket qua
            lbKetQua.Text = "";

            // Khoa nut chuan bi
            btChuanBi.Enabled = false;

            // Mo nut chay
            btChay.Enabled = true;
        }

        private void btChay_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //// Tang toc ngau nhien
            //int buaRua = rd.Next(5, 20);
            //int buaTho = rd.Next(5, 20);
            //int buaCho = rd.Next(5, 20);

            //// Di chuyen
            //picRua.Left += buaRua;
            //picTho.Left += buaTho;
            //picCho.Left += buaCho;

            //// Tang thoi gian
            //tgRua += 0.1;
            //tgTho += 0.1;
            //tgCho += 0.1;

            //// Hien thoi gian
            //lbRua.Text = tgRua.ToString("0.0");
            //lbTho.Text = tgTho.ToString("0.0");
            //lbCho.Text = tgCho.ToString("0.0");

            //// Kiem tra rua ve dich
            //if (picRua.Right >= panelRua.Width)
            //{
            //    KetThuc("Rua thang!");
            //}

            //// Kiem tra tho ve dich
            //if (picTho.Right >= panelTho.Width)
            //{
            //    KetThuc("Tho thang!");
            //}

            //// Kiem tra cho ve dich
            //if (picCho.Right >= panelCho.Width)
            //{
            //    KetThuc("Cho thang!");
            //}

            // Random toc do
            int buaRua = rd.Next(5, 20);
            int buaTho = rd.Next(5, 20);
            int buaCho = rd.Next(5, 20);

            
            // RUA
            if (!ruaFinish)
            {
                picRua.Left += buaRua;
                //Tang thoi gian
                tgRua += 0.1;

                lbRua.Text = tgRua.ToString("0.0");

                // Kiem tra ve dich
                if (picRua.Right >= panelRua.Width)
                {
                    ruaFinish = true;
                }
            }

            // THO
            if (!thoFinish)
            {
                picTho.Left += buaTho;
                //Tang thoi gian
                tgTho += 0.1;

                lbTho.Text = tgTho.ToString("0.0");

                // Kiem tra ve dich
                if (picTho.Right >= panelTho.Width)
                {
                    thoFinish = true;
                }
            }

            // CHO
            if (!choFinish)
            {
                picCho.Left += buaCho;
                //Tang thoi gian
                tgCho += 0.1;

                lbCho.Text = tgCho.ToString("0.0");

                // Kiem tra ve dich
                if (picCho.Right >= panelCho.Width)
                {
                    choFinish = true;
                }
            }

            // KET THUC
            if (ruaFinish && thoFinish && choFinish)
            {
                timer1.Stop();

                // Tim thoi gian nho nhat
                double min = Math.Min(tgRua,
                             Math.Min(tgTho, tgCho));

                // Hien ket qua lay thoi gian con co thoi gian nho nhat
                if (min == tgRua)
                {
                    lbKetQua.Text = "Rua thang!";
                }
                else if (min == tgTho)
                {
                    lbKetQua.Text = "Tho thang!";
                }
                else
                {
                    lbKetQua.Text = "Cho thang!";
                }
                //Mo lai nut chuan bi
                btChuanBi.Enabled = true;
                //khoa nut chay
                btChay.Enabled = false;
            }
        }
        //private void KetThuc(string kq)
        //{
        //    // Dung timer
        //    timer1.Stop();

        //    // Hien ket qua
        //    lbKetQua.Text = kq;

        //    // Khoa nut chay
        //    btChay.Enabled = false;

        //    // Mo nut chuan bi
        //    btChuanBi.Enabled = true;
        //}
    }
}
