//Nhập vào 1 số gồm 4 chữ số abcd, yêu cầu tính tổng của: ad + bc= ?. Ví dụ: 1234 thì kết quả 14+23=37
using System;
using System.Text;
namespace tínhtổngabcd
{
    public class Program
    {
        static void Main(string[]args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            bool check = false;
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            while(!check)
            {
                Console.Write("Nhập vào 1 số gồm 4 chữ số abcd: ");
                try
                {
                    int n = int.Parse(Console.ReadLine());
                    a = (n/1000) * 10;
                    b = ((n / 100) % 10) * 10;
                    c = (n % 100) / 10;
                    d = n %10;
                    check = true;
                }
                catch(FormatException)
                {
                    Console.WriteLine("Lỗi! Vui lòng nhập đúng kiểu dữ liệu");
                }
            }
            Console.WriteLine("Tổng của ad + bc = {0}", a + d + b + c);
        }
    }
}
