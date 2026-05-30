using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai2_TuLam_C7
{
    public partial class FrmOption : Form
    {
        public ShapeType SelectedType { get; set; }

        public Color SelectedColor { get; set; }

        public FrmOption(ShapeType type, Color color)
        {
            InitializeComponent();

            SelectedType = type;

            SelectedColor = color;

            pnColor.BackColor = color;

            if (type == ShapeType.Rectangle)
                rdRectangle.Checked = true;

            else if (type == ShapeType.Ellipse)
                rdEllipse.Checked = true;

            else
                rdTriangle.Checked = true;
        }

        private void pnColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    SelectedColor = cd.Color;

                    pnColor.BackColor = cd.Color;
                }
            }
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (rdRectangle.Checked)
            {
                SelectedType = ShapeType.Rectangle;
            }

            else if (rdEllipse.Checked)
            {
                SelectedType = ShapeType.Ellipse;
            }

            else
            {
                SelectedType = ShapeType.Triangle;
            }

            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}