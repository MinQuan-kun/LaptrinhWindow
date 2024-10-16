//Viết chương trình nhập vào giá trị nguyên dương N, và số thực X, tính tổng:
//S = X + X2 + X3 + X4 + ..+XN
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap2._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string N = Input1.Text;
            string X = Input2.Text;
            if(!int.TryParse(N, out int n) && n <= 0)
                MessageBox.Show("Lỗi! Vui lòng nhập một số nguyên dương hợp lệ.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if(!double.TryParse(X, out double x))
                MessageBox.Show("Lỗi! Vui lòng nhập một số thực hợp lệ.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            StringBuilder e1 = new StringBuilder();
            StringBuilder e2 = new StringBuilder(); // Sử dụng StringBuilder để xây dựng chuỗi
            StringBuilder e3 = new StringBuilder();
            for (int i = 1; i <= n; i++)
            {
                if (i == 1)
                    e1.Append("X+");
                if (i < n && i != 1)
                {
                    e1.Append("X^" + i + "+" );
                }
                if( i == n) // Nếu là số cuối cùng, chỉ thêm số
                {
                    e1.Append("X^" + i);
                }
            }
            for (int i = 1; i <= n; i++)
            {
                if (i == 1)
                    e2.Append(x + "+");
                if (i < n && i != 1)
                {
                    e2.Append(x + "^" + i + "+");
                }
                if (i == n)
                {
                    e2.Append(x + "^" + i);
                }
            }
            for (int i = 1; i <= n; i++)
            {
                if (i == 1)
                    e3.Append(x + "+");
                if (i < n && i != 1)
                    e3.Append(Math.Pow(x, i) + "+");
                if (i == n)
                    e3.Append(Math.Pow(x, n));
            }
            double S = 0;
            for(int i = 1; i <= n; i++)
                S += Math.Pow(x, i);
            BoxXmu.Text = e1.ToString(); // Hiển thị chuỗi và tổng
            BoxNmu.Text = e2.ToString();
            Boxresk.Text = e3.ToString();
            Boxres.Text = S.ToString();
        }
    }
}
