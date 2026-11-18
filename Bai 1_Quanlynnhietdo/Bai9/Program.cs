
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

    // Tao chu trinh tai vi tri cho truoc
    static void TaoChuTrinh(Node head, int viTri)
    {
        if (head == null)
            return;

        Node p = head;
        Node nutDich = null;
        int i = 0;

        while (p.next != null)
        {
            if (i == viTri)
                nutDich = p;

            p = p.next;
            i++;
        }

        if (i == viTri)
            nutDich = p;

        if (nutDich != null)
            p.next = nutDich;
    }

    // Kiem tra chu trinh bang thuat toan Floyd
    static bool KiemTraChuTrinh(Node head)
    {
        Node slow = head;
        Node fast = head;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;

            if (slow == fast)
            {
                return true;
            }
        }

        return false;
    }

    static void Main()
    {
        Node head = null;

        // 1. Nhap danh sach
        Console.Write("Nhap so phan tu: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap phan tu thu " + (i + 1) + ": ");
            int x = int.Parse(Console.ReadLine());

            ThemCuoi(ref head, x);
        }

        // 2. Tao chu trinh de thu nghiem
        if (n >= 3)
        {
            TaoChuTrinh(head, 2);
        }

        // 3. Kiem tra chu trinh
        if (KiemTraChuTrinh(head))
        {
            Console.WriteLine("Danh sach CO chu trinh.");
        }
        else
        {
            Console.WriteLine("Danh sach KHONG co chu trinh.");
        }
    }
}
