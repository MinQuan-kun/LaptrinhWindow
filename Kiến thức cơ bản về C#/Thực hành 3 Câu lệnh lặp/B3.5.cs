//Nhập vào 1 số nguyên n, xuất ra n!
using System;
using System.Text;
namespace nGiaithừa
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
                Console.Write("Nhập vào 1 số nguyên n: ");
                try
                {
                    int sum = 1;
                    int n = int.Parse(Console.ReadLine());
                    for(int i = 1; i < n; i++)
                        Console.Write("{0}.",i);
                    for(int i = 1; i <= n; i++)
                        sum *= i;
                    Console.Write("{0} = {1}", n, sum);
                    check = true;
                }
                catch(FormatException)
                {
                    Console.WriteLine("Lỗi! Vui lòng nhập đúng kiểu dữ liệu");
                }
            }
        }
    }
}