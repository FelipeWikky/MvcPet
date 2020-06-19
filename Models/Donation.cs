using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

    // [NotMapped] [Column("doadoruserId")] 
    public string doadoruserId {get;set;}
    // [NotMapped] [Column("doacaopetId")] 
    public int doacaopetId {get;set;}
    // [NotMapped] [Column("donatariouserId")] 
    public string donatariouserId {get;set;}

  }
}