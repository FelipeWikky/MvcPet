using System.ComponentModel.DataAnnotations;

namespace MvcPet.Models
{
  public class User
  {
    public string Id { get; set; }

    [Display(Name = "E-Mail")]
    public string Email { get; set; }

    [Display(Name = "Telefone")]
    public string PhoneNumber { get; set; }

    [Display(Name = "Usuário")]
    public string UserName { get; set; }
  }
}