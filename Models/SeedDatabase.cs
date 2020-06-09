using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcPet.Data;
using System;
using System.Linq;

using MvcPet.Areas.Identity.Data;

namespace MvcPet.Models
{
  public static class SeedDatabase
  {

    public static void Initialize(IServiceProvider serviceProvider)
    {
      seedClassAnimals(serviceProvider);
    }

    private static void seedClassAnimals(IServiceProvider serviceProvider)
    {
      using (var context = new MvcPetIdentityDbContext(
        serviceProvider.GetRequiredService<DbContextOptions<MvcPetIdentityDbContext>>()
      ))
      {
        if (context.Animals.Any())
        {
          return; //já tem registros na tabela então sem seed dnv
        }

        context.Animals.AddRange(
          new Animalclass {
            id = 1,
            name = "Mamífero"
          },
          new Animalclass {
            id = 2,
            name = "Ave"
          },
          new Animalclass {
            id = 3,
            name = "Réptil"
          },
          new Animalclass {
            id = 4,
            name = "Anfíbio"
          },
          new Animalclass {
            id = 5,
            name = "Peixe"
          },
          new Animalclass {
            id = 6,
            name = "Crustáceo"
          },
          new Animalclass {
            id = 7,
            name = "Aracnídeo"
          },
          new Animalclass {
            id = 8,
            name = "Outro"
          }
        );
        context.SaveChanges();

      }
    }

  }
}