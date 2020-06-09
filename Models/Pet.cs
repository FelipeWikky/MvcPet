using System;
using System.ComponentModel.DataAnnotations;

namespace MvcPet.Models
{
  public class Pet
  {
    public int petId { get; set; }

    [Display(Name = "Espécie")]
    public string species { get; set; } //espécie

    [Display(Name = "Raça")]
    public string breed { get; set; } //raça

    [Display(Name = "Descrição do Pet")]
    public string description { get; set; } //descrição

    [Display(Name = "Imagem")]
    public string image { get; set; }

    [Display(Name = "Cadastrado em")]
    [DataType(DataType.Date)]
    public DateTime created { get; set; }

    [Display(Name="UF")]
    public string uf {get;set;}

    [Display(Name="Cidade")]
    public string city {get;set;}

    [Display(Name = "Doador")]
    public User donor { get; set; }

    public string donoruserId {get;set;}
  }
}