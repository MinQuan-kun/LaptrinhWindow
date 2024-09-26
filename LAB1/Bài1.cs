//Viết chương trình Console nhập vào tên người dùng và xuất ra câu chào tên người đó (ví dụ:“Xin chao Huyen”).
using System;
using System.Text;
namespace Nhậpxuất
{
    public class Program
    {
        static void Main(string[]args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            string text;
            Console.Write("Nhập tên của bạn: ");
            text = Console.ReadLine();
            Console.Write("Xin chào: "+ text);
        }
    }
    
}