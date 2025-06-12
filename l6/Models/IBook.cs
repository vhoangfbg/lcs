using System.Collections.Generic;

namespace Lab6.Models
{
    public interface IBook
    {
        string Title { get; set; }
        string Author { get; set; }
        string Publisher { get; set; }
        int Year { get; set; }
        string ISBN { get; set; }
        List<string> Chapters { get; set; }
        
        void Display();
    }
}