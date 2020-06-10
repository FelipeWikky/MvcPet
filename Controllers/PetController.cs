using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcPet.Data;
using MvcPet.Models;

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
  public class PetController : Controller
  {
    private readonly MvcPetContext _context;
    private readonly SignInManager<IdentityUser> _signInManager;
    private readonly UserManager<IdentityUser> _userManager;

    public PetController(
        MvcPetContext context,
        UserManager<IdentityUser> userManager,
        SignInManager<IdentityUser> signInManager)
    {
      _context = context;
      _signInManager = signInManager;
      _userManager = userManager;
    }

    // GET: Pet
    public async Task<IActionResult> Index(int filter)
    {

      var animals = from a in _context.Animals select a;
      ViewBag.Animals = await animals.ToListAsync();

      var pets = from m in _context.Pets select m;
      pets = pets.OrderByDescending(s => s.petId);

      if ( filter > 0 ) {
        pets = pets.Where(p => p.animalid == filter);
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

    // GET: Pet/Details/5
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

    // GET: Pet/Create
    public async Task<IActionResult> Create()
    {
      var ufs = await _context.Ufs.ToListAsync();
      ViewBag.ufs = ufs;

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
    public async Task<IActionResult> Create([Bind("petId,species,breed,description,image, uf")] Pet pet)
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
      return View(pet);
    }

    // POST: Pet/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to, for 
    // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("petId,species,breed,description,image,created")] Pet pet)
    {
      if (id != pet.petId)
      {
        return NotFound();
      }

      if (ModelState.IsValid)
      {
        try
        {
          //recuperar createdDate do Pet
          // Pet oldPet = await _context.Pets.FirstOrDefaultAsync(p => p.petId == id);
          // pet.created = oldPet.created;

          //Adicionar Usuário Doador
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

    public ActionResult GetCitys(string uf)
    {
        var json = Json( City.getCitys(uf) );

        return json;
    }
  }

}
