using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inicjalizacja repozytoriów
            IBookRepository bookRepository = new BookRepository();
            IPersonRepository personRepository = new PersonRepository();

            // Tworzenie i dodawanie książek do repozytorium
            Book book1 = new Book { Id = 1, Title = "C# Programming", Author = "Author1", YearOfPublication = 2020, CreationDate = DateTime.Now };
            Book book2 = new Book { Id = 2, Title = "Advanced C#", Author = "Author2", YearOfPublication = 2021, CreationDate = DateTime.Now };
            bookRepository.Create(book1);
            bookRepository.Create(book2);

            // Tworzenie i dodawanie osób do repozytorium
            Person person1 = new Person { Id = 1, FirstName = "John", LastName = "Doe", Age = 30, CreationDate = DateTime.Now };
            Person person2 = new Person { Id = 2, FirstName = "Jane", LastName = "Doe", Age = 25, CreationDate = DateTime.Now };
            personRepository.Create(person1);
            personRepository.Create(person2);

            // Dodawanie książek do listy wypożyczonych dla osoby
            personRepository.AddBookToPerson(person1.Id, book1);
            personRepository.AddBookToPerson(person1.Id, book2);

            // Wyświetlanie książek wypożyczonych przez Johna Doe
            var borrowedBooks = personRepository.GetBorrowedBooks(person1.Id);
            Console.WriteLine($"Książki wypożyczone przez {person1.FirstName} {person1.LastName}:");
            foreach (var book in borrowedBooks)
            {
                Console.WriteLine($"{book.Title} by {book.Author}, {book.YearOfPublication}");
            }

            // Wyszukiwanie książek po autorze
            var booksByAuthor = bookRepository.GetBooksByAuthor("Author1");
            Console.WriteLine("\nKsiążki napisane przez Author1:");
            foreach (var book in booksByAuthor)
            {
                Console.WriteLine($"{book.Title}, {book.YearOfPublication}");
            }

            // Wyszukiwanie książek wydanych w roku 2021
            var booksByYear = bookRepository.GetBooksByYear(2021);
            Console.WriteLine("\nKsiążki wydane w roku 2021:");
            foreach (var book in booksByYear)
            {
                Console.WriteLine($"{book.Title} by {book.Author}");
            }
        }
    }
}
