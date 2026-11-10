using System;
class Program
{
    static int UocleMax(int n)
    {
        if (n%2 != 0)
        {
            return n;
        }    
        else
        {
            return UocleMax(n / 2);
        }    
    }
    static void Main(string[] args)
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int n;
        Console.Write("Nhập n: ");
        n = int.Parse(Console.ReadLine());
        if (n <= 0)
        {
            Console.WriteLine(" Vui lòng nhập số nguyên dương");
        }
        else
        {
            int kq = UocleMax(n);
            Console.WriteLine("Ước lẻ lớn nhất của {0} là {1}", n, kq);
        }
        Console.ReadKey();
    }
}
