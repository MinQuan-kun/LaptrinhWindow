/*****************************************************************
B3.10 [BOBA] Nhập vào 3 số nguyên dương N,M,K. Kiểm tra tổng các
chữ số của N cộng với chữ số đầu tiên của M có bằng K hay không?
Nếu có xuất Yes ngược lại xuất No.
*****************************************************************/
using System;
using System.Text;
namespace BOBA
{
    public class Program
    {
        static void Main(string[]args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            bool check = false;
            int N = 0;
            int M = 0;
            int K = 0;
            int tong = 0;
            while(!check)
            {
                Console.Write("Nhập số nguyên dương N: ");
                try
                {
                    N = int.Parse(Console.ReadLine());
                    int temp = N;
                    while(temp != 0)
                    {
                        tong += temp%10;
                        temp /= 10;
                    }
                    check = true;
                }
                catch(FormatException)
                {
                    Console.WriteLine("Lỗi! Vui lòng nhập đúng kiểu dữ liệu,");
                }
            }
            check = false;
            while(!check)
            {
                Console.Write("Nhập số nguyên dương M: ");
                try
                {
                    M = int.Parse(Console.ReadLine());
                    while(M > 9)
                        M /= 10;
                    check = true;
                }
                catch(FormatException)
                {
                    Console.WriteLine("Lỗi! Vui lòng nhập đúng kiểu dữ liệu,");
                }
            }
            check = false;
            while(!check)
            {
                Console.Write("Nhập số nguyên dương K: ");
                try
                {
                    K = int.Parse(Console.ReadLine());
                    check = true;
                }
                catch(FormatException)
                {
                    Console.WriteLine("Lỗi! Vui lòng nhập đúng kiểu dữ liệu,");
                }
            }
            if(tong + M == K)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}