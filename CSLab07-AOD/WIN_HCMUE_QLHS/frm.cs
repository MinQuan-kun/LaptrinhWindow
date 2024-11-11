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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public static string infor = "Bạn chưa đăng nhập!";
        public frmMain(string _infor)
        {
            InitializeComponent();
            infor = _infor;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            lblInfor.Text = infor;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss ");
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Show();
            lblInfor.Text = infor;
            if(infor != "Bạn chưa đăng nhập")
            {
                toolStripButton1.Enabled = false;
                đăngNhậpToolStripMenuItem.Enabled = false;
                đăngXuấtToolStripMenuItem.Enabled = true;
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            infor = "Bạn chưa đăng nhập";
            lblInfor.Text = infor;
            đăngXuấtToolStripMenuItem.Enabled = false;
            đăngNhậpToolStripMenuItem.Enabled = true;
            toolStripButton1.Enabled = true;
        }
    }
}
