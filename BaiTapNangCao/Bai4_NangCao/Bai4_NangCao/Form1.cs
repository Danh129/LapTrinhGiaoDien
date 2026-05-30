using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4_NangCao
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        int count = 0;
        int max = 0;
        public Form1()
        {
            InitializeComponent();
        }

        //Click Quay So
        private void btQuaySo_Click(object sender, EventArgs e)
        {
            count = 0;
            max = rand.Next(20, 30);

            timer1.Interval = 100;
            timer1.Start();

        }

        //Toc do giam dan cho den khi dung
        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;

            //Hien thi hinh ngau nhien
            int index = rand.Next(0, imageList1.Images.Count);
            picAnh.Image = imageList1.Images[index];
            picAnh.Tag = index;

            //Toc do cham dan
            timer1.Interval += 15;

            //Chay du hinh thi no dung
            if (count >= max)
            {
                timer1.Stop();
                XuLiKQ();

            }
        }

        //Ham xu li KETQUA
        private void XuLiKQ()
        {
            int indexSelected = (int)picAnh.Tag;

            //Quay o MAT QUYEN QUAY SO
            if (indexSelected == 1)
            {
                btQuaySo.Enabled = false; // Vô hiệu hóa nút Quay số
                MessageBox.Show("Rất tiếc! Bạn đã quay trúng ô: Mất quyền quay số.", "Thông báo");
            }
            //Quay o CHUC BAN MAY MAN LAN SAU
            else if (indexSelected == 0)
            {
                MessageBox.Show("Chúc may mắn lần sau!", "Kết quả");
            }
            //Hinh duoc tang qua
            else
            {
                // Tao picture box con de chua anh
                PictureBox picQua = new PictureBox();
                picQua.Size = new Size(80, 80);           
                picQua.SizeMode = PictureBoxSizeMode.Zoom;
                picQua.Image = imageList1.Images[indexSelected];

                // Them vao gio qua
                flpGioQua.Controls.Add(picQua);

                MessageBox.Show("Chúc mừng! Bạn nhận được một phần quà.", "Trúng thưởng");
            }
        }
        //Click choi lai
        private void btChoiLai_Click(object sender, EventArgs e)
        {
            //Quay so dc kich hoat lai
            btQuaySo.Enabled = true;

            //Xoa het cac qua trong Gio Qua
            flpGioQua.Controls.Clear();

            //Reset anh ve mac dinh
            picAnh.Image = null;
        }

        //Click Dong
        private void btDong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
