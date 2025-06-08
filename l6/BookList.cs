
namespace l6;

public class BookList
{
    private List<Book> books;

    public BookList()
    {
        books = new List<Book>();
    }

    public void Add()
    {
        bool isRunning = true;
        while (isRunning)
        {
            Console.Clear();
            Book b = new Book();
            Console.WriteLine("Ten sach: ");
            b.TenSach = Console.ReadLine();
            Console.WriteLine("Ten tac gia: ");
            b.TenTacGia = Console.ReadLine();
            Console.WriteLine("Nha xuat ban: ");
            b.NhaXuatBan = Console.ReadLine();
            Console.WriteLine("ISBN: ");
            b.ISBN = Convert.ToInt16(Console.ReadLine());


            Console.WriteLine("Nhap so chuong");
            int SoChuong = int.Parse(Console.ReadLine());
            b.Chuong = new List<string>();
            for (int i = 0; i < SoChuong; i++)
            {
                Console.WriteLine($"Nhap ten chuong {i + 1}");
                string TenChuong = Console.ReadLine().Trim();
                b.Chuong.Add(TenChuong);
            }
            books.Add(b);


            Console.WriteLine("Ban co muon tiep tuc them sach khong? [Co] hoac [Khong]");
            Console.Write("==> ");
            string ThemSach = Console.ReadLine().Trim();
            if (ThemSach.ToLower() == "co")
            {
                continue;
            }
            else if (ThemSach.ToLower() == "khong")
            {
                isRunning = false;
            }
            else
            {
                Console.WriteLine("Lua chon khong hop le! Ket thuc truong trinh");
                break;
            }
        }
    }
    public void Show()
    {
        foreach (var s in books)
        {
            s.Display();
        }
    }
    public void SapXep()
    {
        books.Sort(new XepTheoNXB());
        // books.Sort(new XepTheoTenTacGia());

        Show();
        }
}
