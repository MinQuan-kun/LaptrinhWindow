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
    public partial class frmLopHoc : Form
    {
        public frmLopHoc()
        {
            InitializeComponent();
        }
        private void frmLopHoc_Load(object sender, EventArgs e)
        {
            loaiDuLieu();
            HienthiDuLieuDong(0); // Mặc định khi mở form đầu tiên
        }

        private void loaiDuLieu()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            dgvLop.DataSource = db.Lops.OrderBy(p => p.MaLop);
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Xác định row đang chọn
            int idrow = e.RowIndex;
            if (idrow == -1) // header
                return;
            HienthiDuLieuDong(idrow);
            
        }

        private void HienthiDuLieuDong(int idrow)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            string malop = dgvLop.Rows[idrow].Cells[0].Value.ToString();
            //Hiển thị dữ liệu
            Lop lophoc = db.Lops.Where(p => p.MaLop == malop).SingleOrDefault();
            if(lophoc != null)
            {
                txtMaLop.Text = lophoc.MaLop;
                txtTenLop.Text = lophoc.TenLop;
                txtSiSo.Text = lophoc.SiSo.ToString();
            } 
                
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btbThem_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu input
            string malop = txtMaLop.Text;
            string tenlop = txtTenLop.Text;
            int siso = int.Parse(txtSiSo.Text);

            DataClasses1DataContext db = new DataClasses1DataContext();
            // Kiểm tra logic khóa chính
            Lop l = db.Lops.Where(p => p.MaLop == malop).SingleOrDefault();
            if(l != null)
            {
                // Có dữ liệu => Bị trùng
                MessageBox.Show("Mã lớp đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaLop.Focus();
                return;
            }
            else
            {
                //Chưa có dữ liệu
                l = new Lop();
                l.MaLop = malop;
                l.SiSo = (short) siso;
                l.TenLop = tenlop;
                db.Lops.InsertOnSubmit(l); // Gọi lệnh thêm mới
                db.SubmitChanges(); // đồng bộ dữ liệu

                loaiDuLieu();
                MessageBox.Show("Thêm mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu input
            string malop = txtMaLop.Text;
            string tenlop = txtTenLop.Text;
            int siso = int.Parse(txtSiSo.Text);

            DataClasses1DataContext db = new DataClasses1DataContext();
            // Kiểm tra logic khóa chính
            Lop l = db.Lops.Where(p => p.MaLop == malop).SingleOrDefault();
            if (l == null)
            {
                // không có dữ liệu => Không thể sửa được
                MessageBox.Show("Mã lớp không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaLop.Focus();
                return;
            }
            else
            {
                //đã có dữ liệu => cập nhật
                l.SiSo = (short)siso;
                l.TenLop = tenlop;
                db.SubmitChanges(); // đồng bộ dữ liệu

                loaiDuLieu();
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu input
            string malop = txtMaLop.Text;

            DataClasses1DataContext db = new DataClasses1DataContext();
            // Kiểm tra logic khóa chính
            Lop l = db.Lops.Where(p => p.MaLop == malop).SingleOrDefault();
            if (l == null)
            {
                // không có dữ liệu => Không thể sửa được
                MessageBox.Show("Mã lớp không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaLop.Focus();
                return;
            }
            else
            {
                //đã có dữ liệu => cập nhật
                db.Lops.DeleteOnSubmit(l);
                db.SubmitChanges(); // đồng bộ dữ liệu

                loaiDuLieu();
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
