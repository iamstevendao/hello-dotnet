using System;
using System.ComponentModel.DataAnnotations;

namespace HelloWorldAspNetCore.Models
{
  public class Movie
  {
    public int ID { get; set; }
    public string Title { get; set; }
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [DataType(DataType.Date)]
    public DateTime RealeaseDate { get; set; }
    public string Genre { get; set; }
    public decimal Price { get; set; }
  }
}