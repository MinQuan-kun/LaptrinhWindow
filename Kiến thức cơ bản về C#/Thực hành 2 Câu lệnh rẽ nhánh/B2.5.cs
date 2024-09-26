/******************************************************************************
B2.5 Giải phương trình Ax + B = 0. Với A, B là hệ số nhập vào từ bàn phím.
Nếu phương trình vô nghiệm xuất kết quả: VN
– Nếu phương trình VSN xuất ra : VSN
– Nếu phương có nghiệm, xuất ra nghiệm
(Lưu ý: lấy 2 chữ số thập phân)
******************************************************************************/
using System;
using System.Text;
namespace TínhPTBac2
{
    public class Program
    {
        static void Main(string[]args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            bool check = false;
            int A = 0;
            int B = 0;
            while(!check)
            {
                Console.Write("Nhập hệ số A: ");
                try
                {
                    A = int.Parse(Console.ReadLine());
                    check = true;
                }
                catch(FormatException)
                {
                    Console.WriteLine("Lỗi! Vui lòng nhập đúng kiểu dữ liệu.");
                }
            }
            check = false;
            while(!check)
            {
                Console.Write("Nhập hệ số B: ");
                try
                {
                    B = int.Parse(Console.ReadLine());
                    check = true;
                }
                catch(FormatException)
                {
                    Console.WriteLine("Lỗi! Vui lòng nhập đúng kiểu dữ liệu.");
                }
            }
            if(A == 0)
            {
                if(B == 0)
                    Console.WriteLine("VSN");
                else
                    Console.WriteLine("VN");
            }
            else
            {
                    Console.WriteLine("{0} là nghiệm của PT", -B / A);
            }
        }
    }
}