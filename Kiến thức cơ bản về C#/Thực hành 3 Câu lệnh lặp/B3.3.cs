//Nhập vào 1 số nguyên và xuất là Yes nếu nó là số hoàn hảo, ngược lại xuất No. Gợi ý: số hoàn hảo là số mà tổng ước số của nó (không tính nó) bằng chính nó.
using System;
using System.Text;
namespace Sốhoànhảo
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
                Console.Write("Nhập vào 1 số nguyên: ");
                try
                {
                    int N = int.Parse(Console.ReadLine());
                    PerfectNum(N);
                    check = true;
                }
                catch(FormatException)
                {
                    Console.WriteLine("Lỗi! Vui lòng nhập đúng kiểu dữ liệu.");
                }
            }
        }
        static void PerfectNum(int N)
        {
            int tong = 0;
            for(int i = 1; i < N; i++)
                if(N % i == 0)
                    tong +=i;
            if(tong == N)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}