using System;
using System.Collections.Generic;

namespace Lab6.Models
{
    public class Book : IBook, IComparable<Book>
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int Year { get; set; }
        public string ISBN { get; set; }
        public List<string> Chapters { get; set; }
        
        public Book()
        {
            Chapters = new List<string>();
        }
        
        public void Display()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Publisher: {Publisher}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine("Chapters:");
            foreach (var chapter in Chapters)
            {
                Console.WriteLine($"- {chapter}");
            }
            Console.WriteLine();
        }
        
        public int CompareTo(Book other)
        {
            return this.Title.CompareTo(other.Title);
        }
    }
}