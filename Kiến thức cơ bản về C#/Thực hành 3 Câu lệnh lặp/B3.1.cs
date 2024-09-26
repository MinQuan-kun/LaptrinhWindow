//B3.1 Nhập số nguyên A và kiểm tra có phải là số nguyên tố hay không?
using System;
using System.Text;
namespace KTSNT
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
                Console.Write("Nhập số nguyên A: ");
                try
                {
                    int A = int.Parse(Console.ReadLine());
                    if(SNT(A))
                        Console.WriteLine("{0} là số nguyên tố.", A);
                    else
                        Console.WriteLine("{0} không phải là số nguyên tố.", A);
                    check = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Lỗi! Vui lòng nhập đúng kiểu dữ liệu.");
                }
            }
        }
        static bool SNT(int A)
        {
            if(A < 2)
                return false;
                for(int i = 2; i <= A/2; i++)
                    if(A % i == 0)
                        return false;
            return true;
        }
    }
}