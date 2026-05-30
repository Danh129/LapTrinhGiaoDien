using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Bai2_TuLam_C7
{
    public partial class Form1 : Form
    {
        List<MyShapes> shapes = new List<MyShapes>();

        ShapeType currentType = ShapeType.Rectangle;

        Color currentColor = Color.Red;

        Point startPoint;

        public Form1()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            // GẮN EVENT BẰNG CODE
            this.MouseDown += Form1_MouseDown;
            this.MouseUp += Form1_MouseUp;

            // QUAN TRỌNG
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = e.Location;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            int x = Math.Min(startPoint.X, e.X);

            int y = Math.Min(startPoint.Y, e.Y);

            int width = Math.Abs(startPoint.X - e.X);

            int height = Math.Abs(startPoint.Y - e.Y);

            if (width == 0 || height == 0)
                return;

            MyShapes s = new MyShapes();

            s.Bounds = new Rectangle(x, y, width, height);

            s.FillColor = currentColor;

            s.Type = currentType;

            shapes.Add(s);

            // BẮT FORM VẼ LẠI
            this.Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;

            foreach (MyShapes s in shapes)
            {
                SolidBrush br = new SolidBrush(s.FillColor);

                if (s.Type == ShapeType.Rectangle)
                {
                    g.FillRectangle(br, s.Bounds);
                }
                else if (s.Type == ShapeType.Ellipse)
                {
                    g.FillEllipse(br, s.Bounds);
                }
                else
                {
                    Point[] pts =
                    {
                        new Point(s.Bounds.X + s.Bounds.Width / 2, s.Bounds.Y),
                        new Point(s.Bounds.X, s.Bounds.Bottom),
                        new Point(s.Bounds.Right, s.Bounds.Bottom)
                    };

                    g.FillPolygon(br, pts);
                }
            }
        }

        private void menuClear_Click(object sender, EventArgs e)
        {
            shapes.Clear();

            this.Refresh();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuOption_Click(object sender, EventArgs e)
        {
            FrmOption f = new FrmOption(currentType, currentColor);

            if (f.ShowDialog() == DialogResult.OK)
            {
                currentType = f.SelectedType;

                currentColor = f.SelectedColor;
            }
        }
    }
}