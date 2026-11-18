
using System;

class Program
{
    static void Main()
    {
        // 1. Nhap kich thuoc bang
        Console.Write("Nhap so dong m: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Nhap so cot n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Nhap so luong min k: ");
        int k = int.Parse(Console.ReadLine());

        if (m <= 0 || n <= 0 || k < 0 || k > m * n)
        {
            Console.WriteLine("Du lieu khong hop le!");
            return;
        }

        // 2. Khai bao ma tran
        int[,] a = new int[m, n];

        // 3. Dat min ngau nhien
        Random rd = new Random();

        int demMin = 0;

        while (demMin < k)
        {
            int i = rd.Next(0, m);
            int j = rd.Next(0, n);

            if (a[i, j] != -1)
            {
                a[i, j] = -1;
                demMin++;
            }
        }

        // 4. Tinh so min xung quanh moi o
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                // Neu la o co min thi bo qua
                if (a[i, j] == -1)
                {
                    continue;
                }

                int dem = 0;

                // Duyet 8 huong xung quanh
                for (int dx = -1; dx <= 1; dx++)
                {
                    for (int dy = -1; dy <= 1; dy++)
                    {
                        if (dx == 0 && dy == 0)
                        {
                            continue;
                        }

                        int x = i + dx;
                        int y = j + dy;

                        // Kiem tra vi tri co nam trong ma tran
                        if (x >= 0 && x < m &&
                            y >= 0 && y < n)
                        {
                            if (a[x, y] == -1)
                            {
                                dem++;
                            }
                        }
                    }
                }

                a[i, j] = dem;
            }
        }

        // 5. In bang Minesweeper
        Console.WriteLine("\nBang Minesweeper:");

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (a[i, j] == -1)
                {
                    Console.Write("*\t");
                }
                else
                {
                    Console.Write(a[i, j] + "\t");
                }
            }

            Console.WriteLine();
        }
    }
}
