using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MvcPet.Models;

namespace MvcPet.ViewModels {
  public class RoleViewModel{
    public RoleViewModel(){
      Users = new List<User>();
    }

    public string id {get;set;}

    [Required(ErrorMessage="É necessário informar um Nome para o Perfil")]
    [Display(Name="Perfil")]
    public string roleName {get;set;}

    public List<User> Users {get;set;}

  }
}