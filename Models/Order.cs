using System;

namespace Lab6.Models
{
    public class Order : DbAction
    {
        public void insert() => Console.WriteLine("Insert order");
        public void update() => Console.WriteLine("Update order");
        public void delete() => Console.WriteLine("Delete order");
        public void select() => Console.WriteLine("Select order");
    }
}