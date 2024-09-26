//Nhập vào 1 số gồm 2 chữ số, yêu cầu xuất ra tổng các chữ số của nó ra màn hình.
using System;
using System.Text;
namespace Tínhtổngcácchữsố
{
    public class Program
    {
        static void Main(string[]args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            bool check = false;
            while(!check)
            {
                Console.Write("Nhập số N có 2 chữ số: ");
                try
                {
                    int N = int.Parse(Console.ReadLine());
                    if(N >= 10 && N <= 99)
                    {
                        int tong = 0;
                        while(N != 0)
                        {
                            tong += N % 10;
                            N /= 10;
                            check = true;
                        }
                        Console.WriteLine("Tổng 2 chữ số của N là: {0}",tong);
                    }
                    else
                        Console.Write("Lỗi! Vui lòng nhập đúng yêu cầu ");
                }
                catch(FormatException)
                {
                    Console.WriteLine("Lỗi! kiểu dữ liệu phải là số nguyên");
                }
            }
        }
    }
}