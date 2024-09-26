//Nhập vào số i, yêu cầu xuất ra bảng cửu chương thứ i
using System;
using System.Text;
namespace Bảngcửuchưởngi
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
                Console.Write("Nhập vào số i: ");
                try
                {
                    int i = int.Parse(Console.ReadLine());
                    Console.WriteLine("Bảng cửu chương thứ {0}:", i);
                    for(int j = 1; j <= 10; j++)
                        Console.WriteLine("{0} x {1} = {2}", i, j, i * j);
                    check = true;
                }
                catch(FormatException)
                {
                    Console.WriteLine("Lỗi! Vui lòng nhập đúng kiểu dữ liệu.");
                }
            }
        }
    }
}