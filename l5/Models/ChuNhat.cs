namespace l5.Models
{
    public class ChuNhat
    {
        public double Rong { get; set; }
        public double Dai { get; set; }

        public ChuNhat(double dai, double rong)
        {
            Dai = dai;
            Rong = rong;
        }

        public double getChuVi() => (Dai + Rong) * 2;
        public double getDienTich() => Dai * Rong;

        public virtual void xuat()
        {
            Console.WriteLine($"Chiều dài: {Dai}, Chiều rộng: {Rong}, Diện tích: {getDienTich()}, Chu vi: {getChuVi()}");
        }
    }
}
