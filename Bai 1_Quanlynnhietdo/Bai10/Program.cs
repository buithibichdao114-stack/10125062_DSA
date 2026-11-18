
using System;

class Node
{
    public string data;
    public Node prev;
    public Node next;

    public Node(string x)
    {
        data = x;
        prev = null;
        next = null;
    }
}

class Program
{
    static Node head = null;
    static Node current = null;

    // Truy cap trang web moi
    static void TruyCap(string tenTrang)
    {
        Node p = new Node(tenTrang);

        if (head == null)
        {
            head = p;
            current = p;
        }
        else
        {
            // Xoa lich su Forward cu
            current.next = null;

            // Lien ket trang moi
            current.next = p;
            p.prev = current;

            current = p;
        }

        Console.WriteLine("Da truy cap: " + tenTrang);
    }

    // Back
    static void Back()
    {
        if (current != null && current.prev != null)
        {
            current = current.prev;
            Console.WriteLine("Da quay lai: " + current.data);
        }
        else
        {
            Console.WriteLine("Khong the Back!");
        }
    }

    // Forward
    static void Forward()
    {
        if (current != null && current.next != null)
        {
            current = current.next;
            Console.WriteLine("Da tien den: " + current.data);
        }
        else
        {
            Console.WriteLine("Khong the Forward!");
        }
    }

    // Hien thi trang hien tai
    static void HienThiTrangHienTai()
    {
        if (current == null)
        {
            Console.WriteLine("Chua co trang web nao!");
        }
        else
        {
            Console.WriteLine("Trang hien tai: " + current.data);
        }
    }

    // Hien thi lich su
    static void HienThiLichSu()
    {
        Node p = head;

        Console.WriteLine("\nLich su duyet web:");

        while (p != null)
        {
            if (p == current)
            {
                Console.Write("[" + p.data + "] ");
            }
            else
            {
                Console.Write(p.data + " ");
            }

            p = p.next;
        }

        Console.WriteLine();
    }

    static void Main()
    {
        int chon;

        do
        {
            Console.WriteLine("\n===== LICH SU DUYET WEB =====");
            Console.WriteLine("1. Truy cap trang web");
            Console.WriteLine("2. Back");
            Console.WriteLine("3. Forward");
            Console.WriteLine("4. Hien thi trang hien tai");
            Console.WriteLine("5. Hien thi lich su");
            Console.WriteLine("0. Thoat");

            Console.Write("Nhap lua chon: ");
            chon = int.Parse(Console.ReadLine());

            switch (chon)
            {
                case 1:
                    Console.Write("Nhap ten trang web: ");
                    string ten = Console.ReadLine();
                    TruyCap(ten);
                    break;

                case 2:
                    Back();
                    break;

                case 3:
                    Forward();
                    break;

                case 4:
                    HienThiTrangHienTai();
                    break;

                case 5:
                    HienThiLichSu();
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
