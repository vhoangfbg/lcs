using System;

namespace Lab6.Models
{
    public class Product : DbAction
    {
        public void insert() => Console.WriteLine("Insert product");
        public void update() => Console.WriteLine("Update product");
        public void delete() => Console.WriteLine("Delete product");
        public void select() => Console.WriteLine("Select product");
    }
}