using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap4
{
    public partial class frmXuat : Form
    {
        const int KhoangCachLe = 10;
        const int KhoangCachButton = 10;
        const int Rong = 60;
        const int Cao = 60;
        public frmXuat(int soDong = 1, int soCot = 1)
        {
            InitializeComponent();
            //Sinh động
            Button  button;
            int temp = 0;
            for(int i = 0; i < soDong; i++)
            {
                for(int j = 0; j < soCot; j++)
                {
                    button = new Button();
                    button.Left = KhoangCachLe + (KhoangCachLe + Rong) * j;
                    button.Top = KhoangCachLe + (KhoangCachLe + Rong) * i;
                    button.Height = Cao;
                    button.Width = Rong;
                    button.Text = $"{temp}";
                    temp++;
                    // Gắn sự kiện
                    button.Click += ClickButton;
                    //Thêm button vô From
                    this.Controls.Add(button);
                }    
            }
            this.ClientSize = new System.Drawing.Size(
                KhoangCachLe + (KhoangCachButton + Rong) * soCot,
                KhoangCachLe + (KhoangCachButton + Cao) * soDong
                );
        }
        protected void ClickButton(object sender, EventArgs e)
        {
            MessageBox.Show("Nội dung: " + (sender as Button).Text);
        }
    }
}
