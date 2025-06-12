using System;
using Lab6.Services;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== LAB 6 MENU ===");
            Console.WriteLine("1. Bài 1 - Quản lý sách");
            Console.WriteLine("2. Bài 2 - DbAction với Product và Order");
            Console.WriteLine("0. Thoát");
            Console.Write("Chọn bài tập (0-2): ");
            
            var choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    var bookService = new BookService();
                    bookService.Run();
                    break;
                case "2":
                    var dbService = new DbService();
                    dbService.Run();
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
}