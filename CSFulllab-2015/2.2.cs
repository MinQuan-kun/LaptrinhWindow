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

namespace BaiTap02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void FindNum_Click(object sender, EventArgs e)
        {
            string text1 = textBox1.Text;
            string text2 = textBox2.Text;
            string text3 = textBox3.Text;
            int num1 = int.Parse(text1);
            int num2 = int.Parse(text2);
            int num3 = int.Parse(text3);
            int Max = num1;
            if(Max < num2)
                Max = num2;
            if(Max < num3)
                Max = num3;
            int Min = num1;
            if(Min > num2)
                Min = num2;
            if(Min > num3)
                Min = num3;
            MaxNum.Text = Max.ToString();
            MinNum.Text = Min.ToString();
        }
    }
}
