//Nhập vào 1 số thực. Xuất ra màn hình số lấy chính xác 3 chữ số thập phân từ ban đầu bằng 2 cách.
//Cách 1: Sử dụng hàm làm tròn
//Cách 2: Sử dụng định dạng xuất
using System;
using System.Text;
namespace Xuấtsốthậpphân
{
    public class Program
    {
        static void Main(string[]args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            bool check = false;
            while(!check)
            {
                Console.Write("Nhập số thực N: ");
                try
                {
                    float N = float.Parse(Console.ReadLine());
                    check = true;
                    Console.WriteLine($"C1 sử dụng hàm làm tròn.Số vừa nhập là: {Math.Round(N,3)}");
                    Console.WriteLine("C2 sử dụng định dạng xuất.Số vừa nhập là: {0:F3}",N);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Lỗi! Vui lòng nhập đúng kiểu dữ liệu. ");
                }
            }
        }
    }
}