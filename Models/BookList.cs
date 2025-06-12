using System.Collections.Generic;

namespace Lab6.Models
{
    public class BookList
    {
        private List<Book> books;
        
        public BookList()
        {
            books = new List<Book>();
        }
        
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        
        public void DisplayAll()
        {
            foreach (var book in books)
            {
                book.Display();
            }
        }
        
        public void SortBy(IComparer<Book> comparer)
        {
            books.Sort(comparer);
        }
    }
}