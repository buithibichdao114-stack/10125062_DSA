using System;
class Program
{
    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Nhập số ngày
        Console.Write("Nhập số ngày:");
        int n = int.Parse(Console.ReadLine());

        // Khai báo mảng nhiệt độ
        double[] nhietdo = new double[n];

        //Nhập dữ liệu
        for (int i = 0; i < n;i++)
        {
            Console.Write("Nhập nhiệt độ ngày"+(i+1)+": ");//Hiển thị ngày từ 1 thay vì 0
            nhietdo[i] = double.Parse(Console.ReadLine());
        }

        //Khởi tạo max min
        double max = nhietdo[0];
        double min = nhietdo[0];

        int ngayMax = 0;
        int ngayMin = 0;

        // Tìm nhiệt độ cao nhất và thấp nhất
        for (int i = 1; i < n; i++)
        {

            if (nhietdo[i] > max)
            {
                max = nhietdo[i];
                ngayMax = i;
            }
            if (nhietdo[i] < min)
            {
                min = nhietdo[i];
                ngayMin = i;
            }
        }
        // Khai báo tổng
        double tong = 0;
        for ( int i = 0; i< n; i++)
        {
            tong += nhietdo[i];
        }
        // Tính trung bình 
        double avg = tong / n;
        Console.WriteLine("Nhiệt độ cao nhất: " + max);
        Console.WriteLine("Ngày có nhiệt độ cao nhất: " + (ngayMax + 1));

        Console.WriteLine("Nhiệt độ thấp nhất: " + min);
        Console.WriteLine("Ngày có nhiệt độ thấp nhất: " + (ngayMin + 1));

        Console.WriteLine("Nhiệt độ TB: " + avg);
    }
}

