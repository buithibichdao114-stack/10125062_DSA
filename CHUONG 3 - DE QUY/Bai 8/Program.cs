using System;
class Program
{
    static double Can(int i, int n)
    {
        if (i == n)
        {
            return Math.Sqrt(n);
        }
        else
        {
            return Math.Sqrt(i + Can(i + 1, n));
        }
    }
    static double S(int n)
    {
        return Can(1, n);
    }
    static void Main(string[] args)
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int i, n;
        Console.Write("Nhập i: ");
        i = int.Parse(Console.ReadLine());
        Console.Write("Nhập n: ");
        n = int.Parse(Console.ReadLine());
        if (i < 1 || n < 1 || i > n)
        {
            Console.WriteLine("Vui lòng nhập i, n > 0 và i <= n!");
        }
        else
        {
            double kq = Can(i, n);

            Console.WriteLine("Giá trị căn lồng nhau từ {0} đến {1} là: {2}", i, n, kq);
        }

        Console.ReadKey();
    }
}
