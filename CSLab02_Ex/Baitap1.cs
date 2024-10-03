//Viết 1 ứng dụng Console thực hiện các chức năng sau với List, ArrayList hoặc Hashtable
// Nhập các tên hàng hóa (kiểu chuổi) từ bàn phím, thêm vào List/ArrayList khi nào
//người dùng nhập vào chuổi “stop” thì ngừng.
// Xuất các hàng hóa ra màn hình.
// Nhập vào tên một hàng hóa, tiến hành tìm kiếm theo tên, trả về true nếu tìm thấy,
//ngược lại trả về false
// Xóa một hàng hóa.
// Thêm 1 hàng hóa vào vị trí index bất kỳ với index nhập từ bàn phím.
using System;
using System.Text;
using System.Collections.Generic;
namespace Baitap01
{
    public class Program
    {
           static void Main(string[]args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            List<string> listproduct = new List<string>();
            string temp = "";
            int index;
            while (true)
            {
                Console.Write("Nhập tên hàng hóa cần thêm : ");
                temp = Console.ReadLine().Trim();
                if (temp.ToUpper() == "STOP")
                    break;
                listproduct.Add(temp);
            }
            Console.WriteLine("Danh sách hiện tại");
            foreach (string str in listproduct)
                Console.WriteLine(str);
            find:
            temp = "";
            //Nhập mặt hàng cần tìm
            while(string.IsNullOrWhiteSpace(temp))
            {
                Console.Write("Nhập mặt hàng cần tìm : ");
                temp = Console.ReadLine().Trim();
            }
            string choice = "";
            bool check = false;
            if (listproduct.Contains(temp)) 
            {
                Console.Write("Mặt hàng này có tồn tại trong kho, bạn có muốn xóa nó khỏi danh sách không (Y/N): ");
                choice = Console.ReadLine().Trim();
                while(!check)
                {
                    if(choice.ToUpper() == "Y" )
                    {
                        listproduct.Remove(temp);
                        Console.WriteLine("Đã xóa!");
                        check = true;
                        Console.WriteLine("Danh sách hiện tại");
                        foreach (string str in listproduct)
                            Console.WriteLine(str);
                    }
                    else if(choice.ToUpper() == "N")
                    {
                        goto Nextstep;
                        check = true;
                    }
                    else
                        Console.WriteLine("Lỗi! Vui lòng hãy chọn lại"); 
                }   
            } 
            else
            {
                Console.Write("Không tìm thấy!Bạn có muốn tìm mặt hàng khác không ? (Y/N): ");
                choice = Console.ReadLine().Trim();
                if(choice.ToUpper() == "Y")
                    goto find;
                if(choice.ToUpper() == "N")
                    goto Nextstep;
            }
            Nextstep:
            temp = "";
            check = false;
            Console.Write("\nNhập vị trí cần thêm hàng hóa: ");
            while (!int.TryParse(Console.ReadLine(), out index) || index < 0 || index > listproduct.Count)
            {
                Console.WriteLine("Vui lòng nhập một vị trí hợp lệ (0 đến {0}):", listproduct.Count);
            }
            Console.Write("Nhập tên hàng hóa cần thêm: ");
            temp = Console.ReadLine().Trim();
            listproduct.Insert(index, temp);
            // Xuất danh sách hàng hóa sau khi thêm
            Console.WriteLine("\nDanh sách hàng hóa sau khi thêm:");
            foreach (string str in listproduct)
                Console.WriteLine(str);
        } 
    }
    
}   