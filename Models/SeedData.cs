using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace HelloWorldAspNetCore.Models
{
  public static class SeedData
  {
    public static void Initialize(IServiceProvider serviceProvider)
    {
      using (var context = new MvcMovieContext(serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
      {
        if (!context.Movie.Any())
          context.Movie.AddRange(
             new Movie
             {
               Title = "When Harry Met Sally",
               RealeaseDate = DateTime.Parse("1989-1-11"),
               Genre = "Romantic Comedy",
               Price = 7.99M,
               Rating = "R"
             },

              new Movie
              {
                Title = "Ghostbusters ",
                RealeaseDate = DateTime.Parse("1984-3-13"),
                Genre = "Comedy",
                Price = 8.99M,
                Rating = "G"
              },

              new Movie
              {
                Title = "Ghostbusters 2",
                RealeaseDate = DateTime.Parse("1986-2-23"),
                Genre = "Comedy",
                Price = 9.99M,
                Rating = "A"
              },

              new Movie
              {
                Title = "Rio Bravo",
                RealeaseDate = DateTime.Parse("1959-4-15"),
                Genre = "Western",
                Price = 3.99M,
                Rating = "X"
              }
          );

        if (!context.Person.Any())
          context.Person.AddRange(
             new Person
             {
               Name = "Steven Gerrard",
               Dob = DateTime.Parse("1989-1-11"),
               Address = "Romantic Comedy"
             },

              new Person
              {
                Name = "Daniel Agger",
                Dob = DateTime.Parse("1999-1-11"),
                Address = "Romantic Comedy"
              },

              new Person
              {
                Name = "Fernando Torres",
                Dob = DateTime.Parse("1989-1-11"),
                Address = "Romantic Comedy"
              },

              new Person
              {
                Name = "Emre Can",
                Dob = DateTime.Parse("1989-1-11"),
                Address = "Romantic Comedy"
              }
          );

        context.SaveChanges();
      }

    }
  }
}