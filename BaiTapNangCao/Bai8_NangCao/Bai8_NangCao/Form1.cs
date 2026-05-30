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

namespace Bai8_NangCao
{
    public partial class Form1 : Form
    {
        // Danh sách lưu trữ tất cả cổ phiếu đã thêm
        private List<Stock> listStocks = new List<Stock>();
        // Màu đã chọn cho cổ phiếu mới
        private Color selectedColor = Color.White;
        public class Stock
        {
            public string Name { get; set; } 
            public int Price { get; set; } 
            public Color StockColor { get; set; } 
        }
        public Form1()
        {
            InitializeComponent();
            // Gắn context menu vào DataGridView
            dgvStock.ContextMenuStrip = contextMenuStrip1;

            //Dang ki su kien ve cho Paint
            piePanel.Paint += piePanel_Paint;
            legendPanel.Paint += legendPanel_Paint;
            // Load dữ liệu mẫu ban đầu như trong đề bài
            LoadSampleData();
        }

        private void RefreshUI()
        {
            UpdateStockGrid();

            // Yêu cầu Panel vẽ lại biểu đồ tròn
            piePanel.Invalidate();
            // Yêu cầu Panel vẽ lại bảng chú thích
            legendPanel.Invalidate(); 
        }

        //Click nut Add
        private void btAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtStock.Text) && int.TryParse(txtPrice.Text, out int price))
            {
                listStocks.Add(new Stock
                {
                    Name = txtStock.Text,
                    Price = price,
                    StockColor = selectedColor == Color.White ? Color.Gray : selectedColor
                });
                txtStock.Clear();
                txtPrice.Clear();
                RefreshUI();
            }
        }
        //Load co phieu mac dinh
        private void LoadSampleData()
        {
            listStocks.AddRange(new List<Stock>(){
            new Stock{ Name = "SSI", Price = 33, StockColor = Color.FromArgb(255,100,100) },
            new Stock{ Name = "HCM", Price = 34, StockColor = Color.FromArgb(100,255,100) },
            new Stock{ Name = "MBS", Price = 19, StockColor = Color.FromArgb(100,100,255) },
            new Stock{ Name = "FPT", Price = 96, StockColor = Color.FromArgb(255,100,255) },
            new Stock{ Name = "VCB", Price = 80, StockColor = Color.FromArgb(255,255,100) },
            new Stock{ Name = "ACB", Price = 24, StockColor = Color.FromArgb(100,255,255) }
            });
            RefreshUI();
        }
        // Cập nhật dữ liệu lên DataGridView
        private void UpdateStockGrid()
        {
            dgvStock.DataSource = null;
            dgvStock.DataSource = listStocks.Select(s => new { Stock = s.Name, Price = s.Price }).ToList();
        }


        // Hàm vẽ biểu đồ tròn
        private void piePanel_Paint(object sender, PaintEventArgs e)
        {
            if (listStocks.Count == 0) return;

            Graphics g = e.Graphics;
            // Làm mượt nét vẽ
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; 

            int totalPrice = listStocks.Sum(s => s.Price);
            float startAngle = 0;

            // Hình tròn nằm giữa Panel
            Rectangle rect = new Rectangle(50, 50, 250, 250);

            foreach (var stock in listStocks)
            {
                float sweepAngle = (float)stock.Price * 360 / totalPrice;

                // Vẽ miếng bánh
                using (Brush brush = new SolidBrush(stock.StockColor))
                {
                    g.FillPie(brush, rect, startAngle, sweepAngle);
                    // Vẽ viền đen
                    g.DrawPie(Pens.Black, rect, startAngle, sweepAngle); 
                }

                // Tính toán vị trí vẽ chữ tỷ lệ % ngay trên miếng bánh
                double labelAngle = (startAngle + sweepAngle / 2) * Math.PI / 180;
                float labelX = rect.X + rect.Width / 2 + (float)Math.Cos(labelAngle) * (rect.Width / 3);
                float labelY = rect.Y + rect.Height / 2 + (float)Math.Sin(labelAngle) * (rect.Height / 3);

                float percent = (float)Math.Round((stock.Price * 100.0 / totalPrice), 2);
                g.DrawString($"{percent}%", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, labelX - 10, labelY);

                startAngle += sweepAngle;
            }
        }

        // Hàm vẽ chú thích Legend
        private void legendPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int yPos = 60;
            int totalPrice = listStocks.Sum(s => s.Price);

            g.DrawString("Legend", new Font("Arial", 24, FontStyle.Bold), Brushes.Black, 20, 10);

            foreach (var stock in listStocks)
            {
                float percent = (float)Math.Round((stock.Price * 100.0 / totalPrice), 2);

                // Vẽ ô vuông màu
                g.FillRectangle(new SolidBrush(stock.StockColor), 20, yPos, 25, 25);
                g.DrawRectangle(Pens.Black, 20, yPos, 25, 25);

                // Vẽ text thông tin
                g.DrawString($"{stock.Name} - {percent}%", new Font("Arial", 14), Brushes.Black, 55, yPos);
                yPos += 35;
            }

        }

        //Click SetColor
        private void btSetColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                selectedColor = colorDialog.Color;
            }
        }

        //Click vao remove
        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvStock.CurrentRow != null)
            {
                string name = dgvStock.CurrentRow.Cells[0].Value.ToString();
                listStocks.RemoveAll(s => s.Name == name);
                RefreshUI();
            }
        }

        //Click vao Update
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvStock.CurrentRow != null)
            {
                string name = dgvStock.CurrentRow.Cells[0].Value.ToString();
                var stock = listStocks.Find(s => s.Name == name);

                if (stock != null)
                {
                    // Khởi tạo Form con và truyền dữ liệu hiện tại sang
                    FrmUpdate fUpdate = new FrmUpdate(stock.Name, stock.Price);

                    // Hiện bảng nhỏ dưới dạng Dialog
                    if (fUpdate.ShowDialog() == DialogResult.OK)
                    {
                        // Nếu người dùng nhấn OK trên Form con, cập nhật giá trị
                        stock.Price = fUpdate.UpdatedPrice;

                        // Làm mới toàn bộ giao diện (Vẽ lại biểu đồ, Grid, Legend)
                        RefreshUI();

                        MessageBox.Show($"Cập nhật mã {name} thành công!", "Thông báo");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một cổ phiếu trong danh sách để cập nhật!");
            }
        }
        
    }
}
