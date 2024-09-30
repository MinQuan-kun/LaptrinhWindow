/***************************************************************************************
Thông tin một mặt hàng bao gồm: Mã mặt hàng (MaMH - số nguyên), tên mặt hàng (TenMH -
chuỗi), số lượng (SoLuong - số nguyên), đơn giá (DonGia - số thực).
 Khai báo cấu trúc mặt hàng nói trên, bao gồm cả hàm tạo và hàm tính thành tiền.
 Viết hàm thêm một mặt hàng vào trong danh sách.
 Viết hàm tìm một mặt hàng dựa vào mã mặt hàng, trả về kiểu bool (có hay không).
 Viết hàm xuất danh sách các mặt hàng.
 viết hàm xóa mặt hàng dựa vào mã mặt hàng.
 Viết hàm main thực hiện các chức năng sau:
o nhập vào danh sách các mặt hàng. Nhập xong mỗi mặt hàng hỏi người dùng có
tiếp tục nhập hay không?
o xuất danh sách các mặt hàng.
o nhập vào mã mặt hàng, tiến hành tìm kiếm mặt hàng nói trên. Nếu tìm thấy, xóa
mặt hàng và xuất danh sách các mặt hàng (sau khi xóa).
****************************************************************************************/
using System;
using System.Text;
using System.Collections;
namespace Quảnlýhànghóa
{
    public class Program
    {
        static void Main(string[]args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            bool check = false;
            List<Product> Arr = new List<Product>();
            while(!check)
            {
                Re:
                Console.Write("Nhập một mặt hàng muốn thêm: ");
                try
                {
                    Product a = Product.Parse(Console.ReadLine());
                    Arr.Add(a);
                    YN:
                    Console.Write("Bạn có muốn nhập thêm một mặt hàng không ? (Y/N)");
                    char Choice = char.Parse(Console.ReadLine());
                    if(Choice == "Y")
                        goto Re;
                    else
                        if(Choice == "N")
                            check = true;
                        else
                        {
                            Console.WriteLine("Lỗi!, vui lòng nhập đúng lựa chọn!!");
                            goto YN;
                        }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Lỗi! Vui lòng nhập đúng định dạng.");
                }
            }
            int numchoice = 0;
            check = false;
            while(!check)
            {
                MenuLoop();
                Console.Write("Nhập lựa chọn của bạn (1-3)");
                try
                {
                    numchoice = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Lỗi! Vui lòng chọn đúng lựa chọn!");
                }
            }
        }
        struct Product
        {
            public int MaMH;
            public string TenMH;
            public int SoLuong;
            public float DonGia;
            public Product(int MaMH, string TenMH, int SoLuong, float DonGia)
            {
                this.MaMH = MaMH;
                this.TenMH = TenMH;
                this.SoLuong = SoLuong;
                this.DonGia = DonGia;
            }
            public float ThanhTien()
            {
                return SoLuong + DonGia;
            }
        }
        static void ThemMatHang(Hashtable danhsach, Product m)
        {
            danhsach.Add(m.MaMH, m);
        }
        static bool TimMatHang(Hashtable danhsach, int MaMH)
        {
            return danhsach.ContainsKEy(MaMH);
        }
        static void XoaMatHang(Hashtable danhsach, int MaMH)
        {
            if (TimMatHang(danhsach, MaMH))
                danhsach.Remove(MaMH);
        }
        static void MenuLoop()
        {
            System("cls");
            Console.WriteLine("*****************Menu*****************");
            Console.WriteLine("1.Nhập thêm một mặt hàng");
            Console.WriteLine("2.Xóa một mặt hàng");
            Console.WriteLine("3.Xuất danh sách hàng hóa");
            Console.WriteLine("4.Thoát chương trình");
            Console.WriteLine("**************************************");
        }
    }
}