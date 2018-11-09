using System.Linq;

namespace Laborator4
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationContext _context;

        public BookRepository(ApplicationContext applicationContext)
        {
            _context = applicationContext;
        }

        public void Add(Book book)
        {
            _context.Books.Add(book);
        }

        public void Delete(Book book)
        {
            _context.Books.Remove(book);
        }
        public void DeleteById(int id)
        {
            var book = _context.Books.First(a => a.Id == id);
            _context.Books.Remove(book);
        }
    }
}