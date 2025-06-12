using System;

public class Bai1
{
    public delegate void TinhToan(int a, int b);
    
    public static void ThucHien()
    {
        Console.Clear();
        Console.WriteLine("==== BAI 1 ====");
        
        // Phần a: PrintHelper với event
        Console.WriteLine("\n--- Phan a: PrintHelper ---");
        PrintHelper printHelper = new PrintHelper();
        printHelper.beforePrintEvent += PrintHelper_beforePrintEvent;
        
        printHelper.PrintNumber(1234567);
        printHelper.PrintDecimal(123);
        printHelper.PrintMoney(1000000);
        printHelper.PrintTemperature(75);
        printHelper.PrintHexadecimal(255);
        
        // Phần b: Tính toán với delegate
        Console.WriteLine("\n--- Phan b: Tinh toan ---");
        TinhToan phepTinh = Tong;
        phepTinh += Hieu;
        phepTinh += Tich;
        phepTinh += Thuong;
        
        Console.Write("Nhap so thu nhat: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Nhap so thu hai: ");
        int num2 = int.Parse(Console.ReadLine());
        
        phepTinh(num1, num2);
    }
    
    private static void PrintHelper_beforePrintEvent()
    {
        Console.WriteLine("Chuan bi in...");
    }
    
    private static void Tong(int a, int b)
    {
        Console.WriteLine($"Tong: {a + b}");
    }
    
    private static void Hieu(int a, int b)
    {
        Console.WriteLine($"Hieu: {a - b}");
    }
    
    private static void Tich(int a, int b)
    {
        Console.WriteLine($"Tich: {a * b}");
    }
    
    private static void Thuong(int a, int b)
    {
        if (b != 0)
            Console.WriteLine($"Thuong: {(double)a / b}");
        else
            Console.WriteLine("Khong the chia cho 0");
    }
}

public class PrintHelper
{
    public delegate void BeforePrint();
    public event BeforePrint beforePrintEvent;
    
    public void PrintNumber(int num)
    {
        if (beforePrintEvent != null)
            beforePrintEvent();
        Console.WriteLine("Number: {0:N0}", num);
    }

    public void PrintDecimal(int dec)
    {
        if (beforePrintEvent != null)
            beforePrintEvent();
        Console.WriteLine("Decimal: {0:F3}", dec);
    }

    public void PrintMoney(int money)
    {
        if (beforePrintEvent != null)
            beforePrintEvent();
        Console.WriteLine("Money: {0:C}", money);
    }

    public void PrintTemperature(int num)
    {
        if (beforePrintEvent != null)
            beforePrintEvent();
        Console.WriteLine("Temperature: {0:F1} F", num);
    }
    
    public void PrintHexadecimal(int num)
    {
        if (beforePrintEvent != null)
            beforePrintEvent();
        Console.WriteLine("Hexadecimal: {0:X}", num);
    }
}