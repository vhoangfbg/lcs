using System.Text;
using l5.Services;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        var hinhHoc = new HinhHocService();
        var sinhVien = new SinhVienService();

        while (true)
        {
            Console.WriteLine("\n=============== MENU ===============");
            Console.WriteLine("1. Tính chu vi và diện tích các hình");
            Console.WriteLine("2. Nhập danh sách sinh viên");
            Console.WriteLine("3. Xuất danh sách sinh viên");
            Console.WriteLine("4. Xuất sinh viên giỏi");
            Console.WriteLine("5. Sắp xếp sinh viên theo điểm");
            Console.WriteLine("0. Thoát");
            Console.Write("Chọn chức năng: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    hinhHoc.Run();
                    break;
                case "2":
                    sinhVien.NhapDanhSach();
                    break;
                case "3":
                    sinhVien.XuatDanhSach();
                    break;
                case "4":
                    sinhVien.XuatGioi();
                    break;
                case "5":
                    sinhVien.SapXepTheoDiem();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Chọn không hợp lệ!");
                    break;
            }
        }
    }
}
