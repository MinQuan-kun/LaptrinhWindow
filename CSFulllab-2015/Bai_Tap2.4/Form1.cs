//Viết chương trình nhập vào giá trị nguyên dương N, tính tổng
//S = 1 + 2 + 3 + ...+N
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap2._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string Tx = Input.Text;
            int n = 0;
            if(int.TryParse(Tx, out n) &&  n > 0)
            {
                n = int.Parse(Tx);
            }
            else
            {
                MessageBox.Show("Lỗi! Vui lòng nhập một giá trị nguyên dương, hợp lệ.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            long s = 0;
            for (int i = 0; i <= n; i++)
            {
                s += i;
            }
            s = 0;
            StringBuilder equation = new StringBuilder(); // Sử dụng StringBuilder để xây dựng chuỗi

            for (int i = 1; i <= n; i++)
            {
                s += i;

                // Nếu không phải là số cuối cùng, thêm dấu cộng
                if (i < n)
                {
                    equation.Append(i + "+");
                }
                else // Nếu là số cuối cùng, chỉ thêm số
                {
                    equation.Append(i);
                }
            }
            Output1.Text = equation.ToString(); // Hiển thị chuỗi và tổng
            Output2.Text = s.ToString();
        }
    }
}
