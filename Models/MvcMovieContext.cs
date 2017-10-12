using Microsoft.EntityFrameworkCore;

namespace HelloWorldAspNetCore.Models
{
  public class MvcMovieContext : DbContext
  {
    public MvcMovieContext(DbContextOptions<MvcMovieContext> options) : base(options)
    {

    }

    public DbSet<HelloWorldAspNetCore.Models.Movie> Movie { get; set; }
  }
}