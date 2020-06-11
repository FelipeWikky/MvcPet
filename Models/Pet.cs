using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcPet.Models
{
  public class Pet
  {
    public int petId { get; set; }

    public Animalclass animal {get;set;}

    // [NotMapped]
    [Display(Name="Classe Animal")]
    public int animalid {get;set;}

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

    [Display(Name="Estado")]
    public string uf {get;set;}

    [Display(Name="Cidade")]
    public string city {get;set;}

    [Display(Name = "Doador")]
    public User donor { get; set; }

    // [NotMapped]
    public string donoruserId {get;set;}

  }
}