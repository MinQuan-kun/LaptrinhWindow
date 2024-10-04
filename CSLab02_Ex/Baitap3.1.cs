// Lớp Sinh viên:
// Tạo ứng dụng Console, thêm vào 1 class tên SinhVien bao gồm các thành phần dữ liệu: MaSV,
// HoTen, NgaySinh, DiaChi, DienThoai.
//  Khai báo và định nghĩa các Constructor tham số và không tham số.
//  Khai báo và định nghĩa các properties để truy cập đến giá trị của các thành phần dữ liệu (get, set)
// và viết thêm 1 properties chỉ đọc (get) dùng để lấy LayTuoi của SinhVien.
//  Viết hàm Main() để kiểm tra lớp trên.
using System;
using System.Text;
using System.Collections.Generic;
namespace SinhVien
{
    public class SinhVien
    {
        public int MaSV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public int LayTuoi
        {
            get { return DateTime.Now.Year - NgaySinh.Year; }
        }
        public override string ToString()
        {
            return string.Format("{0} - {1}, {3} tuổi, SĐT:{4}, {5}.", MaSV, HoTen, NgaySinh.ToString("dd/MM/yyyy"), LayTuoi, DienThoai, DiaChi);
        }
    }
    public class Program
    {
        static void Main(string[]args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            List<SinhVien> Mylist = new List<SinhVien>();
            string choice = "";
            while(1 == 1)
            {
                AddSinhVien(Mylist);
                Console.Write("Bạn có muốn nhập thêm sinh viên không? (Y/N): ");
                choice = Console.ReadLine().Trim().ToUpper();
                while (choice != "Y" && choice != "N")
                {
                    Console.Write("Vui lòng chỉ nhập Y hoặc N! :");
                    choice = Console.ReadLine().Trim().ToUpper();
                }
                if (choice == "N") 
                    break;
            }
            PrintSinhVien(Mylist);
        }
        static void AddSinhVien(List<SinhVien> Mylist)
        {
            SinhVien sv = new SinhVien();
            // Nhập mã số sinh viên
            Console.Write("Nhập mã số sinh viên: ");
            int maSV;
            while (!int.TryParse(Console.ReadLine(), out maSV))
            {
                Console.Write("Lỗi! Mã sinh viên phải là số nguyên, vui lòng nhập lại: ");
            }
            if (CheckSinhvien(Mylist, maSV))
            {
                throw new Exception("Mã sinh viên này đã tồn tại, vui lòng nhập lại mã sinh viên khác.");
            }
            sv.MaSV = maSV;

            //Nhập tên sinh viên
            Console.Write("Nhập tên sinh viên: ");
            sv.HoTen = Console.ReadLine().Trim();
            // Nhập ngày sinh
            Console.Write("Nhập ngày sinh (dd/MM/yyyy): ");
            DateTime ngaySinh; // Khai báo biến ngaySinh
            while (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out ngaySinh) ||ngaySinh >= DateTime.Now)
            {
                Console.Write("Lỗi! Ngày sinh phải là dạng dd/MM/yyyy, vui lòng nhập lại: ");
            }
            sv.NgaySinh = ngaySinh;
            //Nhập địa chỉ
            Console.Write("Nhập địa chỉ sinh viên: ");
            sv.DiaChi = Console.ReadLine().Trim();
            //Nhập số điện thoại
            Console.Write("Nhập số điện thoại sinh viên: ");
            sv.DienThoai = Console.ReadLine().Trim();
            // Kiểm tra và xử lý số điện thoại
            long dienThoai;
            while (!long.TryParse(sv.DienThoai, out dienThoai) || dienThoai <= 0)
            {
                Console.Write("Số điện thoại không hợp lệ. Vui lòng nhập lại:");
                sv.DienThoai = Console.ReadLine().Trim();
            }
            Mylist.Add(sv);
            Console.WriteLine("Thêm sinh viên thành công!");
        }
        static bool CheckSinhvien(List<SinhVien> MyList, int MASV)
        {
            foreach (var sv in MyList)
                if(sv.MaSV == MASV)
                    return true;
            return false;
        }
        static void PrintSinhVien(List<SinhVien> Mylist)
        {
            if(Mylist.Count == 0)
            {
                Console.WriteLine("Danh sách trống!");
                return;
            }
            Console.WriteLine("Danh sách sinh viên hiện tại: ");
            foreach(var sv in Mylist)
                Console.Write(sv.ToString());
            Console.WriteLine();
        }
    }
}