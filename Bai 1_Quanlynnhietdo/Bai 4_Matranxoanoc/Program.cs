
using System;

class Program
{
    static void Main()
    {
        // 1. Nhap so dong va so cot
        Console.Write("Nhap so dong m: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Nhap so cot n: ");
        int n = int.Parse(Console.ReadLine());

        // 2. Khai bao ma tran
        int[,] a = new int[m, n];

        // 3. Nhap ma tran
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("a[" + i + "," + j + "] = ");
                a[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // 4. In ma tran ban dau
        Console.WriteLine("\nMa tran vua nhap:");

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(a[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // 5. Khoi tao 4 bien bien
        int top = 0;
        int bottom = m - 1;
        int left = 0;
        int right = n - 1;

        // 6. In ma tran xoan oc
        Console.WriteLine("\nMa tran theo thu tu xoan oc:");

        while (top <= bottom && left <= right)
        {
            // Huong 1: Trai sang phai
            for (int j = left; j <= right; j++)
            {
                Console.Write(a[top, j] + " ");
            }
            top++;

            // Huong 2: Tren xuong duoi
            for (int i = top; i <= bottom; i++)
            {
                Console.Write(a[i, right] + " ");
            }
            right--;

            // Huong 3: Phai sang trai
            if (top <= bottom)
            {
                for (int j = right; j >= left; j--)
                {
                    Console.Write(a[bottom, j] + " ");
                }
                bottom--;
            }

            // Huong 4: Duoi len tren
            if (left <= right)
            {
                for (int i = bottom; i >= top; i--)
                {
                    Console.Write(a[i, left] + " ");
                }
                left++;
            }
        }
    }
}
