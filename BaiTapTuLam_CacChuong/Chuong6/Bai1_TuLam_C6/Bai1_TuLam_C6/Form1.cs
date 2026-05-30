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
using System.Diagnostics;

namespace Bai1_TuLam_C6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Ket noi ImageList voi ListView
            lvFile.SmallImageList = imageList1;
            lvFile.LargeImageList = imageList1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Lay danh sach o dia va nap vao comboBox
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                cboDrives.Items.Add(drive.Name);
            }

            // Mac dinh chon o dia dau tien neu co
            if (cboDrives.Items.Count > 0)
                cboDrives.SelectedIndex = 0;
        }

        //Ham load thu muc len ListView 
        private void LoadData(string path)
        {

            try
            {
                //Xoa du lieu cu
                lvFile.Items.Clear(); 
                //Cap nhat duong dan hien tai
                lblPath.Text = path;    

                DirectoryInfo dir = new DirectoryInfo(path);

                // Lay danh sach cac thu muc con
                foreach (DirectoryInfo d in dir.GetDirectories())
                {
                    ListViewItem item = new ListViewItem(d.Name);
                    //Thu muc khong hien thi size
                    item.SubItems.Add(""); 
                    item.SubItems.Add(d.LastAccessTime.ToString());
                    //Index 0 la icon thu muc
                    item.ImageIndex = 0; 
                    item.Tag = d.FullName; 
                    lvFile.Items.Add(item);
                }

                // Lay danh sach cac file
                foreach (FileInfo f in dir.GetFiles())
                {
                    ListViewItem item = new ListViewItem(f.Name);
                    //Doi sang KB
                    item.SubItems.Add((f.Length / 1024).ToString() + " KB"); 
                    item.SubItems.Add(f.LastAccessTime.ToString());
                    //Index 1 la icon tap tin
                    item.ImageIndex = 1; 
                    item.Tag = f.FullName;
                    lvFile.Items.Add(item);
                }
            }
            //Xu li ngoai le
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        //Su kien khi chon o dia khac tu conboBox
        private void cboDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData(cboDrives.SelectedItem.ToString());
        }

        //Su kien Double Click len ListView
        private void lvFile_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvFile.SelectedItems.Count > 0)
            {
                string path = lvFile.SelectedItems[0].Tag.ToString();

                // Kiem tra la thu muc hay file
                if (Directory.Exists(path))
                {
                    // Neu la thu muc thi truy cap vao trong
                    LoadData(path);
                }
                else if (File.Exists(path))
                {
                    // Neu la file thuc hien mo file
                    Process.Start(new ProcessStartInfo(path) { UseShellExecute = true });
                }
            }
        }

        //Click vao LargeIcon
        private void rdLargeIcon_CheckedChanged(object sender, EventArgs e)
        {
            if (rdLargeIcon.Checked)
                lvFile.View = View.LargeIcon;
        }

        //Click vao SmallIcon
        private void rdSmallIcon_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSmallIcon.Checked)
                lvFile.View = View.SmallIcon;
        }

        //Click vao List
        private void rdList_CheckedChanged(object sender, EventArgs e)
        {
            if (rdList.Checked)
                lvFile.View = View.List;
        }

        //Click vao Detail
        private void rdDetail_CheckedChanged(object sender, EventArgs e)
        {
            if (rdDetail.Checked)
                lvFile.View = View.Details;
        }

        //Click Tile
        private void rdTile_CheckedChanged(object sender, EventArgs e)
        {
            if (rdTile.Checked)
                lvFile.View = View.Tile;
        }
    }
}
