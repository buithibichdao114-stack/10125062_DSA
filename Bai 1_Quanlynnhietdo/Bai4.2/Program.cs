
using System;

struct NhanVien
{
    public string MaNV;
    public string HoTen;
    public int NamSinh;
    public string PhongBan;
    public int LuongCB;
    public int Thuong;
}

class Program
{
    static NhanVien[] DS;
    static int n;

    // Tinh thuc linh cua mot nhan vien
    static int ThucLinh(NhanVien nv)
    {
        return nv.LuongCB + nv.Thuong;
    }

    // Nhap danh sach nhan vien
    static void Nhap()
    {
        Console.Write("Nhap so nhan vien: ");
        n = int.Parse(Console.ReadLine());

        DS = new NhanVien[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\nNhan vien thu {0}", i + 1);

            Console.Write("Ma nhan vien: ");
            DS[i].MaNV = Console.ReadLine();

            Console.Write("Ho ten: ");
            DS[i].HoTen = Console.ReadLine();

            Console.Write("Nam sinh: ");
            DS[i].NamSinh = int.Parse(Console.ReadLine());

            Console.Write("Phong ban: ");
            DS[i].PhongBan = Console.ReadLine();

            Console.Write("Luong co ban: ");
            DS[i].LuongCB = int.Parse(Console.ReadLine());

            Console.Write("Thuong: ");
            DS[i].Thuong = int.Parse(Console.ReadLine());
        }
    }

    // Hien thi mot nhan vien
    static void HienThi(NhanVien nv)
    {
        Console.WriteLine(
            "{0,-10} {1,-20} {2,-10} {3,-15} {4,-12} {5,-12} {6}",
            nv.MaNV, nv.HoTen, nv.NamSinh,
            nv.PhongBan, nv.LuongCB, nv.Thuong,
            ThucLinh(nv));
    }

    // Hien thi danh sach
    static void HienThiDanhSach()
    {
        Console.WriteLine(
            "\n{0,-10} {1,-20} {2,-10} {3,-15} {4,-12} {5,-12} {6}",
            "MaNV", "HoTen", "NamSinh",
            "PhongBan", "LuongCB", "Thuong", "ThucLinh");

        for (int i = 0; i < n; i++)
        {
            HienThi(DS[i]);
        }
    }

    // a. Tinh tong thuc linh
    static void TongThucLinh()
    {
        long tong = 0;

        for (int i = 0; i < n; i++)
        {
            tong += ThucLinh(DS[i]);
        }

        Console.WriteLine("\nTong thuc linh = " + tong);
    }

    // b. Tim nhan vien co luong co ban thap nhat
    static void LuongThapNhat()
    {
        int min = int.MaxValue;

        for (int i = 0; i < n; i++)
        {
            if (DS[i].LuongCB < min)
            {
                min = DS[i].LuongCB;
            }
        }

        Console.WriteLine("\nNhan vien co luong co ban thap nhat:");

        for (int i = 0; i < n; i++)
        {
            if (DS[i].LuongCB == min)
            {
                HienThi(DS[i]);
            }
        }
    }

    // c. Dem nhan vien co thuong >= 1200000
    static void DemNhanVienThuong()
    {
        int dem = 0;

        for (int i = 0; i < n; i++)
        {
            if (DS[i].Thuong >= 1200000)
            {
                dem++;
            }
        }

        Console.WriteLine("\nSo nhan vien co thuong >= 1200000: " + dem);
    }

    // d. Sap xep phong ban tang dan,
    // neu trung phong ban thi MaNV giam dan
    static void SapXep()
    {
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                int kq = string.Compare(
                    DS[i].PhongBan,
                    DS[j].PhongBan,
                    StringComparison.OrdinalIgnoreCase);

                bool canDoiCho = false;

                if (kq > 0)
                {
                    canDoiCho = true;
                }
                else if (kq == 0 &&
                    string.Compare(DS[i].MaNV, DS[j].MaNV,
                    StringComparison.OrdinalIgnoreCase) < 0)
                {
                    canDoiCho = true;
                }

                if (canDoiCho)
                {
                    NhanVien tam = DS[i];
                    DS[i] = DS[j];
                    DS[j] = tam;
                }
            }
        }

        Console.WriteLine("\nDanh sach sau khi sap xep:");
        HienThiDanhSach();
    }

    // e. Tang luong co ban len 5%
    static void TangLuong()
    {
        for (int i = 0; i < n; i++)
        {
            DS[i].LuongCB = (int)(DS[i].LuongCB * 1.05);
        }

        Console.WriteLine("\nDanh sach sau khi tang luong 5%:");
        HienThiDanhSach();
    }

    static void Main()
    {
        Nhap();

        Console.WriteLine("\nDANH SACH NHAN VIEN BAN DAU");
        HienThiDanhSach();

        TongThucLinh();
        LuongThapNhat();
        DemNhanVienThuong();
        SapXep();
        TangLuong();
    }
}
