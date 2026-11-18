using System;
using System.Text;
using System.Linq;
class Program
{ 
    static void Main()
    {
        // Nhập chuỗi
        Console.Write("Nhap: ");
        string s = Console.ReadLine();

        // Chuẩn hóa chuỗi
        s = s.ToLower();

        StringBuilder sb = new StringBuilder();// Xây dựng  và thay đổi chuỗi

        foreach (char c in s)
        {
            if (char.IsLetterOrDigit(c))//Kiểm tra xem kí tự có phải chữ cái or số
            {
                sb.Append(c);
            }
            else
            {
                sb.Append(' ');
            }
        }

        s = sb.ToString();
        // Tách chuỗi thành mảng
        string[] words = s.Split(new char[] { ' ' },
        StringSplitOptions.RemoveEmptyEntries);// Xóa phần tử rỗng

        //Dùng dictionary để đếm
        Dictionary<string, int> dem = new Dictionary<string, int>();
        foreach (string word in words)
        {
            if (dem.ContainsKey(word))
            {
                dem[word]++;
            }
            else
            {
                dem[word] = 1;
            }
        }
        //Sắp xếp, hiển thị kết quả
        Console.WriteLine("\nThong ke so lan xuat hien:");

        foreach (var item in dem.OrderBy(x => x.Key))
        {
            Console.WriteLine(item.Key + ": " + item.Value);
        }
    }

}