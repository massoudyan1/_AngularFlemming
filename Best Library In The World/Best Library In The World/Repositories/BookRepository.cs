using Best_Library_In_The_World.Domain;
using Best_Library_In_The_World.Env;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Best_Library_In_The_World.Repositories
{
    public class BookRepository : IBookRepository
    {

        private readonly DatabaseContext _context;
        public BookRepository(DatabaseContext context)
        {
            _context = context;
        }
        public async Task<Book> create(Book book)
        {
            book.createdAt = DateTime.UtcNow;
            _context.book.Add(book);
            await _context.SaveChangesAsync();
            return book;

        }
        public async Task<List<Book>> getBooks()
        {
            List<Book> books = await _context.book.ToListAsync();
            return books;
        }

        public async Task<ActionResult> delete(int id)
        {
            Book book = await _context.book.FindAsync(id);
            if (book != null)
            {
                _context.book.Remove(book);
                await _context.SaveChangesAsync();// if( >0) its done

            }
            return book == null ? new NotFoundResult() : new OkResult();
        }

        public async Task<Book> getBook(int id)
        {
            Book book = await _context.book.FindAsync(id);
            return book;
        }

        public Task<Book> getBooksAuthor(int bookID)
        {
            throw new NotImplementedException();
        }

        public Task<Book> upddate(Book book)
        {
            throw new NotImplementedException();
        }

    }
}
