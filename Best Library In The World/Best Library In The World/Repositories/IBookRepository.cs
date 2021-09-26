using Best_Library_In_The_World.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Best_Library_In_The_World.Repositories
{
    public interface IBookRepository
    {
        Task<Book> create(Book book);
        Task<ActionResult> delete(int id);
        Task<Book> upddate(Book book);
        Task<List<Book>> getBooks();
        //Task<List<Author>> getAuthors(int start, int limit);
        Task<Book> getBook(int id);
        Task<Book> getBooksAuthor
            (int bookID);
    }
}
