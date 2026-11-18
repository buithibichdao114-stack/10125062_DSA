
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
    // Them phan tu vao cuoi danh sach
    static void ThemCuoi(ref Node head, int x)
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
    static void HienThi(Node head)
    {
        Node p = head;

        while (p != null)
        {
            Console.Write(p.data + " -> ");
            p = p.next;
        }

        Console.WriteLine("null");
    }

    // Gop hai danh sach da sap xep
    static Node GopDanhSach(Node head1, Node head2)
    {
        Node dummy = new Node(0);
        Node tail = dummy;

        Node p = head1;
        Node q = head2;

        while (p != null && q != null)
        {
            if (p.data <= q.data)
            {
                tail.next = p;
                p = p.next;
            }
            else
            {
                tail.next = q;
                q = q.next;
            }

            tail = tail.next;
        }

        if (p != null)
        {
            tail.next = p;
        }

        if (q != null)
        {
            tail.next = q;
        }

        return dummy.next;
    }

    // Nhap danh sach
    static Node NhapDanhSach(string ten)
    {
        Node head = null;

        Console.Write("Nhap so phan tu cua " + ten + ": ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap phan tu thu " + (i + 1) + ": ");
            int x = int.Parse(Console.ReadLine());

            ThemCuoi(ref head, x);
        }

        return head;
    }

    static void Main()
    {
        // 1. Nhap danh sach 1
        Node head1 = NhapDanhSach("danh sach 1");

        // 2. Nhap danh sach 2
        Node head2 = NhapDanhSach("danh sach 2");

        // 3. Hien thi hai danh sach
        Console.WriteLine("\nDanh sach 1:");
        HienThi(head1);

        Console.WriteLine("\nDanh sach 2:");
        HienThi(head2);

        // 4. Gop hai danh sach
        Node headKQ = GopDanhSach(head1, head2);

        // 5. Hien thi ket qua
        Console.WriteLine("\nDanh sach sau khi gop:");
        HienThi(headKQ);
    }
}
