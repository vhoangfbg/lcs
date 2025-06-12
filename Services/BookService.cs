using System;
using System.Collections.Generic;
using Lab6.Models;

namespace Lab6.Services
{
    public class BookService
    {
        public void Run()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== QUẢN LÝ SÁCH ===");
                Console.WriteLine("1. Nhập danh sách sách");
                Console.WriteLine("2. Hiển thị và sắp xếp sách");
                Console.WriteLine("0. Quay lại menu chính");
                Console.Write("Chọn chức năng: ");
                
                var choice = Console.ReadLine();
                
                switch (choice)
                {
                    case "1":
                        InputBooks();
                        break;
                    case "2":
                        if (bookList == null || bookList.Count == 0)
                        {
                            Console.WriteLine("Danh sách sách trống. Vui lòng nhập sách trước.");
                            Console.ReadKey();
                        }
                        else
                        {
                            DisplayAndSortBooks();
                        }
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Nhấn phím bất kỳ để tiếp tục...");
                        Console.ReadKey();
                        break;
                }
            }
        }
        
        private List<Book> bookList;
        
        private void InputBooks()
        {
            bookList = new List<Book>();
            
            Console.Write("\nNhập số lượng sách: ");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhập thông tin sách thứ {i + 1}:");
                Book book = new Book();
                
                Console.Write("Tiêu đề: ");
                book.Title = Console.ReadLine();
                
                Console.Write("Tác giả: ");
                book.Author = Console.ReadLine();
                
                Console.Write("Nhà xuất bản: ");
                book.Publisher = Console.ReadLine();
                
                Console.Write("Năm xuất bản: ");
                book.Year = int.Parse(Console.ReadLine());
                
                Console.Write("ISBN: ");
                book.ISBN = Console.ReadLine();
                
                Console.WriteLine("Nhập các chương (gõ 'xong' để kết thúc):");
                string chapter;
                while (true)
                {
                    chapter = Console.ReadLine();
                    if (chapter.ToLower() == "xong") break;
                    book.Chapters.Add(chapter);
                }
                
                bookList.Add(book);
            }
            
            Console.WriteLine("\nĐã nhập xong danh sách sách. Nhấn phím bất kỳ để tiếp tục...");
            Console.ReadKey();
        }
        
        private void DisplayAndSortBooks()
        {
            Console.WriteLine("\nDanh sách sách ban đầu:");
            DisplayBooks(bookList);
            
            Console.WriteLine("\nSắp xếp theo tác giả:");
            var sortedByAuthor = new List<Book>(bookList);
            sortedByAuthor.Sort(new SortByAuthor());
            DisplayBooks(sortedByAuthor);
            
            Console.WriteLine("\nSắp xếp theo tiêu đề:");
            var sortedByTitle = new List<Book>(bookList);
            sortedByTitle.Sort(Comparer<Book>.Default);
            DisplayBooks(sortedByTitle);
            
            Console.WriteLine("\nSắp xếp theo năm xuất bản:");
            var sortedByYear = new List<Book>(bookList);
            sortedByYear.Sort(new SortByYear());
            DisplayBooks(sortedByYear);
            
            Console.WriteLine("\nNhấn phím bất kỳ để quay lại menu...");
            Console.ReadKey();
        }
        
        private void DisplayBooks(List<Book> books)
        {
            foreach (var book in books)
            {
                book.Display();
            }
        }
    }

    public class SortByAuthor : IComparer<Book>
    {
        public int Compare(Book x, Book y) => x.Author.CompareTo(y.Author);
    }

    public class SortByYear : IComparer<Book>
    {
        public int Compare(Book x, Book y) => x.Year.CompareTo(y.Year);
    }
}