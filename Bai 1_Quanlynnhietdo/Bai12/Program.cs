
using System;

class Node
{
    public string maDon;
    public string tenKhachHang;
    public Node prev, next;

    public Node(string ma, string ten)
    {
        maDon = ma;
        tenKhachHang = ten;
        prev = next = null;
    }
}

class DanhSach
{
    public Node head = null;
    public Node tail = null;

    // Them don hang vao cuoi danh sach
    public void ThemCuoi(Node p)
    {
        p.prev = null;
        p.next = null;

        if (head == null)
        {
            head = tail = p;
        }
        else
        {
            tail.next = p;
            p.prev = tail;
            tail = p;
        }
    }

    // Tim don hang
    public Node Tim(string ma)
    {
        Node p = head;

        while (p != null)
        {
            if (p.maDon == ma)
                return p;

            p = p.next;
        }

        return null;
    }

    // Xoa mot Node khoi danh sach
    public void Xoa(Node p)
    {
        if (p == null) return;

        if (p.prev != null)
            p.prev.next = p.next;
        else
            head = p.next;

        if (p.next != null)
            p.next.prev = p.prev;
        else
            tail = p.prev;

        p.prev = null;
        p.next = null;
    }

    // Hien thi danh sach
    public void HienThi(string tenTrangThai)
    {
        Console.WriteLine("\n" + tenTrangThai);

        Node p = head;

        if (p == null)
        {
            Console.WriteLine("Danh sach rong!");
            return;
        }

        while (p != null)
        {
            Console.WriteLine(
                p.maDon + " - " + p.tenKhachHang
            );

            p = p.next;
        }
    }
}

class Program
{
    static DanhSach choXuLy = new DanhSach();
    static DanhSach dangGiao = new DanhSach();
    static DanhSach hoanThanh = new DanhSach();

    // Them don hang moi
    static void ThemDonHang(string ma, string ten)
    {
        Node p = new Node(ma, ten);
        choXuLy.ThemCuoi(p);

        Console.WriteLine("Them don hang thanh cong!");
    }

    // Chuyen trang thai don hang
    static void ChuyenTrangThai(string ma)
    {
        Node p = choXuLy.Tim(ma);

        if (p != null)
        {
            choXuLy.Xoa(p);
            dangGiao.ThemCuoi(p);

            Console.WriteLine("Don hang da chuyen sang Dang giao!");
            return;
        }

        p = dangGiao.Tim(ma);

        if (p != null)
        {
            dangGiao.Xoa(p);
            hoanThanh.ThemCuoi(p);

            Console.WriteLine("Don hang da Hoan thanh!");
            return;
        }

        p = hoanThanh.Tim(ma);

        if (p != null)
        {
            Console.WriteLine("Don hang da hoan thanh!");
            return;
        }

        Console.WriteLine("Khong tim thay don hang!");
    }

    // Hien thi tat ca don hang
    static void HienThiTatCa()
    {
        choXuLy.HienThi("CHO XU LY");
        dangGiao.HienThi("DANG GIAO");
        hoanThanh.HienThi("HOAN THANH");
    }

    static void Main()
    {
        int chon;

        do
        {
            Console.WriteLine("\n===== QUAN LY DON HANG =====");
            Console.WriteLine("1. Them don hang");
            Console.WriteLine("2. Chuyen trang thai");
            Console.WriteLine("3. Hien thi don hang");
            Console.WriteLine("0. Thoat");

            Console.Write("Nhap lua chon: ");
            chon = int.Parse(Console.ReadLine());

            switch (chon)
            {
                case 1:
                    Console.Write("Nhap ma don: ");
                    string ma = Console.ReadLine();

                    Console.Write("Nhap ten khach hang: ");
                    string ten = Console.ReadLine();

                    ThemDonHang(ma, ten);
                    break;

                case 2:
                    Console.Write("Nhap ma don can chuyen: ");
                    string maChuyen = Console.ReadLine();

                    ChuyenTrangThai(maChuyen);
                    break;

                case 3:
                    HienThiTatCa();
                    break;

                case 0:
                    Console.WriteLine("Ket thuc!");
                    break;

                default:
                    Console.WriteLine("Lua chon khong hop le!");
                    break;
            }

        } while (chon != 0);
    }
}
