//Nhập vào 1 số gồm 4 chữ số, yêu cầu xuất số đó theo thứ tự ngược lại
using System;
using System.Text;
namespace Xuấtsốngượclại
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
                Console.Write("Nhập số N gồm 4 chữ số: ");
                try
                {
                    int n = int.Parse(Console.ReadLine());
                    if( n >= 1000 || n <= 9999)
                    {
                        int tong = 0;
                        while(n != 0)
                        {
                            tong = tong * 10 + n % 10;
                            n /= 10;
                        }
                        Console.WriteLine("Tổng các chữ số của N là: {0)", tong);
                        check = true;
                    }
                    else
                        Console.WriteLine("Lỗi! Vui lòng nhập đúng yêu cầu ");
                }
                catch(FormatException)
                {
                    Console.WriteLine("Lỗi! Kiểu dữ liệu không hợp lệ");
                }
            }
        }
    }
}