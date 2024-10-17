//Viết chương trình nhập vào giá trị nguyên dương N, và số thực X, tính tổng:
//S = X + X2 + X3 + X4 + ..+XN
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

            // Thiết lập văn hóa cho số thập phân, để chấp nhận dấu phẩy và dấu chấm
            var culture = CultureInfo.InvariantCulture.Clone() as CultureInfo;
            culture.NumberFormat.NumberDecimalSeparator = ","; // Sử dụng dấu phẩy
            culture.NumberFormat.NumberGroupSeparator = ".";   // Sử dụng dấu chấm nếu có

            if (!int.TryParse(N, out int n) || n < 0)
            {
                MessageBox.Show("Lỗi! Vui lòng nhập một số nguyên dương hợp lệ, n > 0.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cố gắng parse giá trị X với cả dấu phẩy và dấu chấm
            if (!double.TryParse(X, NumberStyles.Any, culture, out double x))
            {
                // Nếu không thành công với dấu phẩy, thử lại với dấu chấm
                culture.NumberFormat.NumberDecimalSeparator = ".";
                if (!double.TryParse(X, NumberStyles.Any, culture, out x))
                {
                    MessageBox.Show("Lỗi! Vui lòng nhập một số thực hợp lệ.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            // Sử dụng StringBuilder để xây dựng chuỗi
            StringBuilder e1 = new StringBuilder();
            StringBuilder e2 = new StringBuilder(); 
            StringBuilder e3 = new StringBuilder();
            for (int i = 1; i <= n; i++)
            {
                if (x < 0)
                {
                    if (i == 1 && n != 1)
                    {
                        e1.Append("X+");
                        e2.Append("(" + x + ")" + "+");
                        e3.Append("(" + x + ")" + "+");
                    }
                    else if (i < n && i > 1)
                    {
                        e2.Append("(" + x + ")^" + i + "+");
                        if(Math.Pow(x, i) < 0)
                            e3.Append("(" + Math.Pow(x, i) + ")" + "+");
                        else
                            e3.Append(Math.Pow(x, i) + "+");
                    }
                    else if (i == n && n != 1)
                    {
                        e2.Append("(" + x + ")^" + i);
                        if (Math.Pow(x, n) < 0)
                            e3.Append("(" + Math.Pow(x, n) + ")");
                        else
                            e3.Append(Math.Pow(x, n));
                    }
                }
                else
                {
                    if (i == 1 && n != 1)
                    {
                        e1.Append("X+");
                        e2.Append(x + "+");
                        e3.Append(x + "+");
                    }
                    if (i < n && i > 1)
                    {
                        e2.Append(x + "^" + i + "+");
                        e3.Append(Math.Pow(x, i) + "+");
                    }
                    else if (i == n && n != 1)
                    {
                        e2.Append(x + "^" + i);
                        e3.Append(Math.Pow(x, n));
                    }
                        
                }

                if (i == 1 && n == 1)
                {
                    e1.Append("X");
                    e2.Append(x);
                    e3.Append(x);
                }
                else if (i < n && i > 1)
                    e1.Append("X^" + i + "+");
                else if (i == n && n != 1)
                    e1.Append("X^" + i);
            }
            double S = 0;
            for(int i = 1; i <= n; i++)
                S += Math.Pow(x, i);
            BoxXmu.Text = e1.ToString(); // Hiển thị chuỗi và tổng
            BoxNmu.Text = e2.ToString();
            Boxresk.Text = e3.ToString();
            if(n == 0 && x == 0)
                Boxres.Text = "Không xác định";
            else if (n == 0)
                Boxres.Text = "1";
            else
                Boxres.Text = S.ToString();
            
        }
    }
}
