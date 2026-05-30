using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C4_bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxMau.Items.Add("Red");
            comboBoxMau.Items.Add("Blue");
            comboBoxMau.Items.Add("Yellow");
            comboBoxMau.Items.Add("Cyan");
            comboBoxMau.Items.Add("Green");
            comboBoxMau.SelectedIndex = 0;

        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            if (txtChuoi.Text == "") return;
            listBoxTrai.Items.Add(txtChuoi.Text);
            txtChuoi.Text = "";
            txtChuoi.Focus();
        }

        private void btTraiSangPhai_Click(object sender, EventArgs e)
        {
            if (listBoxTrai.SelectedItems == null) return;   
            List<object> ds = new List<object>();

            foreach (object item in listBoxTrai.SelectedItems)
                ds.Add(item);
            foreach (object item in ds)
                listBoxPhai.Items.Add(item);
        }

        private void btPhaiSangTrai_Click(object sender, EventArgs e)
        {
            if( listBoxPhai.SelectedItem == null) return;

            object item = listBoxPhai.SelectedItem;
            listBoxTrai .Items.Add(item);
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            List<object> ds = new List<object>();
            foreach (object item in listBoxTrai.SelectedItems)
                ds.Add(item);
            foreach (object x in ds)
                   listBoxTrai.Items.Remove(x);
            listBoxPhai.Items.Remove(listBoxPhai.SelectedItem);
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            listBoxTrai.Items.Clear();
            listBoxPhai.Items.Clear();
        }

        private void comboBoxMau_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mau = comboBoxMau.Text;
            listBoxPhai.BackColor = Color.FromName(mau);
        }
    }
}
