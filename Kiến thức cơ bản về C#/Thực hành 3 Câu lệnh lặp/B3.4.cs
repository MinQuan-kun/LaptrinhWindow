//Nhập vào 2 số nguyên a và b. Yêu cầu tìm UCLN của 2 số đó.
using System;
using System.Text;
namespace TìmUCLN
{
    public class Program
    {
        static void Main(string[]args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            int a = 0;
            int b = 0;
            bool check = false;
            while(!check)
            {
                Console.Write("Nhập vào số nguyên a: ");
                try
                {
                    a = int.Parse(Console.ReadLine());
                    check = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Lỗi! Vui lòng nhập đúng kiểu dữ liệu");
                }
            }
            check = false;
            while(!check)
            {
                Console.Write("Nhập vào số nguyên b: ");
                try
                {
                    b = int.Parse(Console.ReadLine());
                    check = true;
                   
                }
                catch (FormatException)
                {
                    Console.WriteLine("Lỗi! Vui lòng nhập đúng kiểu dữ liệu");
                }
            }
            Console.WriteLine("Ước chung lớn nhất của ({0}, {1}) là: {2}", a, b, UCLN(a,b));
        }
        static int UCLN(int a, int b)
        {
            if(b == 0)
                return a;
            else 
                return UCLN(b, a % b);
        }
    }
}