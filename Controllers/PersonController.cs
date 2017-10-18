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
  }
}