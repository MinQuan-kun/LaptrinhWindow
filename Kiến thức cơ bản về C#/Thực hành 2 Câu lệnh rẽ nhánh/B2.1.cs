//Nhập vào 1 số và kiểm tra số đó là số chẵn không?
using System;
using System.Text;
namespace Kiểmtrasốchắn
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
                Console.Write("Nhập số N: ");
                try
                {
                    int N = int.Parse(Console.ReadLine());
                    if(N % 2 == 0)
                        Console.WriteLine("{0} là số chẵn", N);
                    else
                        Console.WriteLine("{0} không phải số chẵn", N);
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