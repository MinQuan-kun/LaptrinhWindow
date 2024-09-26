//Nhập vào 2 số a và b. Yêu cầu hoán vị giá trị và xuất kết quả ra màn hình.
using System;
namespace Hoánvị2số
{
    public class Program
    {
        static void Main(string[]args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.Write("Nhập số a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhập số b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Số a và b sau khi hoán vị là: a = {0}  b = {1}", b ,a);
        }
    }
}