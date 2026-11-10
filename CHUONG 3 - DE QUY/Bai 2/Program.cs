using System;
class Program
{
    static double S (int n)
    {
        if (n == 1)
        {
            return 1;
        }
        else
        {
            return S(n - 1) + n * n;
        }    
    }
    static void Main(string[] args)
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int n;
        Console.Write("Nhập n: ");
        n = int.Parse(Console.ReadLine());
        if (n < 1)
        {
            Console.WriteLine(" Vui lòng nhập n>=1:");
        }    
        else
        {
            double kq = S(n);
            Console.WriteLine("Tổng bình phương S{0} = {1}", n, kq);
        }    

    }
}
