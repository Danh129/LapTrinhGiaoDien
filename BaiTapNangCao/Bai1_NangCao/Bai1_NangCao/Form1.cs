using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1_NangCao
{
    public partial class Form1 : Form
    {
        //Danh sách chứa các ảnh
        List<Image> icons = new List<Image>();
        //Lưu ô đầu
        PictureBox firstClicked = null;
        //Lưu ô thứ 2
        PictureBox secondClicked = null;

        // Timer dùng để úp hình lại khi chọn sai
        Timer gameTimer = new Timer();

        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            gameTimer.Interval = 750;
            // Gán sự kiện Tick cho timer
            gameTimer.Tick += gameTimer_Tick;

            LoadImagesFromFolder();
            AssignIconsToSquares();
        }

        //Load hinh từ ảnh
        private void LoadImagesFromFolder()
        {
            string path = Path.Combine(Application.StartupPath, "img");

            //kiểm tra thư mục tồn tại hay không
            if (Directory.Exists(path))
            {
                string[] files = Directory.GetFiles(path)
                    .Where(f => 
                    f.EndsWith(".jpg") ||
                    f.EndsWith(".gif") ||
                    f.EndsWith(".bmp")).ToArray();

                //Chỉ lấy 8 ảnh
                for (int i = 0; i < 8 && i < files.Length; i++)
                {
                    //Đọc file thành mảng byte
                    byte[] bytes = File.ReadAllBytes(files[i]);
                    //Tạo Memory stream
                    MemoryStream ms = new MemoryStream(bytes);
                    //chuyen thanh Image
                    Image img = Image.FromStream(ms);

                    //Add 2 lan de tao 2 hinh giong nhau
                    icons.Add(img); 
                    icons.Add(img); 
                }
            }

        }

        //Gan hinh cho picture box
        private void AssignIconsToSquares()
        {
            //Lap tu pic0 - pic15
            for (int i = 0; i < 16; i++)
            {
                //Het thi dung
                if (icons.Count == 0)
                    return;

                // Tìm PictureBox trong tableLayoutPanel
                PictureBox pic = tableLayoutPanel1.Controls["pic" + i] as PictureBox;

                if (pic == null)
                {
                    MessageBox.Show("Không tìm thấy pic" + i);
                    continue;
                }

                int index = random.Next(icons.Count);
                // Lưu hình thật vào Tag
                pic.Tag = icons[index];
                // Ban đầu ẩn hình
                pic.Image = null;

                pic.SizeMode = PictureBoxSizeMode.StretchImage;

                pic.BackColor = Color.LightSeaGreen;

                pic.BorderStyle = BorderStyle.FixedSingle;
                //Gan su kien Click
                pic.Click += pictureBox_Click;
                //Xoa hinh da dung khoi danh sach
                icons.RemoveAt(index);
            }

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            //neu timer dang chay thi khong cho Click 
            if (gameTimer.Enabled == true)
                return;
            //Ep sender thanh picture box
            PictureBox clickedPicture = sender as PictureBox;

            if (clickedPicture == null)
                return;

            // Neu da mo thi bo qua
            if (clickedPicture.Image != null)
                return;

            // Hiện hình
            clickedPicture.Image = (Image)clickedPicture.Tag;

            // Chọn hình đầu tiên
            if (firstClicked == null)
            {
                firstClicked = clickedPicture;
                return;
            }

            // Chọn hình thứ hai
            secondClicked = clickedPicture;

            // Nếu giống nhau
            if (firstClicked.Tag == secondClicked.Tag)
            {
                firstClicked = null;
                secondClicked = null;

                CheckWin();

                return;
            }
            // Nếu khác nhau -> đợi úp
            gameTimer.Start();

        }

        // KIỂM TRA THẮNG
        private void CheckWin()
        {
            //Duyet qua tat ca picture box
            foreach (PictureBox pic in tableLayoutPanel1.Controls.OfType<PictureBox>())
            {
                if (pic.Image == null)
                    return;
            }
            //In cau thong bao
            MessageBox.Show("Hoàn thành trò chơi!");
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            gameTimer.Stop();
            //up lai 2 hinh
            firstClicked.Image = null;
            secondClicked.Image = null;

            //Reset lua chon
            firstClicked = null;
            secondClicked = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
