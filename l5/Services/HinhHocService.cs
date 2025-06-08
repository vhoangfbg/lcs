using l5.Models;

namespace l5.Services
{
    public class HinhHocService
    {
        public void Run()
        {
            Console.WriteLine("Nhập thông tin 2 hình chữ nhật:");
            var cn1 = NhapChuNhat();
            var cn2 = NhapChuNhat();

            Console.WriteLine("Nhập cạnh hình vuông:");
            double canh = double.Parse(Console.ReadLine()!);
            var vuong = new Vuong(canh);

            Console.WriteLine("=== Kết quả ===");
            cn1.xuat();
            cn2.xuat();
            vuong.xuat();
        }

        private ChuNhat NhapChuNhat()
        {
            Console.Write("Chiều dài: "); double dai = double.Parse(Console.ReadLine()!);
            Console.Write("Chiều rộng: "); double rong = double.Parse(Console.ReadLine()!);
            return new ChuNhat(dai, rong);
        }
    }
}
