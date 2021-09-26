using Best_Library_In_The_World.Domain;
using Best_Library_In_The_World.Env;
using Best_Library_In_The_World.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Best_Library_In_The_World.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //Endpoint
    public class AuthorsWithoutScaffoldingController : ControllerBase
    {

        public AuthorsWithoutScaffoldingController(IAuthorRepository authorRep)
        {
            _authorRep = authorRep;
        }

        public IAuthorRepository _authorRep { get; set; }

        [HttpPost]
        public async Task<ActionResult<Author>> postAuthor(Author author)
        {
            try
            {
                if (author == null)
                {
                    return NoContent();
                }
                // return await _authorRep.create(author);
                var createdAuthor = await _authorRep.create(author);
                return Created("", createdAuthor);
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }
        // methods that calls the database
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Author>>> getAuthors()
        {
            try
            {
                var authors = await _authorRep.getAuthors();
                if (authors == null) { return NoContent(); }
                return Ok(authors);
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Author>> getAuthor(int id)
        {
            try
            {
                Author author = await _authorRep.getAuthor(id);
                return author == null ? NotFound() : Ok(author);
                //if (author==null)
                //{
                //    return NotFound();
                //}
                //return Ok(author);
            }
            catch (Exception banan)
            {
                return Problem(banan.Message);
            }
        }

        [HttpDelete]
        [Route(("delete/{id}"))]
        public async Task<ActionResult<Author>> DeleteTask(int id)
        {
            try
            {
                var author = await _authorRep.DeleteTask(id);
                return Ok(author);
            }
            catch (Exception)
            {

                throw;
            }
        }

        // public string get() { return "iam an endpoint"; }
    }
}