using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace MvcPet.Models {
  public class UF {
    public int id {get;set;}
    public string sigla {get;set;}
    public string nome {get;set;}
  }
}