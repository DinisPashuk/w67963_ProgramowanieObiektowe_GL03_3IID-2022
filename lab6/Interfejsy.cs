using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public interface IEntity<TId>
    {
        TId Id { get; set; }
    }

    public interface ICreationDate
    {
        DateTime CreationDate { get; set; }
    }

    public interface IBaseRepository<T, TEntity> where T : IEntity<TEntity>
    {
        void Create(T entity);
        void Update(T entity);
        List<T> GetAll();
        T Get(TEntity id);
        void Delete(TEntity id);
    }

    public interface IBookRepository : IBaseRepository<Book, int>
    {
        List<Book> GetBooksByAuthor(string author);
        List<Book> GetBooksByYear(int year);
    }

    public interface IPersonRepository : IBaseRepository<Person, int>
    {
        List<Book> GetBorrowedBooks(int personId);
        void AddBookToPerson(int personId, Book book);
    }
}
