using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int YearPublished { get; set; }

        public Book(int id, string title, string author, int yearPublished)
        {
            Id = id;
            Title = title;
            Author = author;
            YearPublished = yearPublished;
        }
    }

    public class BookManager
    {
        private List<Book> books = new List<Book>();

        public void AddBook(string title, string author, int yearPublished)
        {
            int newId = books.Count > 0 ? books.Max(b => b.Id) + 1 : 1;
            books.Add(new Book(newId, title, author, yearPublished));
        }

        public void EditBook(int id, string title, string author, int yearPublished)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book != null)
            {
                book.Title = title;
                book.Author = author;
                book.YearPublished = yearPublished;
            }
        }

        public void DeleteBook(int id)
        {
            books.RemoveAll(b => b.Id == id);
        }

        public Book GetBook(int id)
        {
            return books.FirstOrDefault(b => b.Id == id);
        }

        public List<Book> GetAllBooks()
        {
            return books;
        }

        public List<Book> GetBooksByAuthor(string author)
        {
            return books.Where(b => b.Author.Equals(author, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Book> GetBooksByYear(int yearPublished)
        {
            return books.Where(b => b.YearPublished == yearPublished).ToList();
        }
    }
}
