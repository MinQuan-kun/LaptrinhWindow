//Nhập vào 2 số nguyên là tháng và năm. Xuất ra chính xác số ngày trong tháng đó. Lưu ý kiểm tra năm nhuận cho tháng 2.
using System;
using System.Text;
namespace Xuấtrasốngàycủatháng
{
    public class Program
    {
        static void Main(string[]args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            bool check = false;
            int m = 0;
            int n = 0;
            while(!check)
            {
                Console.Write("Nhập số nguyên là năm: ");
                try
                {
                    m = int.Parse(Console.ReadLine());
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
                Console.Write("Nhập số nguyên là tháng: ");
                try
                {
                    n = int.Parse(Console.ReadLine());
                    if((m % 4 == 0 && m % 100 != 0) || (m % 400 == 0))
                    {
                        if(n == 1 || n == 3 || n == 5 || n == 7 || n == 8 || n == 10 || n == 12)
                            Console.Write("Số ngày trang tháng {0} là 31 ngày.", n);
                        if(n == 4 || n == 6 || n == 9 || n == 11)
                            Console.Write("Số ngày trong tháng {0} là 30 ngày.", n);
                        if(n == 2) 
                            Console.Write("Số ngày trong tháng {0} là 29 ngày.", n);
                    }
                    else
                    {
                        if(n == 1 || n == 3 || n == 5 || n == 7 || n == 8 || n == 10 || n == 12)
                            Console.Write("Số ngày trang tháng {0} là 31 ngày.", n);
                        if(n == 4 || n == 6 || n == 9 || n == 11)
                            Console.Write("Số ngày trong tháng {0} là 30 ngày.", n);
                        if(n == 2) 
                            Console.Write("Số ngày trong tháng {0} là 28 ngày.", n);
                    }
                    check = true;
                }
                catch(FormatException)
                {
                    Console.WriteLine("Lỗi! Vui lòng nhập đúng kiểu dữ liệu");
                }
            }
            
        }
    }
}