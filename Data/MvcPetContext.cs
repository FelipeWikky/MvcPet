using Microsoft.EntityFrameworkCore;
using MvcPet.Models;

namespace MvcPet.Data
{
    public class MvcPetContext : DbContext
    {
        public MvcPetContext (DbContextOptions<MvcPetContext> options)
            : base(options)
        {
        }

        // public DbSet<User> Users { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Animalclass> Animals {get;set;}
        public DbSet<UF> Ufs { get; set; }
        public DbSet<Donation> Donations { get; set; }
    }
}