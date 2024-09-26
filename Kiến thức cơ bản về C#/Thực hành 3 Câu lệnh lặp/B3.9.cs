/********************************************************************
B3.9 Nhập vào 2 số nguyên dương N,M (N > M). Yêu cầu kiểm tra
tích các chữ số của N có bằng tổng các ước của M hay không? Nếu có
xuất YES ngược lại xuất NO. Ví dụ:
- Nhập N=23, M=6 => NO
- Nhập N=34, M=6 => YES
********************************************************************/
using System;
using System.Text;
namespace Tongbanguoc
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
            int tich = 1;
            int tong = 0;
            while(!check)
            {
                Console.Write("Nhập số N: ");
                try
                {
                    N = int.Parse(Console.ReadLine());
                    int temp = N;
                    while(temp != 0)
                    {
                        tich *= temp % 10;
                        temp /= 10;
                    }
                    check = true;
                }
                catch(FormatException)
                {
                    Console.WriteLine("Lỗi! Vui lòng nhập đúng kiểu dữ liệu.");
                }
            }
            check = false;
            while(!check)
            {
                Console.Write("Nhập số M: ");
                try
                {
                    M = int.Parse(Console.ReadLine());
                    for(int i = 1; i <= M; i++)
                        if(M % i == 0)
                            tong+= i;
                    check = true;
                }
                catch(FormatException)
                {
                    Console.WriteLine("Lỗi! Vui lòng nhập đúng kiểu dữ liệu.");
                }
            }
            if(tong == tich)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}