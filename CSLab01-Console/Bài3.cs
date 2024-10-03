//Viết chương trình nhập một mảng số nguyên, Sau đó thực hiện các yêu cầu:
//o Xuất ra tổng của mảng.
//o Xuất ra số nguyên lớn nhất trong mảng.
//o Xuất ra số nguyên nhỏ nhất trong mảng.

using System;
using System.Text;
namespace Mảng
{
    public class Program
    {
        static void Main(string[]args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập mảng số nguyên: ");
            string[] input= Console.ReadLine().Split(' ');
            int n = input.Length;
            int[] Ar = new int[n];
            int sum = 0;
            for(int i = 0; i < n; i++)
            {
                Ar[i] = int.Parse(input[i]);
                sum += Ar[i];
            }
            Console.WriteLine("Tổng số nguyên trong mảng là: " + sum);
            FindMax(Ar);
            Findmin(Ar);
            
        }
        static void FindMax(int[] Ar)
        {
            int max = Ar[0];
            for(int i = 1; i < Ar.Length; i++)
                if(max < Ar[i])
                    max=Ar[i];
            Console.WriteLine("Số nguyên lớn nhất trong mảng là: " + max);
        }
        static void Findmin(int[] Ar)
        {
            int min = Ar[0];
            for(int i = 1; i < Ar.Length; i++)
                if(min > Ar[i])
                    min=Ar[i];
            Console.WriteLine("Số nguyên nhỏ nhất trong mảng là: " + min);
        }
    }
}