using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania
{
    class Program
    {
        static void Main(string[] args)
        {
            Zad1();
            Zad2();
            Zad3();
        }
        static void Zad1()
        {
            Ksiazka ksiazka1 = new Ksiazka("Władca Pierścieni", "J.R.R. Tolkien", 1954);
            Ksiazka ksiazka2 = new Ksiazka("Hobbit", "J.R.R. Tolkien", 1937);
            Ksiazka ksiazka3 = new Ksiazka("Harry Potter i Kamień Filozoficzny", "J.K. Rowling", 1997);

            ksiazka1.WyswietlInformacje();
            ksiazka2.WyswietlInformacje();
            ksiazka3.WyswietlInformacje();
        }
        static void Zad2()
        {
            var manager = new BookManager();

            // Dodawanie książek
            manager.AddBook("C# Programming", "John Doe", 2020);
            manager.AddBook("Advanced C#", "Jane Doe", 2021);
            manager.AddBook("Learning C#", "John Doe", 2020);

            // Edycja książki
            manager.EditBook(1, "C# Programming Updated", "John Doe", 2021);

            // Usuwanie książki
            manager.DeleteBook(3);

            // Wypisanie wszystkich książek
            Console.WriteLine("All Books:");
            foreach (var book in manager.GetAllBooks())
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Year: {book.YearPublished}");
            }

            // Wypisanie książek wybranego autora
            Console.WriteLine("\nBooks by John Doe:");
            foreach (var book in manager.GetBooksByAuthor("John Doe"))
            {
                Console.WriteLine($"Title: {book.Title}, Year: {book.YearPublished}");
            }

            // Wypisanie książek wydanego w wybranym roku
            Console.WriteLine("\nBooks published in 2021:");
            foreach (var book in manager.GetBooksByYear(2021))
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}");
            }
        }
        static void Zad3()
        {
            List<Kształt> kształty = new List<Kształt>
        {
            new Prostokąt(0, 0, 5, 4),
            new Trójkąt(0, 0, 3, 4, 3, 4, 5),
            new Koło(0, 0, 3),
            new Prostokąt(0, 0, 6, 2)
        };

            foreach (var kształt in kształty)
            {
                if (kształt.ObliczObwód() > 10)
                {
                    Console.WriteLine($"Pole: {kształt.ObliczPole()} (Obwód: {kształt.ObliczObwód()})");
                }
            }
        }
    }
}
