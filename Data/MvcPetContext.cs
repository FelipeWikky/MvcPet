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
    }
}