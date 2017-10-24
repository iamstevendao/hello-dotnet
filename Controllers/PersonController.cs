using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System;
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

    // POST: api/person/Edit/5
    [HttpPost]
    [Route("api/Person/Edit/{id}")]
    public async Task<String> Edit(int id, [Bind("ID,Name,Dob,Address")] Person person)
    {
      if (id != person.ID)
      {
        return "Person is not found";
      }

      if (ModelState.IsValid)
      {
        try
        {
          _context.Update(person);
          await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
          if (!PersonExists(person.ID))
          {
            return "Person is not found";
          }
          else
          {
            throw;
          }
        }
        return "success!";
        // return RedirectToAction(nameof(Index));
      }
      return "failed!";
    }

    // POST: api/person/Edit/5
    [HttpPost]
    [Route("api/Person/Delete/{id}")]
    public async Task<String> Delete(int id)
    {
      try
      {
        var person = await _context.Person.SingleOrDefaultAsync(m => m.ID == id);
        _context.Person.Remove(person);
        await _context.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!PersonExists(id))
        {
          return "Person is not found";
        }
        else
        {
          throw;
        }
      }
      return "success!";
    }

    private bool PersonExists(int id)
    {
      return _context.Person.Any(e => e.ID == id);
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

    //   var person = await _context.person.SingleOrDefaultAsync(m => m.ID == id);
    //   if (person == null)
    //   {
    //     return NotFound();
    //   }
    //   return View(person);
    // }
  }
}