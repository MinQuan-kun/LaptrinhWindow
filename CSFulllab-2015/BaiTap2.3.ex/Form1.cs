using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap2._3.ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Output_TextChanged(object sender, EventArgs e)
        {
            // Lấy chuỗi đầu vào
            string inputText = Input.Text;

            // Kiểm tra xem chuỗi có phải là số nguyên dương không
            if (long.TryParse(inputText, out long number) && number >= 0 && number <= 999999999999)
            {
                Output.Text = NumberToWords(number);
            }
            else
            {
                MessageBox.Show("Lỗi! Vui lòng nhập một số nguyên dương hợp lệ.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hàm chuyển đổi số thành chữ
        private string NumberToWords(long number)
        {
            if (number == 0) return "Không";

            string[] units = { "", "nghìn", "triệu", "tỷ" };
            string[] tens = { "", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] hundreds = { "", "trăm", "mươi" };

            string words = "";
            int unitIndex = 0;

            while (number > 0)
            {
                long part = number % 1000; // Lấy 3 chữ số cuối
                if (part > 0)
                {
                    string partWords = ConvertPartToWords(part, tens, hundreds);
                    words = partWords + (unitIndex > 0 ? " " + units[unitIndex] : "") + " " + words;
                }
                number /= 1000;
                unitIndex++;
            }

            return words.Trim();
        }

        // Hàm chuyển đổi từng phần 3 chữ số thành chữ
        private string ConvertPartToWords(long part, string[] tens, string[] hundreds)
        {
            string words = "";

            int hundred = (int)(part / 100);
            int ten = (int)((part % 100) / 10);
            int one = (int)(part % 10);

            // Nếu có chữ số trăm
            if (hundred > 0)
            {
                words += tens[hundred] + " " + hundreds[1] + " "; // "trăm"
            }

            // Nếu có chữ số mươi
            if (ten > 0)
            {
                if (ten == 1 && one > 0)
                {
                    words += "mười " + tens[one] + " "; // "mười một", "mười hai", ...
                }
                else if (ten > 1) // Nếu hàng chục lớn hơn 1
                {
                    words += tens[ten] + " " + hundreds[2] + " "; // "mươi"
                    if (one > 0)
                    {
                        words += tens[one] + " "; // Thêm chữ số đơn vị nếu có
                    }
                }
            }
            else if (one > 0) // Nếu không có chữ số mươi mà có chữ số đơn vị
            {
                words += tens[one] + " "; // Thêm chữ số
            }

            // Trim để loại bỏ khoảng trắng thừa
            return words.Trim();
        }
    }
}
