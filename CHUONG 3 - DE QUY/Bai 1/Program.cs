using System.IO;
using System;
class Program
{
    // Hàm đệ quy tính tổng từ 1 đến n
    static int S (int n)
    {
        if (n == 1)
        {
            return 1;
        } 
        else
        {
            return S(n - 1) + n;
        }    
    }
    static void Main(string[]args)
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int n;
        Console.Write("Nhập n: ");
        n = int.Parse(Console.ReadLine());
        if (n<1)
        {
            Console.WriteLine("Vui lòng nhập n>=1: ");
        }
        else
        {
            int Kq = S(n);
            Console.WriteLine("Tổng S{0} = {1} ", n, Kq);
        }
    }
}

