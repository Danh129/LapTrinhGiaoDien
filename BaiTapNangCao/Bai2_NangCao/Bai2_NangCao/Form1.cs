using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2_NangCao
{
    public partial class Form1 : Form
    {
        //Duong dan chua anh
        string path = Path.Combine(Application.StartupPath, "Images");

        public Form1()
        {
            InitializeComponent();
            //Dam bao Images ton tai
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadImagesList();
        }

        //Danh sach file lay tu Images ung dung hien thi tren ListBox
        private void LoadImagesList()
        {
            ListImage.Items.Clear();
            DirectoryInfo d = new DirectoryInfo(path);

            //Lay dinh dang anh pho bien
            FileInfo[] Files = d.GetFiles();
            foreach (FileInfo file in Files)
            {
                if (IsImageFile(file.Extension))
                    ListImage.Items.Add(file.Name);
            }
        }

        //kiem tra duoi file
        private bool IsImageFile(string ext)
        {
            string[] formats = { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };
            return Array.Exists(formats, x => x.Equals(ext.ToLower()));
        }

        //Su kien chon 1 dong list box
        private void ListImage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListImage.SelectedItems != null)
            {
                string fullPath = Path.Combine(path, ListImage.SelectedItem.ToString());


                //Phuong thuc nay tranh file bi khoa khi can xoa
                using (FileStream fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                {
                    picDisplay.Image = Image.FromStream(fs);
                }
            }
        }

        //Su kien checkBox
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPlay.Checked)
            {
                timer1.Start();
                //Vo hieu hoa 2 nut Add va Remove
                btAdd.Enabled = false;
                btRemove.Enabled = false;
            }
            else
            {
                timer1.Stop();
                //HET vo hieu hoa 2 nut Add va Remove
                btAdd.Enabled = true;
                btRemove.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(ListImage.Items.Count > 0)
            {
                //Tu dong nhay dong tiep theo
                int nextIndex = ListImage.SelectedIndex + 1;
                if (nextIndex >= ListImage.Items.Count) nextIndex = 0;
                ListImage.SelectedIndex = nextIndex;
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            //1 file anh moi vao danh sach
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            //Neu anh duoc chon se sap chep vao Images cua Project
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string destFile = Path.Combine(path, Path.GetFileName(ofd.FileName));
                try
                {
                    File.Copy(ofd.FileName, destFile, true);
                    //Cap nhat lai danh sach
                    LoadImagesList();
                    MessageBox.Show("Them anh thanh cong!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi: " + ex.Message);
                }
            }
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            if (ListImage.SelectedItem != null)
            {
                string fileName = ListImage.SelectedItem.ToString();
                string fullPath = Path.Combine(path, fileName);

                DialogResult dr = MessageBox.Show("Ban co chac xoa anh nay khong?", "Xac nhan", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    picDisplay.Image.Dispose(); 
                    picDisplay.Image = null;
                    File.Delete(fullPath);
                    LoadImagesList();
                }
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
