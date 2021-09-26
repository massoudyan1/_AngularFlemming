using Best_Library_In_The_World.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Best_Library_In_The_World.Repositories
{
    public interface IAuthorRepository
    {
        Task<Author> create(Author author);
        Task<ActionResult> delete(int id);
        Task<Author> upddate(Author author);
        Task<List<Author>> getAuthors();
        //Task<List<Author>> getAuthors(int start, int limit);
        Task<Author> getAuthor(int id);
        Task<Author> getAuthorsBooks
            (int authorId, int bookStart, int bookLimit);
    }
}
