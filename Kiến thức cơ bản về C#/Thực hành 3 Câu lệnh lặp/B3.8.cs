//B3.8 Nhập vào 1 số nguyên n. Xuất ra kết quả phép tính theo công thức sau kết quả lấy 3 chữ số thập phân: 1+1/23+1/33+...+1/n3
using System;
using System.Text;
namespace Dequy
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
                Console.Write("Nhập vào số nguyên n: ");
                try
                {
                    int n = int.Parse(Console.ReadLine());
                    Console.WriteLine("Kết quả của biểu thức là: {0:0.000}", Dequy(n));
                    check = true;
                }
                catch(FormatException)
                {
                    Console.WriteLine("Lỗi! Vui lòng nhập đúng kiểu dữ liệu.");
                }
            }
        }
        static double Dequy(int n)
        {
            if(n == 1)
                return 1.0;
            return (1.0/Math.Pow(n, 3) + Dequy(n - 1));
        }
    }
}