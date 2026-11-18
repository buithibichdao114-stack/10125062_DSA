
using System;

class Program
{
    // Ham kiem tra ma tran don vi
    static bool LaMaTranDonVi(int[,] a, int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == j && a[i, j] != 1)
                {
                    return false;
                }

                if (i != j && a[i, j] != 0)
                {
                    return false;
                }
            }
        }

        return true;
    }

    // Ham kiem tra ma tran doi xung
    static bool LaMaTranDoiXung(int[,] a, int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (a[i, j] != a[j, i])
                {
                    return false;
                }
            }
        }

        return true;
    }

    static void Main()
    {
        // 1. Nhap cap ma tran
        Console.Write("Nhap cap ma tran n: ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Cap ma tran phai > 0");
            return;
        }

        // 2. Khai bao ma tran
        int[,] a = new int[n, n];

        // 3. Nhap ma tran
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("a[" + i + "," + j + "] = ");
                a[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // 4. Hien thi ma tran
        Console.WriteLine("\nMa tran vua nhap:");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(a[i, j] + "\t");
            }

            Console.WriteLine();
        }

        // 5. Kiem tra ma tran don vi
        Console.WriteLine("\nKiem tra ma tran don vi:");

        if (LaMaTranDonVi(a, n))
        {
            Console.WriteLine("Day la ma tran don vi");
        }
        else
        {
            Console.WriteLine("Day khong phai ma tran don vi");
        }

        // 6. Kiem tra ma tran doi xung
        Console.WriteLine("\nKiem tra ma tran doi xung:");

        if (LaMaTranDoiXung(a, n))
        {
            Console.WriteLine("Day la ma tran doi xung");
        }
        else
        {
            Console.WriteLine("Day khong phai ma tran doi xung");
        }
    }
}
