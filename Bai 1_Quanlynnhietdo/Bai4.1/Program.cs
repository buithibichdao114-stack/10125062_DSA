
using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap so phan tu n: ");
        int n = int.Parse(Console.ReadLine());

        int[] a = new int[n];

        // a. Nhap mang
        for (int i = 0; i < n; i++)
        {
            Console.Write("a[{0}] = ", i);
            a[i] = int.Parse(Console.ReadLine());
        }

        // b. Hien thi mang
        Console.WriteLine("Mang vua nhap:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(a[i] + " ");
        }

        // c. Chen x vao vi tri k
        Console.Write("\nNhap gia tri x: ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Nhap vi tri k (0 den {0}): ", n);
        int k = int.Parse(Console.ReadLine());

        if (k < 0 || k > n)
        {
            Console.WriteLine("Vi tri k khong hop le!");
        }
        else
        {
            int[] tmp = new int[n + 1];

            // Sao chep cac phan tu truoc k
            for (int i = 0; i < k; i++)
            {
                tmp[i] = a[i];
            }

            // Chen x vao vi tri k
            tmp[k] = x;

            // Sao chep cac phan tu tu k tro di
            for (int i = k; i < n; i++)
            {
                tmp[i + 1] = a[i];
            }

            // Gan mang tam cho mang a
            a = tmp;

            Console.WriteLine("Mang sau khi chen:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
    }
}
