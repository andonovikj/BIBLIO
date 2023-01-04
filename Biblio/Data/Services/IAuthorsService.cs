using Biblio.Models;

namespace Biblio.Data.Service
{
    public interface IAuthorsService
    {
        Task<IEnumerable<Author>> GetAll();

        Author GetById(int id);

        void Add(Author author);

        Author Update(int id, Author newAuthor);

    }
}
