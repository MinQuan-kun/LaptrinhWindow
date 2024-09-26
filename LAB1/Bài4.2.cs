//2. Viết chương trình nhập vào họ tên đầy đủ. Xuất ra từng phần gồm họ, tên lót, tên.
using System;
using System.Text;
namespace Chuỗi
{
    public class Program
    {
        static void Main(string[]args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập họ tên đầy đủ của bạn: ");
            string[] Name = Console.ReadLine().Split(' ');
            Console.WriteLine("Họ của bạn là: " + Name[0]);
            Console.WriteLine("Tên lót của bạn là: " + Name[1]);
        }
    }
}

/*Code của thầy
public static void Main(string[]args)
{
    Console.WriteLine("Nhap ho ten dau du.Xuat ra tung phan.");
    Console.WriteLine();

    Console.Write("Nhap ho ten: ");
    string fullname = Console.ReadLine();

    string Space = " ";
    string[] parts = fullname.Split(new string[] {Space}, StringSplitOptions.None);
    
    Console.WriteLine("Ho: {0}, tenlot: {1}, ten: {2}", parts[0], parts[1], parts[2]);

    Console.ReadKey(true);
}



*/