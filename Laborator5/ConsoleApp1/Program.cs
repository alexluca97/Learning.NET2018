using Laborator4;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var unitOfWork = new UnitOfWork(new ApplicationContext());

            unitOfWork.AuthorRepository.Add(new Author
            {
                Id = 1,
                FirstName = "Gensthaler",
                LastName = "Octavian"
            });

            unitOfWork.BookRepository.Add(new Book
            {
                Id = 1,
                Title = "How to pass Intro to .NET"
            });

            unitOfWork.Savechanges();
        }
    }
}
