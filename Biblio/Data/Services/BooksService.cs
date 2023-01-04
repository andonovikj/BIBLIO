﻿using Biblio.Models;
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

        public async Task AddAsync(Book book)
        {
            await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();
        }

        
        public async Task<IEnumerable<Book>> GetAll()
        {
            var result = await _context.Books.ToListAsync();
            return result;
        }

        public async Task<Book> GetByIdAsync(int id)
        {
            var result = await _context.Books.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }

        public async Task<Book> UpdateAsync(int id, Book newBook)
        {
            _context.Update(newBook);
            await _context.SaveChangesAsync();
            return newBook;
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Books.FirstOrDefaultAsync(n => n.Id == id);
            _context.Books.Remove(result);
            await _context.SaveChangesAsync();
        }

    }
}
