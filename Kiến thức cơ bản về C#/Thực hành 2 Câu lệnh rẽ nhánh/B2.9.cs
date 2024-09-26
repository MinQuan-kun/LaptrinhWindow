/**************************************************************************
B2.9 [GIO_PHUT_GIAY] Nhập vào giờ, phút, giây. Kiểm tra giờ, phút, giây
đó có hợp lệ hay không, nếu hợp lệ hãy cho biết giờ sau đó 1 giây là bao
nhiêu?
– Dữ liệu vào: 3 số nguyên lần lượt là giờ, phút, giây.
– Dữ liệu ra:
+ Dòng đầu xuất "YES" nếu hợp lệ, ngược lại xuất "NO" nếu không
hợp lệ.
+ Dòng thứ hai xuất giờ sau đó 1 giây nếu hợp lệ.
**************************************************************************/
using System;
using System.Text;
namespace GIO_PHUT_GIAY
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
            int c = 0;
            while(!check)
            {
                Console.Write("Nhập giờ: ");
                try
                {
                    a = int.Parse(Console.ReadLine());
                    if(a < 0 || a > 24)
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                    Console.Write("Nhập phút: ");
                    b = int.Parse(Console.ReadLine());
                    if(b < 0 || b > 60)
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                    Console.Write("Nhập phút: ");
                    c = int.Parse(Console.ReadLine());
                    if(c < 0 || c > 60)
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                    check = true;
                }
                catch(FormatException)
                {
                    Console.WriteLine("NO");
                }
            }
            c += 1;
            if(c >= 60)
            {
                c = c-60;
                b += 1;
                if(b >= 60)
                {
                    b = b - 60;
                    a += 1;
                    if(a >= 24)
                        a = a - 24;
                }
            }
            Console.WriteLine("YES");
            if(a >= 10)
            {
                if(b >= 10)
                {
                    if(c >= 10)
                        Console.WriteLine("{0}:{1}:{2}",a , b ,c);
                    else
                        Console.WriteLine("{0}:{1}:0{2}",a , b ,c);
                }
                else
                {
                    if(c >= 10)
                        Console.WriteLine("{0}:0{1}:{2}",a , b ,c);
                    else
                        Console.WriteLine("{0}:0{1}:0{2}",a , b ,c);
                }
            }
            else
            {
                if(b >= 10)
                {
                    if(c >= 10)
                        Console.WriteLine("0{0}:{1}:{2}",a , b ,c);
                    else
                        Console.WriteLine("0{0}:{1}:0{2}",a , b ,c);
                }
                else
                {
                    if(c >= 10)
                        Console.WriteLine("0{0}:0{1}:{2}",a , b ,c);
                    else
                        Console.WriteLine("0{0}:0{1}:0{2}",a , b ,c);
                }
            }
        }
    }
}