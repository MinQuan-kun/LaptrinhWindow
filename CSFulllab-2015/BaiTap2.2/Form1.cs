//Viết chương trình nhập vào 3 số a, b và c, cho biết số lớn nhất và nhỏ nhất trong 3 số a,b,c với giao diện như sau
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace BaiTap02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Đặt màu nền cho Form
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
      
            

            // Thay đổi thuộc tính Label và Button
            FindNum.BackColor = System.Drawing.Color.LightBlue; // Màu nền nút
            FindNum.Size = new Size(100, 35); // Kích thước nút
        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void FindNum_Click(object sender, EventArgs e)
        {
            string text1 = textBox1.Text;
            string text2 = textBox2.Text;
            string text3 = textBox3.Text;
            int num1 = 0, num2 = 0, num3 = 0;

            // Kiểm tra và chuyển đổi giá trị từ textBox1
            try
            {
                num1 = int.Parse(text1);
            }
            catch (FormatException)
            {
                MessageBox.Show("Lỗi! Vui lòng nhập một số nguyên hợp lệ vào ô số 1.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;  // Thoát khỏi sự kiện nếu có lỗi
            }

            // Kiểm tra và chuyển đổi giá trị từ textBox2
            try
            {
                num2 = int.Parse(text2);
            }
            catch (FormatException)
            {
                MessageBox.Show("Lỗi! Vui lòng nhập một số nguyên hợp lệ vào ô số 2.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;  // Thoát khỏi sự kiện nếu có lỗi
            }

            // Kiểm tra và chuyển đổi giá trị từ textBox3
            try
            {
                num3 = int.Parse(text3);
            }
            catch (FormatException)
            {
                MessageBox.Show("Lỗi! Vui lòng nhập một số nguyên hợp lệ vào ô số 3.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;  // Thoát khỏi sự kiện nếu có lỗi
            }

            // Tìm số lớn nhất và nhỏ nhất
            int Max = num1;
            if (Max < num2)
                Max = num2;
            if (Max < num3)
                Max = num3;

            int Min = num1;
            if (Min > num2)
                Min = num2;
            if (Min > num3)
                Min = num3;

            // Hiển thị kết quả
            MaxNum.Text = Max.ToString();
            MinNum.Text = Min.ToString();
        }
    }
}
