using System;

namespace l6;

public class XepTheoNXB : IComparer<Book>
{
    public int Compare(Book x, Book y)
    {
        return string.Compare(x.NhaXuatBan, y.NhaXuatBan);
    }
}
