//Nhập 2 số và tính tổng theo định dạng: a+b = tổng
using System;
namespace Tínhtổng
{
    public class Program
    {
        static void Main(string[]args)
        {
            Console.OutputEncoding = Encoding.UTF8; // Xuất kết quả có dấu 
            Console.InputEncoding = Encoding.UTF8;  // Nhập dữ liệu có dấu
            Console.Write("Nhập số a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhập số b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Tổng của a + b = {0}", a + b);
        }
    }
}