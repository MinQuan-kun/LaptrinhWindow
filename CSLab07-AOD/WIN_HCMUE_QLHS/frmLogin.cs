using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WIN_HCMUE_QLHS
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Xử lý đăng nhập
            //B1: Lấy dữ liệu từ input
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            
            if (username == "" || password == "")
            {
                MessageBox.Show("Vui lòng điền thông tin", "Thông báo", MessageBoxButtons.OKCancel);
                return;
            }
            else
            {
                //Sau này đọc csdl tài khoản
                if(username == "admin" && password == "123")
                {
                    MessageBox.Show("Xin chào admin", "Thông báo", MessageBoxButtons.OK);
                    //Do something continue..
                    //Goto main form
                    //this.Hide();
                    //frmMain frm = new frmMain("Admin");
                    //frm.ShowDialog();
                    //this.Show();
                    frmMain.infor = "Admin";
                    this.Close();
                }
                else if(username =="nv" && password == "123")
                {
                    MessageBox.Show("Xin chào @user", "Thông báo", MessageBoxButtons.OK);
                    //this.Hide();
                    //frmMain frm = new frmMain("Chào mừng @user");
                    //frm.ShowDialog();
                    //this.Show();
                    frmMain.infor = "@user";
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thông tin không tồn tại", "Thông báo", MessageBoxButtons.OK);
                    txtUsername.Focus();   
                }    
            } 
            
        }
    }
}
