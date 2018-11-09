namespace Laborator4
{
    public interface IBookRepository
    {
        void Add(Book book);
        void Delete(Book book);
        void DeleteById(int id);
    }
}