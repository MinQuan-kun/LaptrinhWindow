//Nhập vào 1 số gồm 3 chữ số, yêu cầu xuất ra tổng các chữ số của nó ra màn hình.
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
                Console.Write("Nhập số N có 3 chữ số: ");
                try
                {
                    int N = int.Parse(Console.ReadLine());
                    if( N >= 100 && N <= 999)
                    {
                        int tong = 0;
                        while(N != 0)
                        {
                            tong += N % 10;
                            N /= 10;
                        }
                        Console.WriteLine("Tổng các chữ số của N là: {0}", tong);
                        check = true;
                    }
                    else
                        Console.WriteLine("Lỗi! Yêu cầu phải nhập đúng số nguyên 3 chữ số");
                }
                catch(FormatException)
                {
                    Console.WriteLine("Lỗi! kiểu dữ liệu phải là số nguyên");
                }
            }
        }
    }
}