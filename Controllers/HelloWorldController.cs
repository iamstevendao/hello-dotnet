using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace HelloWorldAspNetCore.Controllers
{
  public class HelloWorldController : Controller
  {
    // GET: /HelloWorld/
    public IActionResult Index()
    {
      return View();
    }

    // GET: /HelloWorld/Welcome/
    public IActionResult Welcome(string name, int numTimes = 1)
    {
      //return "This is the Welcome method...";
      //return HtmlEncoder.Default.Encode($"Hello {name}, numTimes is {ID}");
      ViewData["Message"] = "Hello " + name;
      ViewData["NumTimes"] = numTimes;

      return View();
    }
  }
}