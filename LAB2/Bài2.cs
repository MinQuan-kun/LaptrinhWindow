//Viết chương trình phát sinh ngẫu nhiên một dãy n (n > 0) số nguyên, sau đó sắp xếp dãy số tăng dần và xuất ra màn hình. Chú ý: dùng lớp List để lưu trữ mảng số nguyên vừa phát sinh.
using System;
using System.Text;
using System.Collections.Generic;
namespace Dãysốngẫunhiên
{
    public class Program
    {
        static void Main(string[]args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            List<int> Arr = new List<int>();
            const int N = 100;
            int[] a = new int[N];
            Random rnd = new Random((int)DateTime.Now.Ticks);
            for(int i = 0; i < N; i++)
            {
                a[i] = rnd.Next(1000);
                Arr.Add(a[i]);
            }
            Arr.Sort();
            Console.WriteLine("Dãy số sau khi sắp xếp tăng dần: ")
            foreach (int num in Arr)
            {
                Console.Write("{0}, ", num);
            }
        }
    }
}