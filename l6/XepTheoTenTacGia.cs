using System;

namespace l6;
public class XepTheoTenTacGia : IComparer<Book>
{
    public int Compare(Book x, Book y)
    {
        return string.Compare(x.TenTacGia, y.TenTacGia);
    }
}
