using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Baitap1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            string text = txtN.Text;
            int n = 0;
            try
            {
                n = int.Parse(text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Lỗi! Vui lòng nhập một số nguyên hợp lệ.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;  // Thoát khỏi sự kiện nếu có lỗi
            }
            long s = 0;
            for (int i = 0; i  <= n; i++)
            {
                s += i;
            }

            txtNTong.Text = s.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
