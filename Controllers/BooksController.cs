
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
public class BooksController : Controller
{
    private BooksDataContext Context;

    public BooksController(BooksDataContext context)
    {
        Context = context;
    }
    [HttpGet("/books")]
    public async Task<IActionResult> GetAllBooks()
    {
        return Ok(await Context.Books.ToArrayAsync());
    }
}