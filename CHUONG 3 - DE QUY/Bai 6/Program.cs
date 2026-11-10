using System;
class Program
{
    static int UCLN( int a, int b)
    {
        if (a%b== 0)
        {
            return b;
        }  
        else
        {
            return UCLN(b, a % b);
        }    
    }
    static void Main(string[] args)
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int a,b;
        Console.Write("Nhập a: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Nhập b: ");
        b = int.Parse(Console.ReadLine());
        if (a <= 0 || b <= 0)
        {
            Console.WriteLine(" Vui lòng nhập số nguyên dương");
        }
        else
        {
            int kq = UCLN(a,b);
            Console.WriteLine("Ước chung lớn nhất của {0} và {1} là {2}", a,b, kq);
        }
        Console.ReadKey();
    }
}
