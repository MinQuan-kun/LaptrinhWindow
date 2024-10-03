//1. Viết chương trình nhập họ, tên lót, tên. Xuất ra tên đầy đủ.
using System;
using System.Text;
namespace Chuỗi
{
    public class Program{
        static void Main(string[]args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập họ của bạn: ");
            string ho = Console.ReadLine();
            Console.Write("Nhập tên lót của bạn: ");
            string tenlot = Console.ReadLine();
            Console.Write("Nhập tên của bạn: ");
            string ten = Console.ReadLine();
            Console.WriteLine("Họ tên đầy đủ của bạn là {0} {1} {2}", ho, tenlot , ten);
        }
    }
}

