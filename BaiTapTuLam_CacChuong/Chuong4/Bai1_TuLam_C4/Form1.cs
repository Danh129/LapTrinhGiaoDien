namespace QuaySo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string pathImg;
        int diem = 0;
        Random rand = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbChay.Text = lbChay.Text.Substring(1) + lbChay.Text.Substring(0, 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnQuay_Click(object sender, EventArgs e)
        {
            pathImg = Application.StartupPath + @"\XucXac\";
            int so1 = rand.Next(1, 7);
            int so2 = rand.Next(1, 7);
            int so3 = rand.Next(1, 7);
            int kq = so1 + so2 + so3;
            pic1.Image = Image.FromFile(pathImg + so1.ToString() + ".jpg");
            pic2.Image = Image.FromFile(pathImg + so2.ToString() + ".jpg");
            pic3.Image = Image.FromFile(pathImg + so3.ToString() + ".jpg");
            lbResult.Text = kq.ToString();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Ban muon dong ung dung?", "Canh bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
