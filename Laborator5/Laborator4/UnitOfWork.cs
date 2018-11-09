namespace Laborator4
{
    public class UnitOfWork
    {
        private BookRepository _bookRepository;
        private AuthorRepository _authorRepository;
        private readonly ApplicationContext _applicationContext;

        public UnitOfWork(ApplicationContext context)
        {
            _applicationContext = context;
        }

        public BookRepository BookRepository
        {
            get
            {
                if (_bookRepository == null)
                {
                    _bookRepository = new BookRepository(_applicationContext);
                }

                return _bookRepository;
            }
        }

        public AuthorRepository AuthorRepository
        {
            get
            {
                if (_authorRepository == null)
                {
                    _authorRepository = new AuthorRepository(_applicationContext);
                }

                return _authorRepository;
            }
        }

        public void Savechanges()
        {
            _applicationContext.SaveChanges();
        }
    }
}