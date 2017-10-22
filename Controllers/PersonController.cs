using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace HelloWorldAspNetCore.Controllers
{
  public class PersonController : Controller
  {
    // GET: /Person/
    public IActionResult Index()
    {
      return View();
    }

    // GET: Person/Details/5
    // public async Task<IActionResult> Details(int? id)
    // {
    //   if (id == null)
    //   {
    //     return NotFound();
    //   }

    //   var person = await _context.Person
    //       .SingleOrDefaultAsync(m => m.ID == id);
    //   if (person == null)
    //   {
    //     return NotFound();
    //   }

    //   return View(person);
    // }

    // GET: Person/Edit/5
    // public async Task<IActionResult> Edit(int? id)
    // {
    //   if (id == null)
    //   {
    //     return NotFound();
    //   }

    //   var movie = await _context.Movie.SingleOrDefaultAsync(m => m.ID == id);
    //   if (movie == null)
    //   {
    //     return NotFound();
    //   }
    //   return View(movie);
    // }
  }
}