namespace Laborator4
{
    public interface IAuthorRepository
    {
        void Add(Author author);
        void Delete(Author author);
        void DeleteById(int id);
    }
}