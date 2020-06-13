using System.Collections.Generic;
using MvcPet.Models;

namespace MvcPet.Models {
  public class UserPetViewModel {

    public User User {get;set;}
    public IEnumerable<User> Users {get;set;}

    public Pet Pet {get;set;}
    public IEnumerable<Pet> Pets {get;set;}
  }
}