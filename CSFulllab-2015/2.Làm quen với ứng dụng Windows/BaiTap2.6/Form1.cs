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

namespace BaiTap2._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string n1 = Input1.Text;
            string n2 = Input2.Text;
            double res = 0;
            var culture = CultureInfo.InvariantCulture.Clone() as CultureInfo;
            culture.NumberFormat.NumberDecimalSeparator = ","; // Sử dụng dấu phẩy
            culture.NumberFormat.NumberGroupSeparator = ".";   // Sử dụng dấu chấm nếu có
            if (!double.TryParse(n1, NumberStyles.Any, culture, out double result1))
            {
                culture.NumberFormat.NumberDecimalSeparator = ".";
                if (!double.TryParse(n1, NumberStyles.Any, culture, out result1))
                {
                    MessageBox.Show("Lỗi! Vui lòng nhập một số thực hợp lệ.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if(!double.TryParse(n2, NumberStyles.Any, culture, out double result2))
            {
                culture.NumberFormat.NumberDecimalSeparator = ".";
                if (!double.TryParse(n2, NumberStyles.Any, culture, out result2))
                {
                    MessageBox.Show("Lỗi! Vui lòng nhập một số thực hợp lệ.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (Cong.Checked == true)
                res = result1 + result2;
            else if (Tru.Checked == true)
                res = result1 - result2;
            else if (Nhan.Checked == true)
                res = result1 * result2;
            else if (Chia.Checked == true)
            {
                if (result2 == 0)
                {
                    MessageBox.Show("Lỗi! Không thể chia cho 0.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                res = result1 / result2;
            }
            // Display the result
            Tong.Text = res.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
           DialogResult result = MessageBox.Show(
               "Bạn có chắc chắn thoát", 
               "Confirm",
               MessageBoxButtons.YesNo, 
               MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Cong.Checked = true;
        }
    }
}
