using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace MvcPet.Models {
  public class UF {

    [Key]
    public string sigla {get;set;}
    [Display(Name="UF")]
    public string nome {get;set;}
  }
}