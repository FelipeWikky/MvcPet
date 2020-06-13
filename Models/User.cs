using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace MvcPet.Models
{
  public class User
  {
    public string userId { get; set; }

    [Display(Name = "Usuário")]
    public string name { get; set; }

    [Display(Name = "E-mail")]
    public string email { get; set; }

    [Display(Name = "Telefone")]
    public string phone { get; set; }

    public virtual ICollection<Pet> pets {get; set;}

  }
}