
using System;

class Node
{
    public int data;
    public Node next;

    public Node(int x)
    {
        data = x;
        next = null;
    }
}

class Program
{
    static Node head = null;

    // Them phan tu vao cuoi danh sach
    static void ThemCuoi(int x)
    {
        Node p = new Node(x);

        if (head == null)
        {
            head = p;
        }
        else
        {
            Node q = head;

            while (q.next != null)
            {
                q = q.next;
            }

            q.next = p;
        }
    }

    // Hien thi danh sach
    static void HienThi()
    {
        Node p = head;

        while (p != null)
        {
            Console.Write(p.data + " -> ");
            p = p.next;
        }

        Console.WriteLine("null");
    }

    // Dao nguoc danh sach khong dung de quy
    static void DaoNguoc()
    {
        Node previous = null;
        Node current = head;
        Node next = null;

        while (current != null)
        {
            next = current.next;

            current.next = previous;

            previous = current;

            current = next;
        }

        head = previous;
    }

    static void Main()
    {
        // 1. Nhap danh sach
        Console.Write("Nhap so luong phan tu: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap phan tu thu " + (i + 1) + ": ");
            int x = int.Parse(Console.ReadLine());

            ThemCuoi(x);
        }

        // 2. Hien thi danh sach ban dau
        Console.WriteLine("\nDanh sach ban dau:");
        HienThi();

        // 3. Dao nguoc danh sach
        DaoNguoc();

        // 4. Hien thi danh sach sau khi dao nguoc
        Console.WriteLine("\nDanh sach sau khi dao nguoc:");
        HienThi();
    }
}
