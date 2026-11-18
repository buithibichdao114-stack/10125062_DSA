
using System;

class Node
{
    public string data;
    public Node prev;
    public Node next;

    public Node(string ten)
    {
        data = ten;
        prev = null;
        next = null;
    }
}

class Program
{
    static Node head = null;
    static Node tail = null;
    static Node current = null;

    // Them bai hat
    static void ThemBaiHat(string ten)
    {
        Node p = new Node(ten);

        if (head == null)
        {
            head = p;
            tail = p;
            current = p;
        }
        else
        {
            tail.next = p;
            p.prev = tail;
            tail = p;
        }

        Console.WriteLine("Da them bai hat: " + ten);
    }

    // Chuyen bai tiep theo
    static void Next()
    {
        if (current != null && current.next != null)
        {
            current = current.next;
            Console.WriteLine("Dang phat: " + current.data);
        }
        else
        {
            Console.WriteLine("Da den bai hat cuoi!");
        }
    }

    // Quay lai bai truoc
    static void Previous()
    {
        if (current != null && current.prev != null)
        {
            current = current.prev;
            Console.WriteLine("Dang phat: " + current.data);
        }
        else
        {
            Console.WriteLine("Da den bai hat dau!");
        }
    }

    // Xoa bai hat theo ten
    static void XoaBaiHat(string ten)
    {
        Node p = head;

        while (p != null && p.data != ten)
        {
            p = p.next;
        }

        if (p == null)
        {
            Console.WriteLine("Khong tim thay bai hat!");
            return;
        }

        Node truoc = p.prev;
        Node sau = p.next;

        if (current == p)
        {
            if (sau != null)
                current = sau;
            else
                current = truoc;
        }

        if (truoc != null)
            truoc.next = sau;
        else
            head = sau;

        if (sau != null)
            sau.prev = truoc;
        else
            tail = truoc;

        p.prev = null;
        p.next = null;

        Console.WriteLine("Da xoa bai hat: " + ten);
    }

    // Hien thi playlist
    static void HienThiPlaylist()
    {
        if (head == null)
        {
            Console.WriteLine("Playlist rong!");
            return;
        }

        Node p = head;

        Console.WriteLine("\nDanh sach bai hat:");

        while (p != null)
        {
            if (p == current)
                Console.WriteLine(">> " + p.data + " (Dang phat)");
            else
                Console.WriteLine("   " + p.data);

            p = p.next;
        }
    }

    // Hien thi bai dang phat
    static void HienThiHienTai()
    {
        if (current == null)
            Console.WriteLine("Chua co bai hat nao!");
        else
            Console.WriteLine("Dang phat: " + current.data);
    }

    static void Main()
    {
        int chon;

        do
        {
            Console.WriteLine("\n===== QUAN LY PLAYLIST =====");
            Console.WriteLine("1. Them bai hat");
            Console.WriteLine("2. Xoa bai hat");
            Console.WriteLine("3. Next");
            Console.WriteLine("4. Previous");
            Console.WriteLine("5. Hien thi playlist");
            Console.WriteLine("6. Hien thi bai dang phat");
            Console.WriteLine("0. Thoat");

            Console.Write("Nhap lua chon: ");
            chon = int.Parse(Console.ReadLine());

            switch (chon)
            {
                case 1:
                    Console.Write("Nhap ten bai hat: ");
                    string tenThem = Console.ReadLine();
                    ThemBaiHat(tenThem);
                    break;

                case 2:
                    Console.Write("Nhap ten bai hat can xoa: ");
                    string tenXoa = Console.ReadLine();
                    XoaBaiHat(tenXoa);
                    break;

                case 3:
                    Next();
                    break;

                case 4:
                    Previous();
                    break;

                case 5:
                    HienThiPlaylist();
                    break;

                case 6:
                    HienThiHienTai();
                    break;

                case 0:
                    Console.WriteLine("Ket thuc chuong trinh!");
                    break;

                default:
                    Console.WriteLine("Lua chon khong hop le!");
                    break;
            }

        } while (chon != 0);
    }
}
