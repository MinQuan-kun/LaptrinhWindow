/*****************************************************************************
Nhập vào một số nguyên từ 0 đến 9, hiển thị bằng “chữ” các ký số trên, ví dụ:
- Nhập 1  “Một”
- Nhập 2  “Hai”
- Nhập 3  “Ba”
- ..
- Nhập 9  “Chín”
*****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitap03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Output_TextChanged(object sender, EventArgs e)
        {
            string text = Input.Text;
            switch (text)
            {
                case "1":
                    Output.Text = "Một";
                    break;
                case "2":
                    Output.Text = "Hai";
                    break;
                case "3":
                    Output.Text = "Ba";
                    break;
                case "4":
                    Output.Text = "Bốn";
                    break;
                case "5":
                    Output.Text = "Năm";
                    break;
                case "6":
                    Output.Text = "Sáu";
                    break;
                case "7":
                    Output.Text = "Bảy";
                    break;
                case "8":
                    Output.Text = "Tám";
                    break;
                case "9":
                    Output.Text = "Chín";
                    break;
                default:
                    MessageBox.Show("Lỗi! Vui lòng nhập một số nguyên hợp lệ vào ô.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
                
        }
    }
}
