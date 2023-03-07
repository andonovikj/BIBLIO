using Biblio.Models;

namespace Biblio.Data.Service
{
    public interface IAuthorsService
    {
        Task<IEnumerable<Author>> GetAll();

        Author GetById(int id);

        Task <Author> GetByIdAsync(int id);

        Task AddAsync(Author author);

        Task <Author> UpdateAsync(int id, Author newAuthor);

        Task DeleteAsync(int id);

    }
}
