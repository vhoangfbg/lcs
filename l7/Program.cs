using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("==== MENU CHINH ====");
            Console.WriteLine("1. Bai 1 - Delegate va Event");
            Console.WriteLine("2. Bai 2 - ArrayList voi delegate");
            Console.WriteLine("3. Bai 3 - Quan ly Sinh vien");
            Console.WriteLine("4. Thoat");
            Console.Write("Chon chuc nang (1-4): ");
            
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    Bai1.ThucHien();
                    break;
                case "2":
                    Bai2.ThucHien();
                    break;
                case "3":
                    Bai3.ThucHien();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Lua chon khong hop le. Vui long chon lai!");
                    break;
            }
            
            Console.WriteLine("\nNhan phim bat ky de tiep tuc...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}