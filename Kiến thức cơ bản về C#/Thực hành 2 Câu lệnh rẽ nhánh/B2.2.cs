//Nhập vào 1 số và kiểm tra số đó là số chính phương không?
using System;
using System.Text;
namespace Kiểmtrasốchínhphương
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
                    int n = int.Parse(Console.ReadLine());
                    if(SCP(n))
                        Console.WriteLine("{0} là số chính phương", n);
                    else
                        Console.WriteLine("{0} không phải số chính phương", n);
                    check = true;
                }
                catch(FormatException)
                {
                    Console.WriteLine("Lỗi! Vui lòng nhập đúng định dạng.");
                }
            }
            
        }
        static bool SCP(int n)
        {
            int sqr = (int)Math.Sqrt(n);
            if(sqr * sqr == n)
                return true;
            return false;
        }
    }
}