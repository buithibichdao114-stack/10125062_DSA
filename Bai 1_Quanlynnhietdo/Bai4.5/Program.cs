
using System;

class Node
{
    public int Data;
    public Node Next;

    public Node(int x)
    {
        Data = x;
        Next = null;
    }
}

class Program
{
    static Node pHead = null;

    // Them phan tu vao cuoi danh sach
    static void ThemCuoi(int x)
    {
        Node p = new Node(x);

        if (pHead == null)
        {
            pHead = p;
            return;
        }

        Node q = pHead;

        while (q.Next != null)
        {
            q = q.Next;
        }

        q.Next = p;
    }

    // Nhap danh sach
    static void Nhap()
    {
        Console.Write("Nhap so nut n: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap gia tri nut thu {0}: ", i + 1);
            int x = int.Parse(Console.ReadLine());

            ThemCuoi(x);
        }
    }

    // Hien thi danh sach
    static void HienThi()
    {
        Node p = pHead;

        while (p != null)
        {
            Console.Write(p.Data + " -> ");
            p = p.Next;
        }

        Console.WriteLine("NULL");
    }

    // Kiem tra so nguyen to
    static bool KiemTraNguyenTo(int x)
    {
        if (x < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(x); i++)
        {
            if (x % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    // a. Tim phan tu lon nhat
    static int TimMax()
    {
        int max = int.MinValue;
        Node p = pHead;

        while (p != null)
        {
            if (p.Data > max)
            {
                max = p.Data;
            }

            p = p.Next;
        }

        return max;
    }

    // b. Tinh tong cac phan tu
    static long TinhTong()
    {
        long tong = 0;
        Node p = pHead;

        while (p != null)
        {
            tong += p.Data;
            p = p.Next;
        }

        return tong;
    }

    // c. Dem so nguyen to
    static int DemSoNguyenTo()
    {
        int dem = 0;
        Node p = pHead;

        while (p != null)
        {
            if (KiemTraNguyenTo(p.Data))
            {
                dem++;
            }

            p = p.Next;
        }

        return dem;
    }

    // d. Dem so am, so 0, so duong
    static void DemAmDuongKhong()
    {
        int am = 0;
        int khong = 0;
        int duong = 0;

        Node p = pHead;

        while (p != null)
        {
            if (p.Data < 0)
            {
                am++;
            }
            else if (p.Data == 0)
            {
                khong++;
            }
            else
            {
                duong++;
            }

            p = p.Next;
        }

        Console.WriteLine("So am: " + am);
        Console.WriteLine("So bang 0: " + khong);
        Console.WriteLine("So duong: " + duong);
    }

    // e. Dem so phan tu bang x
    static int DemX(int x)
    {
        int dem = 0;
        Node p = pHead;

        while (p != null)
        {
            if (p.Data == x)
            {
                dem++;
            }

            p = p.Next;
        }

        return dem;
    }

    // f. Tim so duong nho nhat
    static int TimMinDuong()
    {
        int min = int.MaxValue;
        Node p = pHead;

        while (p != null)
        {
            if (p.Data > 0 && p.Data < min)
            {
                min = p.Data;
            }

            p = p.Next;
        }

        return min;
    }

    static void Main()
    {
        Nhap();

        Console.WriteLine("\nDanh sach vua nhap:");
        HienThi();

        // a
        if (pHead == null)
        {
            Console.WriteLine("Danh sach rong, khong co phan tu lon nhat.");
            Console.WriteLine("Tong = 0");
            Console.WriteLine("So luong so nguyen to = 0");
            Console.WriteLine("So am = 0, so 0 = 0, so duong = 0");
            Console.WriteLine("So lan xuat hien cua x = 0");
            Console.WriteLine("Danh sach khong co so duong.");
            return;
        }

        Console.WriteLine("\na. Phan tu lon nhat: " + TimMax());

        // b
        Console.WriteLine("\nb. Tong cac phan tu: " + TinhTong());

        // c
        Console.WriteLine("\nc. So luong so nguyen to: " + DemSoNguyenTo());

        // d
        Console.WriteLine("\nd. Thong ke am, khong, duong:");
        DemAmDuongKhong();

        // e
        Console.Write("\nNhap x can dem: ");
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine("So lan xuat hien cua " + x + ": " + DemX(x));

        // f
        int min = TimMinDuong();

        if (min == int.MaxValue)
        {
            Console.WriteLine("\nf. Danh sach khong co so duong.");
        }
        else
        {
            Console.WriteLine("\nf. So duong nho nhat: " + min);
        }
    }
}
