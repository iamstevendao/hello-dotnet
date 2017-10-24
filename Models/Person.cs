using System;
using System.ComponentModel.DataAnnotations;

namespace HelloWorldAspNetCore.Models
{
  public class Person
  {

    public Person(int id, string name, string dob, string address)
    {
      ID = id;
      Name = name;
      Dob = dob;
      Address = address;
    }

    public Person() { }
    public int ID { get; set; }

    [StringLength(60, MinimumLength = 3)]
    [Required]
    public string Name { get; set; }
    public string Dob { get; set; }

    [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
    [StringLength(30)]
    [Required]
    public string Address { get; set; }
  }
}