//Lớp Hình chữ nhật
// Tạo ứng dụng Console, thêm vào 1 class tên HinhChuNhat gồm các thành phần dữ liệu: mChieuCao,
// mChieuRong. Thực hiện các yêu cầu sau:
//  Viết các constructor không tham số và có tham số để khởi tạo các giá trị cho mChieuCao và
// mChieuRong.
//  Viết các properties để truy cập đến 2 thành phần trên.
//  Viết 2 phương thức trả về chu vi (mChieuDai+mChieuRong) x 2 và diện tích hình chữ nhật
// (mChieuDai x mChieuRong).
//  Phương thức xuất thông tin hình chữ nhật: rộng, dài, diện tích và chu vi.
//  Viết phương thức kiểm tra xem hình chữ nhật có phải là hình vuông hay không?
//  Viết hàm Main để kiểm tra lớp HinhChuNhat: khởi tạo đối tượng, các giá trị cho đối tượng, gọi các
// phương thức, ...

using System;
using System.Text;
using System.Collections.Generic;
namespace HinhChuNhat
{
    public class HinhChuNhat
    {
        public int mChieuCao;
        public int mChieuRong;
        public HinhChuNhat() {}
        public HinhChuNhat(int ChieuCao, int ChieuRong)
        {
            mChieuCao = ChieuCao;
            mChieuRong = ChieuRong;
        }
        public int ChieuCao
        {
            get { return mChieuCao; }
            set { mChieuCao = value; }
        }

        public int ChieuRong
        {
            get { return mChieuRong; }
            set { mChieuRong = value; }
        }
        public int ChuVi
        {
            get { return (mChieuCao + mChieuRong) * 2; }
        }
        public int DienTich
        {
            get { return (mChieuCao * mChieuRong); }
        }
        public void XuatThongTin()
        {
            Console.WriteLine($"Chiều dài: {mChieuCao}, Chiều rộng: {mChieuRong}, Chu vi: {ChuVi}, Diện tích: {DienTich}");
        }
        public bool CheckHCN()
        {
            return mChieuCao == mChieuRong;
        }
    }
    public class Program
    {
        static void Main(string[]args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            HinhChuNhat hcn = new HinhChuNhat();
            Console.Write("Nhập chiều cao của hình chữ nhật: ");
            while(!int.TryParse(Console.ReadLine(), out hcn.mChieuCao))
            {
                Console.Write("Lỗi! chiều cao là phải 1 số nguyên: ");
            }
            Console.Write("Nhập chiều rộng của hình chữ nhật: ");
            while(!int.TryParse(Console.ReadLine(), out hcn.mChieuRong))
            {
                Console.Write("Lỗi! chiều rộng phải là 1 số nguyên: ");
            }
            if(!hcn.CheckHCN())
                Console.WriteLine("Đây là hình chữ nhật!!");
            else
                Console.WriteLine("Đây không phải hình chữ nhật, đây là hình vuông!!");
            hcn.XuatThongTin();
        }
    }
}