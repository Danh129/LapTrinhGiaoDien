using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5_TuLam_C2
{
    public partial class Form1 : Form
    {
        int[] numbers;
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        //Kiem tra nguyen to
        private bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
        private void btThongKe_Click(object sender, EventArgs e)
        {
            if (numbers == null)
            {
                MessageBox.Show("Hãy tạo mảng trước khi thống kê!");
                return;
            }

            //Tong chan
            int sumEven = 0;      
            //Tong le
            int sumOdd = 0;       
            //Dem so nguyen to
            int countPrime = 0;   
            //Trung binh cong
            double average = 0;   

            foreach (int x in numbers)
            {
                //Tinh tong chan/le
                if (x % 2 == 0) sumEven += x;
                else sumOdd += x;

                // Dem so nguyen to
                if (IsPrime(x)) countPrime++;
            }

            // Tinh trung binh cong
            average = numbers.Average();

            // Ket qua
            lbKetQua.Text = $"Tổng chẵn: {sumEven}\n" +
                             $"Tổng lẻ: {sumOdd}\n" +
                             $"Trung bình cộng: {Math.Round(average, 2)}\n" +
                             $"Số lượng số nguyên tố: {countPrime}";
        }

        //Click Tao Mang
        private void btTaoMang_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNhap.Text, out int n) && n > 0)
            {
                numbers = new int[n];
                string display = "Mảng: ";

                for (int i = 0; i < n; i++)
                {
                    //Sinh so ngau nhien 1 - 99
                    numbers[i] = rand.Next(1, 100); 
                    display += numbers[i] + " ";
                }

                //Hien thi mang ban dau
                lbHienThi.Text = display; 
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số lượng phần tử hợp lệ!");
            }
        }
    }
}
