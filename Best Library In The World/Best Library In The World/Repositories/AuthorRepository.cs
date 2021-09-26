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
    public class AuthorRepository : IAuthorRepository
    {
        private readonly DatabaseContext _context;
        public AuthorRepository(DatabaseContext context)
        {
            _context = context;
        }
        public async Task<Author> create(Author author)
        {
            author.createdAt = DateTime.UtcNow;
            _context.author.Add(author);
            await _context.SaveChangesAsync();
            return author;
            //_context.authors.Add(author);
            //await _context.SaveChangesAsync();
            //throw new NotImplementedException();
        }
        public async Task<List<Author>> getAuthors()
        {
            List<Author> authors = await _context.author.ToListAsync();
            return authors;
        }

        public async Task<ActionResult> delete(int id)
        {
            Author author = await _context.author.FindAsync(id);
            if (author != null)
            {
                _context.author.Remove(author);
                await _context.SaveChangesAsync();// if( >0) its done

            }
            return author == null ? new NotFoundResult() : new OkResult();
        }

        public async Task<Author> getAuthor(int id)
        {
            Author author = await _context.author.FindAsync(id);
            return author;
        }
        public async Task<Author> getAuthor2(int id)
        {
            string name = "bo";
            Author author = await _context.author.Where((a) => a.id == id).FirstOrDefaultAsync();
            List<Author> obj = await _context.author.Where(a => a.id < id).ToListAsync();
            List<Author> obj2 = await _context.author.Where(hej => hej.firstname == name).ToListAsync();
            return author;
        }


        public Task<Author> getAuthorsBooks(int authorId, int bookStart, int bookLimit)
        {
            throw new NotImplementedException();
        }

        public Task<Author> upddate(Author author)
        {
            throw new NotImplementedException();
        }
    }
}