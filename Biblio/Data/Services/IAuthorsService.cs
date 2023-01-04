using Biblio.Models;

namespace Biblio.Data.Service
{
    public interface IAuthorsService
    {
        Task<IEnumerable<Author>> GetAll();

        Task <Author> GetByIdAsync(int id);

        Task AddAsync(Author author);

        Task <Author> UpdateAsync(int id, Author newAuthor);

        Task DeleteAsync(int id);

    }
}
