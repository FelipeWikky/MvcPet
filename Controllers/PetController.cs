using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcPet.Data;
using MvcPet.Models;
using MvcPet.ViewModels;

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;

using System.Web;
using System.Net;
using System.IO;
using System.Text;
using System.Runtime.Serialization.Json;

using Newtonsoft.Json;

namespace MvcPet.Controllers
{
  [Authorize(Roles = "Admin, User")]
  public class PetController : Controller
  {
    private readonly MvcPetContext _context;
    private readonly SignInManager<IdentityUser> _signInManager;
    private readonly UserManager<IdentityUser> _userManager;

    public PetController(
      MvcPetContext context,
      UserManager<IdentityUser> userManager,
      SignInManager<IdentityUser> signInManager
    )
    {
      _context = context;
      _signInManager = signInManager;
      _userManager = userManager;
    }

    [AllowAnonymous]
    public async Task<IActionResult> Index(int animal, string uf, int useCreated, DateTime created)
    {
      ViewBag.Animals = await _context.Animals.ToListAsync();

      ViewBag.Ufs = await _context.Ufs.OrderByDescending(u => u.sigla).ToListAsync();

      var pets = from m in _context.Pets select m;
      pets = pets.OrderByDescending(s => s.petId);


      // Filtros
      if (animal > 0)
      {
        pets = pets.Where(p => p.animalid == animal);
        ViewBag.animal = (await _context.Animals.FirstOrDefaultAsync(a => a.id == animal)).name;
      }
      if (!String.IsNullOrEmpty(uf))
      {
        pets = pets.Where(p => p.uf == uf);
        ViewBag.uf = (await _context.Ufs.FirstOrDefaultAsync(u => u.sigla == uf)).sigla;
      }
      if (useCreated > 0)
      {
        pets = pets.Where(p => p.created == created);
        ViewBag.created = created.ToString().Split(" ")[0];
      }

      List<Pet> listPet = await pets.ToListAsync();
      if (listPet.Count > 0)
      {
        foreach (Pet pet in listPet)
        {
          User user = await _context.Users.FirstOrDefaultAsync(u => u.userId == pet.donoruserId);
          pet.donor = user;
        }
      }
      return View(listPet);
    }

    [AllowAnonymous]
    public async Task<IActionResult> Details(int? id)
    {
      if (id == null)
      {
        return NotFound();
      }

      var pet = await _context.Pets
          .FirstOrDefaultAsync(m => m.petId == id);
      if (pet == null)
      {
        return NotFound();
      }

      User user = await _context.Users.FirstOrDefaultAsync(u => u.userId == pet.donoruserId);
      pet.donor = user;

      return View(pet);
    }

    public async Task<IActionResult> Create()
    {
      var ufs = await _context.Ufs.ToListAsync();
      ViewBag.ufs = ufs;
      var animals = await _context.Animals.ToListAsync();
      ViewBag.animals = animals;

      return View();


      // //recebendo estados de uma api
      // string url = "https://servicodados.ibge.gov.br/api/v1/localidades/estados/";
      // // HttpWebRequest request = (HttpWebRequest) WebRequest.Create(url);
      // // WebResponse response = request.GetResponse();

      // var request = WebRequest.CreateHttp(url);
      // request.Method = "GET";
      // request.UserAgent = "RequisicaoWebDemo";

      // using (var response = request.GetResponse())
      // {
      //   var streamDados = response.GetResponseStream();
      //   StreamReader reader = new StreamReader(streamDados);
      //   object objResponse = reader.ReadToEnd();

      //   var ufs = JsonConvert.DeserializeObject<UF[]>(objResponse.ToString());
      //   ViewBag.ufs = ufs;
      //   // foreach(UF uf in ufs){
      //   //   Console.WriteLine(uf.nome);
      //   // }
      //   // Console.WriteLine( ufs.ToString() );

      //   streamDados.Close();
      //   response.Close();
      // }
      // return View();


    }

    // POST: Pet/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to, for 
    // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("petId,animalid,species,breed,description,image,uf,city")] Pet pet)
    {
      if (ModelState.IsValid)
      {

        //Adicionar Usuário Doador
        User user = await _context.Users
          .FirstOrDefaultAsync(u => u.userId == _userManager.GetUserId(User));
        pet.donor = user;

        //Adicionar created atual
        pet.created = DateTime.Today;

        _context.Add(pet);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
      }
      return View(pet);
    }

    // GET: Pet/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
      if (id == null)
      {
        return NotFound();
      }

      var pet = await _context.Pets.FindAsync(id);
      if (pet == null)
      {
        return NotFound();
      }

      var animals = await _context.Animals.ToListAsync();
      ViewBag.animals = animals;
      var ufs = await _context.Ufs.ToListAsync();
      ViewBag.ufs = ufs;

      return View(pet);
    }

