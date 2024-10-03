// Thông tin một mặt hàng bao gồm: Mã mặt hàng (MaMH - số nguyên), tên mặt hàng (TenMH
// - chuỗi), số lượng (SoLuong - số nguyên), đơn giá (DonGia - số thực).
//  Khai báo cấu trúc mặt hàng nói trên, bao gồm cả hàm tạo và hàm tính thành tiền.
//  Viết hàm thêm một mặt hàng vào trong danh sách.
//  Viết hàm tìm một mặt hàng dựa vào mã mặt hàng, trả về kiểu bool (có hay không).
//  Viết hàm xuất danh sách các mặt hàng.
//  viết hàm xóa mặt hàng dựa vào mã mặt hàng.
//  Viết hàm main thực hiện các chức năng sau:
// o nhập vào danh sách các mặt hàng. Nhập xong mỗi mặt hàng hỏi người dùng có
// tiếp tục nhập hay không?
// o xuất danh sách các mặt hàng.
// o nhập vào mã mặt hàng, tiến hành tìm kiếm mặt hàng nói trên. Nếu tìm thấy,
// xóa mặt hàng và xuất danh sách các mặt hàng (sau khi xóa).
using System;
using System.Text;
using System.Collections.Generic;

namespace Baitap2
{
    public struct Mathang
    {
        public int MaMH;
        public string TenMH;
        public int Soluong;
        public float Dongia;

        public float Thanhtoan()
        {
            return Dongia * Soluong;
        }

        public override string ToString()
        {
            return $"Mã mặt hàng: {MaMH}, Tên mặt hàng: {TenMH}, Số lượng: {Soluong}, Đơn giá: {Dongia}VND";
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            List<Mathang> Mylist = new List<Mathang>();
            string choice = "";
            int ID = 0;

            while (true)
            {
                try
                {
                    AddMathang(Mylist);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi: {ex.Message}");
                    continue; // yêu cầu người dùng nhập lại
                }

                Console.Write("Bạn có muốn tiếp tục thêm mặt hàng không? (Y/N): ");
                choice = Console.ReadLine().Trim().ToUpper();
                while (choice != "Y" && choice != "N")
                {
                    Console.Write("Vui lòng chọn đúng yêu cầu!! (Y/N): ");
                    choice = Console.ReadLine().Trim().ToUpper();
                }

                if (choice == "N")
                    break;
            }

            PrintMathang(Mylist);
            BACK:
            choice = "";
            Console.Write("Nhập mã mặt hàng bạn muốn tìm: ");
            while (!int.TryParse(Console.ReadLine(), out ID))
            {
                Console.WriteLine("Lỗi! Mã sản phẩm phải là số nguyên, vui lòng nhập lại:");
            }
            if (FindMathang(Mylist, ID))
            {
                Console.WriteLine("Bạn có muốn xóa mặt hàng này khỏi list không? (Y/N): ");
                choice = Console.ReadLine().Trim().ToUpper();
                while (choice != "Y" && choice != "N")
                {
                    Console.Write("Vui lòng chọn đúng yêu cầu!!(Y/N): ");
                    choice = Console.ReadLine().Trim().ToUpper();
                }
                if (choice == "N")
                    PrintMathang(Mylist);
                else if (choice == "Y")
                {
                    DeleteMathang(Mylist, ID);
                    PrintMathang(Mylist);
                }
            }
            else
            {
                Console.WriteLine("Mặt hàng bạn cần tìm không tồn tại! Bạn có muốn nhập lại? (Y/N): ");
                choice = Console.ReadLine().Trim().ToUpper();
                while (choice != "Y" && choice != "N")
                {
                    Console.Write("Vui lòng chọn đúng yêu cầu!!(Y/N): ");
                    choice = Console.ReadLine().Trim().ToUpper();
                }
                if (choice == "N")
                    PrintMathang(Mylist);
                else if (choice == "Y")
                {
                    goto BACK;
                }
            }
        }

        static void AddMathang(List<Mathang> Mylist)
        {
            Mathang mh = new Mathang();

            Console.Write("Nhập mã sản phẩm: ");
            while (!int.TryParse(Console.ReadLine(), out mh.MaMH))
            {
                Console.Write("Lỗi! Mã sản phẩm phải là số nguyên, vui lòng nhập lại: ");
            }
            // Kiểm tra trùng mã mặt hàng
            if (FindMathang(Mylist, mh.MaMH))
            {
                throw new Exception("Mã mặt hàng đã tồn tại, vui lòng nhập mã khác.");
            }

            Console.Write("Nhập tên sản phẩm: ");
            mh.TenMH = Console.ReadLine().Trim();
            Console.Write("Nhập số lượng: ");
            while (!int.TryParse(Console.ReadLine(), out mh.Soluong))
            {
                Console.Write("Lỗi! Số lượng phải là số nguyên, vui lòng nhập lại: ");
            }
            Console.Write("Nhập đơn giá: ");
            while (!float.TryParse(Console.ReadLine(), out mh.Dongia))
            {
                Console.Write("Lỗi! Đơn giá phải là số thực, vui lòng nhập lại: ");
            }

            Mylist.Add(mh);
            Console.WriteLine("Thêm mặt hàng thành công!");
        }

        static bool FindMathang(List<Mathang> Mylist, int maMH)
        {
            foreach (var item in Mylist)
            {
                if (item.MaMH == maMH)
                    return true;
            }
            return false;
        }

        static void DeleteMathang(List<Mathang> Mylist, int maMH)
        {
            if (Mylist.Count == 0)
            {
                Console.WriteLine("Danh sách trống!");
                return;
            }

            for (int i = 0; i < Mylist.Count; i++)
            {
                if (Mylist[i].MaMH == maMH)
                {
                    Mylist.RemoveAt(i);
                    Console.WriteLine("Mặt hàng đã được xóa.");
                    return;
                }
            }
            Console.WriteLine("Không tìm thấy mặt hàng để xóa.");
        }

        static void PrintMathang(List<Mathang> Mylist)
        {
            if (Mylist.Count == 0)
            {
                Console.WriteLine("Danh sách trống.");
                return;
            }

            Console.WriteLine("Danh sách hiện tại:");
            foreach (var mh in Mylist)
                Console.WriteLine(mh);
        }
    }
}
