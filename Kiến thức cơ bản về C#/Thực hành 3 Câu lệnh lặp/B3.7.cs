//In ra bảng cửu chương từ 2 tới 10
using System;
using System.Text;
namespace Bảngcửuchưởng
{
    public class Program
    {
        static void Main(string[]args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            for(int i = 2; i <= 10; i++)
            {
                Console.WriteLine("Bảng cửu chưởng thứ {0}", i);
                for(int j = 1; j <= 10; j++)
                    Console.WriteLine("{0} x {1} = {2}", i, j, i * j);
                Console.WriteLine("");
            }
        }
    }
}

