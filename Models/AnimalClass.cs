using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MvcPet.Models {
  public class Animalclass {

    public int id {get;set;}

    [Display(Name="Classe Animal")]
    public string name {get;set;}
  }
}