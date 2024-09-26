//Nhập vào 1 số nguyên là tháng. Xuất ra số ngày trong tháng đó. Lưu ý: tháng 2 mặc định lấy 28 ngày.
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
            while(!check)
            {
                Console.Write("Nhập số nguyên là 1 tháng: ");
                try
                {
                    int n = int.Parse(Console.ReadLine());
                    if(n == 1 || n == 3 || n == 5 || n == 7 || n == 8 || n == 10 || n == 12)
                        Console.Write("Số ngày trang tháng {0} là 31 ngày.", n);
                    if(n == 4 || n == 6 || n == 9 || n == 11)
                        Console.Write("Số ngày trong tháng {0} là 30 ngày.", n);
                    if(n == 2) 
                        Console.Write("Số ngày trong tháng {0} là 28 ngày.", n);
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