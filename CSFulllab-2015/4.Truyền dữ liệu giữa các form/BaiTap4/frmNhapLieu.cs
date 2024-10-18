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
    public partial class frmNhapLieu : Form
    {
        public frmNhapLieu()
        {
            InitializeComponent();
        }

        private void btnKhoitao_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txtSodong.Text, out int soDong) && int.TryParse(txtSocot.Text, out int soCot) && soCot > 0 && soDong > 0)
            {
                var form = new frmXuat(soDong, soCot);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("!Lỗi, Số dòng và số cột phải lớn hơn 0", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    

        }
    }
}
