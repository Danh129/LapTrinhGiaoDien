using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Bai8_NangCao
{
    public partial class FrmUpdate : Form
    {
        public int UpdatedPrice { get; set; }
        public FrmUpdate(string name, int currentPrice)
        {
            InitializeComponent();
            this.Text = "Update";
            txtUpName.Text = name;
            txtUpPrice.Text = currentPrice.ToString();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtUpPrice.Text, out int price) && price > 0)
            {
                UpdatedPrice = price;
                this.DialogResult = DialogResult.OK; 
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập giá hợp lệ!", "Lỗi");
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
