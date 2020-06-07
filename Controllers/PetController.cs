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
    public async Task<IActionResult> Index()
    {
			var pets = from m in _context.Pets select m;
			pets = pets.OrderByDescending(s => s.petId);
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

      return View(pet);
    }

    // GET: Pet/Create
    public IActionResult Create()
    {
      return View();
    }

    // POST: Pet/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to, for 
    // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("petId,species,breed,description,image,created")] Pet pet)
    {
      if (ModelState.IsValid)
      {
        // User user = new User();
        // user.userId = _userManager.GetUserId(User);

        User user = await _context.Users
          .FirstOrDefaultAsync(u => u.userId == _userManager.GetUserId(User));

        pet.donor = user;

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
        return RedirectToAction(nameof(Index));
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
      return RedirectToAction(nameof(Index));
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

  }

}
