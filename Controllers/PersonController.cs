using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using HelloWorldAspNetCore.Models;

namespace HelloWorldAspNetCore.Controllers
{
  public class PersonController : Controller
  {
    private readonly MvcMovieContext _context;

    public PersonController(MvcMovieContext context)
    {
      _context = context;
    }
    // GET: /Person/
    public IActionResult Index()
    {
      return View();
    }

    [HttpPost]
    [Route("api/Person/List")]
    public async Task<ActionResult> GetListPerson()
    {
      var list = _context.Person;
      return Json(list);
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