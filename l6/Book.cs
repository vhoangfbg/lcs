using System;

namespace l6;

public class Book : IBook, IComparable<Book> 
{
    public string TenSach { get; set; }
    public string TenTacGia { get; set; }
    public string NhaXuatBan { get; set; }
    public int ISBN { get; set; }
    public List<string> Chuong { get; set; }
    public Book() {
        Chuong = new List<string>();
    }

    public int CompareTo(Book other)
    {
        return this.TenSach.CompareTo(other.TenSach);
    }
    public void Display()
    {
        Console.WriteLine("\n\n======Thong tin======");
        Console.WriteLine($"Ten sach: {TenSach,-15} | Ten tac gia: {TenTacGia,-10} | Nha xuat ban: {NhaXuatBan,-10} | ISBN: {ISBN}");

        Console.WriteLine($"==>Chuong");
        foreach (var c in Chuong)
        {
            Console.WriteLine($"Chuong: {c}");
        }

    }
}
