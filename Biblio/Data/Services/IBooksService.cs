using Biblio.Models;

namespace Biblio.Data.Services
{
    public interface IBooksService
    {
        Task<IEnumerable<Book>> GetAll();

        Task <Book> GetByIdAsync(int id);

        Task AddAsync(Book book);

        Task<Book> UpdateAsync(int id, Book newBook);

        Task DeleteAsync(int id);
    }
}
