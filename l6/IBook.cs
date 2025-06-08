using System;

namespace l6;

public interface IBook
{
    string TenSach { get; set; }
    string TenTacGia { get; set; }
    string NhaXuatBan { get; set; }
    int ISBN { get; set; }
    List<string> Chuong { get; set; }
    void Display();
}
