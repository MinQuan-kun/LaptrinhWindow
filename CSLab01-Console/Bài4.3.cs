//3. Viết chương trình nhập vào họ tên hoa thường không đúng qui tắc, khoảng trắng không đúng (có nhiều hơn 1 khoảng trắng). Xuất ra màn hình họ tên theo dạng chuẩn.
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
            Console.Write("Nhập họ tên không đúng quy tắc của bạn: ");
            string input = Console.ReadLine();

            // Xóa khoảng trắng thừa và chuẩn hóa họ tên
            string[] nameParts = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < nameParts.Length; i++)
            {
                // In hoa chữ cái đầu của từng phần
                nameParts[i] = char.ToUpper(nameParts[i][0]) + nameParts[i].Substring(1).ToLower();
            }

            // Nối lại các phần thành một chuỗi duy nhất
            string formattedName = string.Join(" ", nameParts);
            Console.WriteLine("Họ tên theo dạng chuẩn: " + formattedName);
            
        }
    }
}
