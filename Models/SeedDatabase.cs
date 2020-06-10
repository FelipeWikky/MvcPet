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

    private static void seedUfs(IServiceProvider serviceProvider) {
      using (var context = new MvcPetIdentityDbContext(
        serviceProvider.GetRequiredService<DbContextOptions<MvcPetIdentityDbContext>>()
      ))
      {
        if (context.Ufs.Any())
        {
          return; //já tem registros na tabela então sem seed dnv
        }

        context.Ufs.AddRange(
          new UF{
            sigla="AC",
            nome="Acre",
          },
          new UF{
            sigla="AL",
            nome="Alagoas",
          },
          new UF{
            sigla="AP",
            nome="Amapá",
          },
          new UF{
            sigla="AM",
            nome="Amazonas",
          },
          new UF{
            sigla="BA",
            nome="Bahia",
          },
          new UF{
            sigla="CE",
            nome="Ceará",
          },
          new UF{
            sigla="DF",
            nome="Distrito Federal",
          },
          new UF{
            sigla="ES",
            nome="Espírito Santo",
          },
          new UF{
            sigla="GO",
            nome="Goiás",
          },
          new UF{
            sigla="MA",
            nome="Maranhão",
          },
          new UF{
            sigla="MT",
            nome="Mato Grosso",
          },
          new UF{
            sigla="MS",
            nome="Mato Grosso do Sul",
          },
          new UF{
            sigla="MG",
            nome="Minas Gerais",
          },
          new UF{
            sigla="PA",
            nome="Pará",
          },
          new UF{
            sigla="PB",
            nome="Paraíba",
          },
          new UF{
            sigla="PR",
            nome="Paraná",
          },
          new UF{
            sigla="PE",
            nome="Pernambuco",
          },
          new UF{
            sigla="PI",
            nome="Piauí",
          },
          new UF{
            sigla="RJ",
            nome="Rio de Janeiro",
          },
          new UF{
            sigla="RN",
            nome="Rio Grande do Norte",
          },
          new UF{
            sigla="RS",
            nome="Rio Grande do Sul",
          },
          new UF{
            sigla="RO",
            nome="Rondônia",
          },
          new UF{
            sigla="RR",
            nome="Roraima",
          },
          new UF{
            sigla="SC",
            nome="Santa Catarina",
          },
          new UF{
            sigla="SP",
            nome="São Paulo",
          },
          new UF{
            sigla="SE",
            nome="Sergipe",
          },
          new UF{
            sigla="TO",
            nome="Tocantins",
          }
        );
        context.SaveChanges();

      }
    }
  }
}