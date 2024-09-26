//Nhập vào 2 số nguyên N và M. Yêu cầu tính tổng chữ số cuối cùng của N và của M.
using System;
namespace Tínhtổngchữsốcuối
{
    public class Program
    {
        static void Main(string[]args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.Write("Nhập số nguyên N: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Nhập số nguyên M: ");
            int M = int.Parse(Console.ReadLine());
            Console.WriteLine("Tổng chữ số cuối cùng của N và M = {0}", N % 10 + M % 10);
        }
    }
}