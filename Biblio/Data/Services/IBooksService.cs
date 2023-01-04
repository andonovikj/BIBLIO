using Biblio.Models;

namespace Biblio.Data.Services
{
    public interface IBooksService
    {
        Task<IEnumerable<Book>> GetAll();

        Book GetById(int id);

        void Add(Book author);

        Book Update(int id, Book newAuthor);
    }
}
