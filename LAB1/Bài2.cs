//Viết chương trình Console giải phương trình bậc 1, nhập vào 2 tham số a và b, xuất ra giá trị nghiệm của phương trình.
using System;
using System.Text;
namespace Lệnhrẽnhánh
{
    public class Program
    {
        static void Main(string[]args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            int cnt = 3;
            double a, b;
            Re:
            Console.Write("Nhập tham số a: ");
            if(!double.TryParse(Console.ReadLine(), out a))
            {
                Console.Write("Giá trị không hợp lệ!, vui lòng nhập lại");
                Console.WriteLine("");
                cnt--;
                if(cnt!=0)
                    goto Re;
                else
                    return;
            }
            Re2:
            Console.Write("Nhập tham số b: ");
            if(!double.TryParse(Console.ReadLine(), out b))
            {
                Console.Write("Giá trị không hợp lệ!, vui lòng nhập lại");
                Console.WriteLine("");
                cnt--;
                if(cnt!=0)
                    goto Re2;
                else
                    return;
            }
            if(a==0)
            {
                if(b == 0)
                    Console.Write("PT có vô số nghiệm");
                else
                    Console.Write("PT vô nghiệm");
            }
            else
            {
                double c = -b/a;
                Console.Write("Nghiệm của phương trình là: "+ c);
            }
        }
    }
}