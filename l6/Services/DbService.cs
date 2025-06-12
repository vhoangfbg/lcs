using System;
using Lab6.Models;

namespace Lab6.Services
{
    public class DbService
    {
        public void Run()
        {
            Console.WriteLine("\n=== DB ACTION DEMO ===");
            
            DbAction db1 = new Product();
            DbAction db2 = new Order();
            
            Console.WriteLine("\nGọi phương thức insert():");
            db1.insert();
            db2.insert();
            
            Console.WriteLine("\nGọi tất cả phương thức CRUD:");
            Console.WriteLine("\nProduct:");
            db1.insert();
            db1.update();
            db1.delete();
            db1.select();
            
            Console.WriteLine("\nOrder:");
            db2.insert();
            db2.update();
            db2.delete();
            db2.select();
            
            Console.WriteLine("\nNhấn phím bất kỳ để quay lại menu...");
            Console.ReadKey();
        }
    }
}