    // POST: Pet/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to, for 
    // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("petId,animalid,species,breed,description,image,created,uf,city")] Pet pet)
    {
      if (id != pet.petId)
      {
        return NotFound();
      }

      if (ModelState.IsValid)
      {
        try
        {
          //recuperar Usuário
          User user = await _context.Users
            .FirstOrDefaultAsync(u => u.userId == _userManager.GetUserId(User));
          pet.donor = user;

          _context.Update(pet);
          await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
          if (!PetExists(pet.petId))
          {
            return NotFound();
          }
          else
          {
            throw;
          }
        }
        return RedirectToAction(nameof(MyDonations));
      }
      return View(pet);
    }

    // GET: Pet/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
      if (id == null)
      {
        return NotFound();
      }

      var pet = await _context.Pets
          .FirstOrDefaultAsync(m => m.petId == id);
      if (pet == null)
      {
        return NotFound();
      }

      if (pet.donoruserId != _userManager.GetUserId(User))
      {
        return RedirectToAction(nameof(MyDonations));
      }

      return View(pet);
    }

    // POST: Pet/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
      var pet = await _context.Pets.FindAsync(id);
      _context.Pets.Remove(pet);
      await _context.SaveChangesAsync();
      return RedirectToAction(nameof(MyDonations));
    }

    private bool PetExists(int id)
    {
      return _context.Pets.Any(e => e.petId == id);
    }

    public async Task<IActionResult> MyDonations()
    {
      if (_signInManager.IsSignedIn(User))
      {
        var pets = from m in _context.Pets select m;

        pets = pets.Where(s => s.donoruserId.Equals(_userManager.GetUserId(User)));
        pets = pets.OrderByDescending(s => s.petId);
        // return View(await pets.ToListAsync());

        List<Pet> listPet = await pets.ToListAsync();

        if (listPet.Count > 0)
        {
          User user = await _context.Users.FirstOrDefaultAsync(u => u.userId == _userManager.GetUserId(User));
          foreach (Pet pet in listPet)
          {
            pet.donor = user;
          }
        }
        return View(listPet);
      }
      else
      {
        return RedirectToAction(nameof(Index));
      }
    }

    [HttpPost]
    public async Task<IActionResult> Donate(string id)
    {
      Pet pet = await _context.Pets.FirstOrDefaultAsync(p => p.petId == Convert.ToInt32(id));

      //usuário que está doando o pet
      User doador = await _context.Users.FirstOrDefaultAsync(u => u.userId == pet.donoruserId);
      //usuário que quer adotar o pet
      User donatario = await _context.Users.FirstOrDefaultAsync(u => u.userId == _userManager.GetUserId(User));

      if (doador.userId == donatario.userId)
      {
        TempData["Alert"] = "Danger:Não pode adotar um pet que você mesmo cadastrou!";
        return RedirectToAction("Details", "Pet", new { id = id });
      }

      Donation donation = await _context.Donations.FirstOrDefaultAsync(
        d =>
          d.doador.userId == doador.userId
        &&
          d.doacao.petId == pet.petId
        &&
          d.donatario.userId == donatario.userId
      );

      if (donation != null)
      {
        TempData["Alert"] = "Danger:Você já demonstrou interesse em adotar este Pet!";
        return RedirectToAction("Details", "Pet", new { id = id });
      }

      donation = new Donation();
      donation.doacao = pet;
      donation.doador = doador;
      donation.donatario = donatario;
      _context.Donations.Add(donation);
      await _context.SaveChangesAsync();

      TempData["Alert"] = "Success:Notificação de Adoção encaminhada para o Doador!";
      return RedirectToAction("Details", "Pet", new { id = id });
    }

    [HttpGet]
    public async Task<IActionResult> Interest()
    {
      InterestViewModel vm = new InterestViewModel();
      IdentityUser identityUser = await _userManager.GetUserAsync(User);

      //Recuperando Interesses
      var query = from i in _context.Donations select i;
      query = query.Where(i => i.donatario.userId == identityUser.Id);

      List<Donation> interesses = await query.ToListAsync();

      foreach (var item in interesses)
      {
        item.doador = await _context.Users.FirstOrDefaultAsync(u => u.userId == item.doadoruserId);
        item.doacao = await _context.Pets.FirstOrDefaultAsync(p => p.petId == item.doacaopetId);
        item.donatario = await _context.Users.FirstOrDefaultAsync(u => u.userId == item.donatariouserId);
      }
      vm.interesses = interesses; //pets que eu demonstrei interesse

      //Recuperando Interessados
      var query2 = from i in _context.Donations select i;
      query2 = query2.Where(i => i.doador.userId == identityUser.Id);

      List<Donation> interessados = await query2.ToListAsync();
      foreach (var item in interessados)
      {
        item.doador = await _context.Users.FirstOrDefaultAsync(u => u.userId == item.doadoruserId);
        item.doacao = await _context.Pets.FirstOrDefaultAsync(p => p.petId == item.doacaopetId);
        item.donatario = await _context.Users.FirstOrDefaultAsync(u => u.userId == item.donatariouserId);
      }
      vm.interessados = interessados; //pets que usuários ficaram interessados

      return View(vm);
    }

  }

}
