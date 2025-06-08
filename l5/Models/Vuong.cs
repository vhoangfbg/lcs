namespace l5.Models
{
    public class Vuong : ChuNhat
    {
        public Vuong(double canh) : base(canh, canh) { }

        public override void xuat()
        {
            Console.WriteLine($"Cạnh: {Dai}, Diện tích: {getDienTich()}, Chu vi: {getChuVi()}");
        }
    }
}
