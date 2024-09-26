//Nhập vào 2 ký tự, yêu cầu xuất ra mã ASCII của từng ký tự và tổng giá trị mã ASCII của 2 ký tự.
using System;
using System.Text;
namespace XuấttổngmãASCII
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
                Console.Write("Nhập kí tự thứ nhất: ");
                try
                {
                    char a = char.Parse(Console.ReadLine());
                    Console.Write("Nhập kí tự thứ hai: ");
                    char b = char.Parse(Console.ReadLine());
                    check = true;
                    int n1 = a;
                    int n2 = b;
                    Console.WriteLine("Tổng giá trị mã ASCII của 2 ký tự là: {0}" , n1 + n2);
                }
                catch(FormatException)
                {
                    Console.WriteLine("Lỗi! Kiểu dữ liệu không hợp lệ");
                }
            }
        }
    }
}