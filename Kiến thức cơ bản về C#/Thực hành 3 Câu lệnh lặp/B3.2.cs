//In các số chẵn trong khoảng (M,N). Với N, M nhập từ bàn phím.
using System;
using System.Text;
namespace xuấtsốchẵntrongkhoảng
{
    public class Program
    {
        static void Main(string[]args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            bool check = false;
            int M = 0;
            int N = 0;
            while(!check)
            {
                Console.Write("Nhập số M: ");
                try
                {
                    M = int.Parse(Console.ReadLine());
                    check = true;
                }
                catch(FormatException)
                {
                    Console.WriteLine("Lỗi! Vui lòng nhập đúng kiểu dữ liệu");
                }
            }
            check = false;
            while(!check)
            {
                Console.Write("Nhập số N: ");
                try
                {
                    N = int.Parse(Console.ReadLine());
                    check = true;
                }
                catch(FormatException)
                {
                    Console.WriteLine("Lỗi! Vui lòng nhập đúng kiểu dữ liệu");
                }
            }
            Console.Write("Số chẵn trong khoảng ({0},{1}) là: ", M, N);
            for(int i = M; i <= N; i++)
                if(i % 2 == 0)
                    Console.Write("{0} ",i);
        }
    }
   
}