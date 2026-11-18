
using System;

class Program
{
    static int[,] a;
    static int n;

    // Nhap ma tran
    static void Nhap()
    {
        Console.Write("Nhap cap ma tran n: ");
        n = int.Parse(Console.ReadLine());

        if (n <= 0 || n >= 100)
        {
            Console.WriteLine("n khong hop le!");
            return;
        }

        a = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("a[{0},{1}] = ", i, j);
                a[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    // Hien thi ma tran
    static void HienThi()
    {
        Console.WriteLine("\nMa tran vua nhap:");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(a[i, j] + "\t");
            }

            Console.WriteLine();
        }
    }

    // a. Tinh tong cac phan tu
    static void TongMaTran()
    {
        int tong = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                tong += a[i, j];
            }
        }

        Console.WriteLine("\nTong ma tran = " + tong);
    }

    // b. Tim so duong nho nhat
    static void SoDuongNhoNhat()
    {
        int min = int.MaxValue;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (a[i, j] > 0 && a[i, j] < min)
                {
                    min = a[i, j];
                }
            }
        }

        if (min == int.MaxValue)
        {
            Console.WriteLine("\nMa tran khong co so duong.");
        }
        else
        {
            Console.WriteLine("\nSo duong nho nhat = " + min);
        }
    }

    // c. Tinh tong duong cheo phu
    static void TongCheoPhu()
    {
        int tong = 0;

        for (int i = 0; i < n; i++)
        {
            int j = n - 1 - i;
            tong += a[i, j];
        }

        Console.WriteLine("\nTong duong cheo phu = " + tong);
    }

    // d. Kiem tra duong cheo chinh tang dan
    static bool KiemTraTangDan()
    {
        for (int i = 0; i < n - 1; i++)
        {
            if (a[i, i] >= a[i + 1, i + 1])
            {
                return false;
            }
        }

        return true;
    }

    static void Main()
    {
        Nhap();

        if (a == null)
        {
            return;
        }

        HienThi();
        TongMaTran();
        SoDuongNhoNhat();
        TongCheoPhu();

        if (KiemTraTangDan())
        {
            Console.WriteLine("\nDuong cheo chinh tang dan.");
        }
        else
        {
            Console.WriteLine("\nDuong cheo chinh khong tang dan.");
        }
    }
}
