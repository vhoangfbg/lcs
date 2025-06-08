namespace l5.Models
{
    public abstract class SinhVienPoly
    {
        public string HoTen { get; set; }
        public string Nganh { get; set; }

        public SinhVienPoly(string hoTen, string nganh)
        {
            HoTen = hoTen;
            Nganh = nganh;
        }

        public abstract double getDiem();

        public string getHocLuc()
        {
            double diem = getDiem();
            if (diem >= 9) return "Xuất sắc";
            if (diem >= 7.5) return "Giỏi";
            if (diem >= 6.5) return "Khá";
            if (diem >= 5) return "Trung bình";
            return "Yếu";
        }

        public virtual void xuat()
        {
            Console.WriteLine($"Họ tên: {HoTen,-20} | Ngành: {Nganh,-10} | Điểm: {getDiem():0.0} | Học lực: {getHocLuc(), -10}");
        }
    }
}
