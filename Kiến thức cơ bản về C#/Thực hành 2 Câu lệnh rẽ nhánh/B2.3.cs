//Nhập vào 3 sô nguyên a,b,c. Tìm số lớn nhất và sô nhỏ nhất.
using System;
using System.Text;
namespace Tìmmaxmin
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
            while(!check)
            {
                Console.Write("Nhập số nguyên a: ");
                try
                {
                    a = int.Parse(Console.ReadLine());
                    check = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Lỗi! Vui lòng nhập đúng kiểu dữ liệu.");
                }
            }
            check = false;
            while(!check)
            {
                Console.Write("Nhập số nguyên b: ");
                try
                {
                    b = int.Parse(Console.ReadLine());
                    check = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Lỗi! Vui lòng nhập đúng kiểu dữ liệu.");
                }
            }
            check = false;
            while(!check)
            {
                Console.Write("Nhập số nguyên c: ");
                try
                {
                    c = int.Parse(Console.ReadLine());
                    check = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Lỗi! Vui lòng nhập đúng kiểu dữ liệu.");
                }
            }
            int max = a;
            if(max < b)
            max = b;
            if(max < c)
            max = c;
            int min = a;
            if(min > b)
            min = b;
            if(min > c)
            min = c;
            Console.WriteLine("Max là: {0}, Min là: {1}", max, min);
        }
    }
}