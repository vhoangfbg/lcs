using l5.Models;

namespace l5.Services
{
    public class SinhVienService
    {
        private List<SinhVienPoly> ds = new();

        public void NhapDanhSach()
        {
            Console.Write("Nhập số sinh viên: ");
            int n = int.Parse(Console.ReadLine()!);
            for (int i = 0; i < n; i++)
            {
                Console.Write("Họ tên: ");
                string ten = Console.ReadLine()!;
                Console.Write("Ngành (IT/Biz): ");
                string nganh = Console.ReadLine()!.Trim().ToUpper();

                if (nganh == "IT")
                {
                    Console.Write("Java: "); double java = double.Parse(Console.ReadLine()!);
                    Console.Write("HTML: "); double html = double.Parse(Console.ReadLine()!);
                    Console.Write("CSS: "); double css = double.Parse(Console.ReadLine()!);
                    ds.Add(new SinhVienIT(ten, java, html, css));
                }
                else if (nganh == "BIZ")
                {
                    Console.Write("Marketing: "); double mkt = double.Parse(Console.ReadLine()!);
                    Console.Write("Sales: "); double sales = double.Parse(Console.ReadLine()!);
                    ds.Add(new SinhVienBiz(ten, mkt, sales));
                }
            }
        }

        public void XuatDanhSach() => ds.ForEach(sv => sv.xuat());

        public void XuatGioi() =>
            ds.Where(sv => sv.getHocLuc() == "Giỏi").ToList().ForEach(sv => sv.xuat());

        public void SapXepTheoDiem()
        {
            var sorted = ds.OrderByDescending(sv => sv.getDiem()).ToList();
            sorted.ForEach(sv => sv.xuat());
        }
    }
}
