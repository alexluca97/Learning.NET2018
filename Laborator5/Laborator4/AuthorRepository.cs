using System.Linq;

namespace Laborator4
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly ApplicationContext _context;

        public AuthorRepository(ApplicationContext applicationContext)
        {
            _context = applicationContext;
        }

        public void Add(Author author)
        {
            _context.Authors.Add(author);
        }

        public void Delete(Author author)
        {
            _context.Authors.Remove(author);
        }

        public void DeleteById(int id)
        {
            var author = _context.Authors.First(a => a.Id == id);
            _context.Authors.Remove(author);
        }
    }
}