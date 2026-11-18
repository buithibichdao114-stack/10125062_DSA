
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

    // Them mot phan tu vao cuoi danh sach
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

    // a. Dem so phan tu bang x
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

    // b. Tim so duong nho nhat
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

    // c. Xoa phan tu x xuat hien dau tien
    static void XoaX(int x)
    {
        Node p = pHead;
        Node t = null;

        while (p != null)
        {
            if (p.Data == x)
            {
                // Neu x nam o nut dau tien
                if (t == null)
                {
                    pHead = p.Next;
                }
                else
                {
                    t.Next = p.Next;
                }

                Console.WriteLine("Da xoa phan tu " + x);
                return;
            }

            t = p;
            p = p.Next;
        }

        Console.WriteLine("Khong tim thay " + x);
    }

    static void Main()
    {
        Nhap();

        Console.WriteLine("\nDanh sach vua nhap:");
        HienThi();

        Console.Write("\nNhap x can dem: ");
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine("So lan xuat hien cua x: " + DemX(x));

        int min = TimMinDuong();

        if (min == int.MaxValue)
        {
            Console.WriteLine("Danh sach khong co so duong.");
        }
        else
        {
            Console.WriteLine("So duong nho nhat: " + min);
        }

        Console.Write("\nNhap x can xoa: ");
        int y = int.Parse(Console.ReadLine());

        XoaX(y);

        Console.WriteLine("Danh sach sau khi xoa:");
        HienThi();
    }
}
