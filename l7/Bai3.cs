using System;
using System.Collections.Generic;

public class Bai3
{
    public static void ThucHien()
    {
        Console.Clear();
        Console.WriteLine("==== BAI 3 ====");
        
        List<Student> danhSachSV = new List<Student>();
        
        Console.Write("Nhap so luong sinh vien: ");
        int n = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nNhap thong tin sinh vien thu {i + 1}:");
            Student sv = new Student();
            sv.NhapThongTin();
            danhSachSV.Add(sv);
        }
        
        Console.WriteLine("\nDanh sach sinh vien:");
        foreach (var sv in danhSachSV)
        {
            sv.HienThiThongTin();
            Console.WriteLine();
        }
    }
}

public class Student
{
    private string studentID;
    private string studentName;
    private int age;
    private string gender;
    private string city;
    
    public void NhapThongTin()
    {
        // Nhap studentID
        Console.Write("Ma SV: ");
        studentID = Console.ReadLine();
        
        // Nhap studentName (6-40 ky tu)
        while (true)
        {
            Console.Write("Ten SV (6-40 ky tu): ");
            studentName = Console.ReadLine();
            
            if (studentName.Length >= 6 && studentName.Length <= 40)
                break;
                
            Console.WriteLine("Ten phai tu 6-40 ky tu. Vui long nhap lai!");
        }
        
        // Nhap age (>=18)
        while (true)
        {
            Console.Write("Tuoi (>=18): ");
            if (int.TryParse(Console.ReadLine(), out age) && age >= 18)
                break;
                
            Console.WriteLine("Tuoi phai >=18 va la so nguyen. Vui long nhap lai!");
        }
        
        // Nhap gender (Nam/Nu)
        while (true)
        {
            Console.Write("Gioi tinh (Nam/Nu): ");
            gender = Console.ReadLine();
            
            if (gender == "Nam" || gender == "Nu")
                break;
                
            Console.WriteLine("Gioi tinh chi nhan 'Nam' hoac 'Nu'. Vui long nhap lai!");
        }
        
        // Nhap city (4-40 ky tu)
        while (true)
        {
            Console.Write("Thanh pho (4-40 ky tu): ");
            city = Console.ReadLine();
            
            if (city.Length >= 4 && city.Length <= 40)
                break;
                
            Console.WriteLine("Thanh pho phai tu 4-40 ky tu. Vui long nhap lai!");
        }
    }
    
    public void HienThiThongTin()
    {
        Console.WriteLine($"Ma SV: {studentID}");
        Console.WriteLine($"Ten SV: {studentName}");
        Console.WriteLine($"Tuoi: {age}");
        Console.WriteLine($"Gioi tinh: {gender}");
        Console.WriteLine($"Thanh pho: {city}");
    }
}