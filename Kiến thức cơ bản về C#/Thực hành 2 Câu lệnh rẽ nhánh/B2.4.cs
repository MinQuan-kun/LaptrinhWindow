//Nhập vào 2 số nguyên và 1 phép toán. Yêu cầu xuất ra kết quả phép tính dựa trên phép toán (là 1 trong 4 phép toán: +,-,*,%)
using System;
using System.Text;
namespace XuấtKQ
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
            while(!check)
            {
                Console.Write("Nhập số nguyên a: ");
                try
                {
                    a = int.Parse(Console.ReadLine());
                    check = true;
                }
                catch(FormatException)
                {
                    Console.WriteLine("Lỗi! vui lòng nhâp đúng kiểu dữ liệu.");
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
                catch(FormatException)
                {
                    Console.WriteLine("Lỗi! vui lòng nhâp đúng kiểu dữ liệu.");
                }
            }
            Console.WriteLine("Phép cộng: {0} + {1} = {2}", a, b, a + b);
            Console.WriteLine("Phép trừ: {0} - {1} = {2}", a, b, a - b);
            Console.WriteLine("Phép nhân: {0} * {1} = {2}", a, b, a * b);
            Console.WriteLine("Phép chia(Lấy dư): {0} % {1} = {2}", a, b, a % b);
        }
    }
}