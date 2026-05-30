using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_TuLam_C7
{
    public enum ShapeType 
    { 
        Rectangle, 
        Ellipse, 
        Triangle 
    }
    internal class MyShapes
    {
        public Rectangle Bounds { get; set; } // Khung của hình
        public Color FillColor { get; set; } // Màu sắc
        public ShapeType Type { get; set; }  // Loại hình
    } 
}
