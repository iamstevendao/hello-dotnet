using Microsoft.EntityFrameworkCore;

namespace HelloWorldAspNetCore.Models
{
  public class MvcMovieContext : DbContext
  {
    public MvcMovieContext(DbContextOptions<MvcMovieContext> options) : base(options)
    {

    }

    public DbSet<HelloWorldAspNetCore.Models.Movie> Movie { get; set; }

    public DbSet<HelloWorldAspNetCore.Models.Person> Person { get; set; }
  }
}