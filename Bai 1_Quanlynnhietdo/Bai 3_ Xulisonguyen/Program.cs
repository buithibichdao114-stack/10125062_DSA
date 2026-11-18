
using System;
using System.Collections.Generic;

class Program
{
    // kiem tra so nguyen to
    static bool LaSoNguyenTo(int n)
    {
        if (n < 2)
        {
            return false;
        }

        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    // kiem tra so hoan hao
    static bool LaSoHoanHao(int n)
    {
        if (n <= 1)
        {
            return false;
        }

        int tong = 0;

        for (int i = 1; i < n; i++)
        {
            if (n % i == 0)
            {
                tong += i;
            }
        }

        return tong == n;
    }

    static void Main()
    {
        // 1. Nhap mang
        Console.Write("Nhap so luong phan tu: ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("So luong phan tu phai > 0");
            return;
        }

        int[] a = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("a[" + i + "] = ");
            a[i] = int.Parse(Console.ReadLine());
        }

        // 2. Tao danh sach phan loai
        List<int> nguyenTo = new List<int>();
        List<int> soChan = new List<int>();
        List<int> hoanHao = new List<int>();

        // 3. Phan loai cac so
        for (int i = 0; i < n; i++)
        {
            if (LaSoNguyenTo(a[i]))
            {
                nguyenTo.Add(a[i]);
            }

            if (a[i] % 2 == 0)
            {
                soChan.Add(a[i]);
            }

            if (LaSoHoanHao(a[i]))
            {
                hoanHao.Add(a[i]);
            }
        }

        // 4. Hien thi ket qua
        Console.WriteLine("\n--- KET QUA THONG KE ---");

        Console.WriteLine("Cac so nguyen to:");
        Console.WriteLine(string.Join(", ", nguyenTo));
        Console.WriteLine("So luong: " + nguyenTo.Count);

        Console.WriteLine("\nCac so chan:");
        Console.WriteLine(string.Join(", ", soChan));
        Console.WriteLine("So luong: " + soChan.Count);

        Console.WriteLine("\nCac so hoan hao:");
        Console.WriteLine(string.Join(", ", hoanHao));
        Console.WriteLine("So luong: " + hoanHao.Count);
    }
}
