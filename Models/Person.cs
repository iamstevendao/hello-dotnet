using System;
using System.ComponentModel.DataAnnotations;

namespace HelloWorldAspNetCore.Models
{
  public class Person
  {
    public int ID { get; set; }

    [StringLength(60, MinimumLength = 3)]
    [Required]
    public string Name { get; set; }

    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [DataType(DataType.Date)]
    public DateTime Dob { get; set; }

    [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
    [StringLength(30)]
    [Required]
    public string Address { get; set; }
  }
}