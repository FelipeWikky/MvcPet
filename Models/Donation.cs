using System.ComponentModel.DataAnnotations;

namespace MvcPet.Models
{
  public class Donation {

    [Key]
    public int Id {get;set;}

    [Key]
    public User doador {get;set;}

    [Key]
    public Pet doacao {get;set;}

    [Key]
    public User donatario {get;set;}
  }
}