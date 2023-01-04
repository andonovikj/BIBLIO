using Biblio.Models;
using Microsoft.EntityFrameworkCore;

namespace Biblio.Data.Services
{
    public class BooksService : IBooksService
    {

        private readonly AppDbContext _context;

        public BooksService(AppDbContext context)
        {
            _context = context;
        }        

        public void Add(Book author)
        {
            throw new NotImplementedException();
        }

        
        public async Task<IEnumerable<Book>> GetAll()
        {
            var result = await _context.Books.ToListAsync();
            return result;
        }

        public Book GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Book Update(int id, Book newAuthor)
        {
            throw new NotImplementedException();
        }
                      
    }
}
