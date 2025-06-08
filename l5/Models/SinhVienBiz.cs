namespace l5.Models
{
    public class SinhVienBiz : SinhVienPoly
    {
        public double Marketing { get; set; }
        public double Sales { get; set; }

        public SinhVienBiz(string hoTen, double marketing, double sales)
            : base(hoTen, "Biz")
        {
            Marketing = marketing;
            Sales = sales;
        }

        public override double getDiem() => (2 * Marketing + Sales) / 3;
    }
}
