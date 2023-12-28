using BlazorWebApp.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlazorWebApp.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataGridController : ControllerBase
    {
        public DataGridController ()
        {

        }

        [HttpGet]
        public async Task<ActionResult<List<Book>>> Get ()
        {
            LibraryContext db = new LibraryContext();
            return db.Books.ToList();
        }

        [HttpPost]

        public async Task<ActionResult<Book>> Post ( Book value )
        {
            LibraryContext db = new LibraryContext();
            db.Books.Add(value);
            db.SaveChanges();
            return Ok(value);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Book>> Put ( long id, Book updatedBook )
        {
            using (LibraryContext db = new LibraryContext())
            {
                var existingBook = await db.Books.FindAsync(id);

                if (existingBook == null)
                {
                    return NotFound(); // Return 404 Not Found if the book with the given id is not found
                }

                // Update the properties of the existing book with the values from the updated book
                existingBook.Name = updatedBook.Name;
                existingBook.Author = updatedBook.Author;
                existingBook.Price = updatedBook.Price;
                existingBook.Quantity = updatedBook.Quantity;
                // Update other properties as needed

                await db.SaveChangesAsync(); // Save changes to the database

                return Ok(existingBook); // Return the updated book
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete ( long id )
        {
            LibraryContext db = new LibraryContext();
            var book = db.Books.Find(id);

            if (book == null)
            {
                return NotFound();
            }

            db.Books.Remove(book);
            db.SaveChanges();

            return NoContent();
        }
    }
}
