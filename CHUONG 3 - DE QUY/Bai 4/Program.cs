using System;
using System.Reflection;
class Program
{
    static double LuyThua(double x,int n)
    {
        if (n == 0)
        {
            return 1;
        } 
        else
        {
            return LuyThua(x, n - 1) * x;
        }
    }
    static double S(double x, int n)
    {
        if (n < 0)
        {
            return 1.0 / LuyThua(x,-n);
        }
        else
        {
            return LuyThua(x,n);
        }
    }
   
    static void Main(string[] args)
    {
        double x;
        int n;
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập x: ");
        x = double.Parse(Console.ReadLine());
        Console.Write("Nhập n: ");
        n = int.Parse(Console.ReadLine());
        if (x==0 && n < 0)
        {
            Console.WriteLine("Không thể tính 0 mũ số âm!");
        } 
        else
        {
            double kq;
            if ( n<0)
            {
                kq = 1.0 / LuyThua(x, -n);
            }
            else
            {
                kq = LuyThua(x, n);
            }

            Console.WriteLine("{0}^{1} = {2}", x, n, kq);
        }
        Console.ReadKey();
    }
}
