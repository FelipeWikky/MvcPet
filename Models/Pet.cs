using System;
using System.ComponentModel.DataAnnotations;

namespace MvcPet.Models
{
  public class Pet
  {
    public int PetId { get; set; }

    [Display(Name = "Espécie")]
    public string species { get; set; } //espécie
    [Display(Name = "Raça")]
    public string breed { get; set; } //raça

    [Display(Name = "Descrição Pet")]
    public string description { get; set; } //descrição

    public string image {get;set;}

    [Display(Name = "Data de Entrada")]
    [DataType(DataType.Date)]
    public DateTime created { get; set; }

  [Display(Name = "Doador")]
    public User donor { get; set; }
  }
}