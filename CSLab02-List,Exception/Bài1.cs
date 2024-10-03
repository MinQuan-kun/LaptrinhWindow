//Viết chương trình nhập các số nguyên x và y từ bàn phím. Sau đó tính giá trị biểu thức sau và xuất ra màn hình (có xử lý các ngoại lệ có thể xảy ra).
//H = √3x + 2y 2x − y
using System;
using System.Text;
namespace Tínhtoán
{
    public class NOTNegativeException : Exception
    {
        public NOTNegativeException()
            : base("Giá trị dưới dấu căn < 0")
        {}
    }
    public class Program
    {
        static void Main(string[]args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8; 
            try
            {
            Console.Write("Nhập tham số x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhập thâm số y: ");
            int y = int.Parse(Console.ReadLine());
            int tu = 3 * x + 2 * y;
            int mau = 2 * x - y;
            double value = tu / mau;
            if(value < 0)
                throw new NOTNegativeException();
            double res = Math.Sqrt(value);
            Console.WriteLine("Giá trị của biểu thức H là: " + res);
            }
            catch (DivideByZeroException) 
            {
                Console.WriteLine("Lỗi!: Không thể chia cho 0");
            }
            catch (FormatException)
            {
                Console.WriteLine("Lỗi!: Định dạng không đúng.");
            }
            catch(NOTNegativeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
