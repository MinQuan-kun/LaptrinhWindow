// Xây dựng lớp sản phẩm bao gồm các trường mã, tên, giá.
// o Hàm tạo 3 đối số và hàm tạo mặc định.
// o Phương thức tính thuế VAT
// o Phương thức nhập mã, tên, giá từ bàn phím
// o Phương thức xuất thông tin sản phẩm: mã, tên, giá và thuế VAT
// o Viết chương trình nhập 2 sản phẩm từ bàn phím
// o Viết chương trình thực hiện các công việc sau
//  Tạo đối tượng sản phẩm
//  Gọi phương thức nhập
//  Gọi phương thức xuất

using System;
using System.Text;
using System.Collections.Generic;
namespace Sanpham
{
    public class Sanpham
    {
        public string _strMaSP { get; set; }
        public string _strTenSP { get; set; }
        public double _sDonGia { get; set; }
        public Sanpham()
        {
            _strMaSP = "";
            _strTenSP = "";
            _sDonGia = 0;
        }
        public Sanpham(string MaSP, string TenSP, double DonGia)
        {
            this._strMaSP = MaSP;
            this._strTenSP = TenSP;
            this._sDonGia = DonGia;
        }
        public double VAT
        {
            get {return (_sDonGia * 0.08); }
        }
        public void NhapSP()
        {
            Console.Write("Nhập mã sản phẩm: ");
            _strMaSP = Console.ReadLine();
            Console.Write("Nhập tên sản phẩm: ");
            _strTenSP = Console.ReadLine();
            double dongia;
            Console.Write("Nhập đơn giá sản phẩm: ");
            while(!double.TryParse(Console.ReadLine(), out dongia))
            {
                Console.Write("Đơn giá phải là số thực: ");
            }
            _sDonGia = dongia;
        }
        public void XuatSP()
        {
            Console.WriteLine($"Mã sản phẩm: {_strMaSP}");
            Console.WriteLine($"Tên sản phẩm: {_strTenSP}");
            Console.WriteLine($"Đơn giá: {_sDonGia}VNĐ");
            Console.WriteLine($"Thế VAT: {VAT}VNĐ");
        }
    }
    public class Program
    {
        static void Main(string[]args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Sanpham sp = new Sanpham();
            sp.NhapSP();
            sp.XuatSP();
        }    
    }
}