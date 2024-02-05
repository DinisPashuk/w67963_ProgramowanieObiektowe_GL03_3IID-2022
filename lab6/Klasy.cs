using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public class Book : IEntity<int>, ICreationDate
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int YearOfPublication { get; set; }
    }

    public class Person : IEntity<int>, ICreationDate
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public List<Book> BorrowedBooks { get; set; } = new List<Book>();
    }

    public class BookRepository : IBookRepository
    {
        private List<Book> books = new List<Book>();

        public void Create(Book book) => books.Add(book);

        public void Update(Book book)
        {
            var index = books.FindIndex(b => b.Id == book.Id);
            if (index != -1)
            {
                books[index] = book;
            }
        }

        public List<Book> GetAll() => books;

        public Book Get(int id) => books.FirstOrDefault(b => b.Id == id);

        public void Delete(int id) => books.RemoveAll(b => b.Id == id);

        public List<Book> GetBooksByAuthor(string author) => books.Where(b => b.Author == author).ToList();

        public List<Book> GetBooksByYear(int year) => books.Where(b => b.YearOfPublication == year).ToList();
    }

    public class PersonRepository : IPersonRepository
    {
        private List<Person> people = new List<Person>();

        public void Create(Person person) => people.Add(person);

        public void Update(Person person)
        {
            var index = people.FindIndex(p => p.Id == person.Id);
            if (index != -1)
            {
                people[index] = person;
            }
        }

        public List<Person> GetAll() => people;

        public Person Get(int id) => people.FirstOrDefault(p => p.Id == id);

        public void Delete(int id) => people.RemoveAll(p => p.Id == id);

        public List<Book> GetBorrowedBooks(int personId)
        {
            return people.FirstOrDefault(p => p.Id == personId)?.BorrowedBooks;
        }

        public void AddBookToPerson(int personId, Book book)
        {
            Person person = people.FirstOrDefault(p => p.Id == personId);
            if (person != null && !person.BorrowedBooks.Contains(book))
            {
                person.BorrowedBooks.Add(book);
            }
        }
    }
}
