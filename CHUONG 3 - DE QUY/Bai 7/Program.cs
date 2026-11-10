using System;
class Program
{
    static int SoChuSo(int n)
    {
        if ( n==0)
        {
            return 0;
        }    
        else
        {
            return SoChuSo(n / 10) + 1;
        }    
    }
    static void Main(string[] args)
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int n;
        Console.Write("Nhập n: ");
        n = int.Parse(Console.ReadLine());
        if (n<0)
        {
            Console.WriteLine(" Vui lòng nhập số nguyên dương");
        }    
        else
        {
            int kq = SoChuSo(n);
            Console.WriteLine("Số chữ số của {0} là {1}", n, kq);
        }
        Console.ReadKey();
    }
}