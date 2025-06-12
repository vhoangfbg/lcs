using System;
using System.Collections;

public class Bai2
{
    public delegate void XuLySo(int num);
    public static event XuLySo SoDaThem;
    
    private static ArrayList danhSachSo = new ArrayList();
    
    public static void ThucHien()
    {
        Console.Clear();
        Console.WriteLine("==== BAI 2 ====");
        
        SoDaThem += HienThiSo;
        
        while (true)
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("add -> Them so");
            Console.WriteLine("display -> Hien thi so");
            Console.WriteLine("exit -> Thoat");
            Console.Write("Lua chon: ");
            
            string choice = Console.ReadLine().ToLower();
            
            switch (choice)
            {
                case "add":
                    ThemSo();
                    break;
                case "display":
                    HienThiTatCa();
                    break;
                case "exit":
                    return;
                default:
                    Console.WriteLine("Lua chon khong hop le!");
                    break;
            }
        }
    }
    
    private static void ThemSo()
    {
        Console.Write("Nhap so nguyen duong: ");
        string input = Console.ReadLine();
        
        if (int.TryParse(input, out int num) && num > 0)
        {
            danhSachSo.Add(num);
            SoDaThem?.Invoke(num);
        }
        else
        {
            Console.WriteLine("So khong hop le (phai la so nguyen > 0). Vui long thu lai!");
        }
    }
    
    private static void HienThiSo(int num)
    {
        Console.WriteLine($"Da them so: {num}");
    }
    
    private static void HienThiTatCa()
    {
        Console.WriteLine("\nDanh sach so:");
        foreach (int num in danhSachSo)
        {
            Console.WriteLine(num);
        }
    }
}