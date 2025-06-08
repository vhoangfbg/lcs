namespace l5.Models
{
    public class SinhVienIT : SinhVienPoly
    {
        public double Java { get; set; }
        public double Html { get; set; }
        public double Css { get; set; }

        public SinhVienIT(string hoTen, double java, double html, double css)
            : base(hoTen, "IT")
        {
            Java = java;
            Html = html;
            Css = css;
        }

        public override double getDiem() => (2 * Java + Html + Css) / 4;
    }
}
