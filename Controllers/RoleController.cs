using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MvcPet.Models;
using MvcPet.ViewModels;
using MvcPet.Data;
using MvcPet.Areas.Identity.Data;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.AspNetCore.Authorization;

namespace MvcPet.Controllers
{
  [Authorize(Roles = "Admin")]
  public class RoleController : Controller
  {

    public readonly MvcPetContext _context;
    public readonly RoleManager<IdentityRole> _roleManager;
    public readonly UserManager<IdentityUser> _userManager;

    public RoleController(
      RoleManager<IdentityRole> roleManager,
      UserManager<IdentityUser> userManager,
      MvcPetContext context)
    {
      _roleManager = roleManager;
      _userManager = userManager;
      _context = context;
    }

    [HttpGet]
    public IActionResult Index()
    {
      var roles = _roleManager.Roles;

      return View(roles);
    }

    [HttpGet]
    public IActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(RoleViewModel model)
    {
      if (ModelState.IsValid)
      {
        IdentityRole identityRole = new IdentityRole
        {
          Name = model.roleName
        };

        IdentityResult result = await _roleManager.CreateAsync(identityRole);

        if (result.Succeeded)
        {
          return RedirectToAction("Index");
        }

        foreach (IdentityError error in result.Errors)
        {
          ModelState.AddModelError("", error.Description);
        }
      }
      return View(model);
    }

    [HttpGet]
    public async Task<IActionResult> Edit(string id)
    {
      var role = await _roleManager.FindByIdAsync(id);

      if (role == null)
      {
        ViewBag.ErrorMessage = "Perfil não encontrado";
        return View("NotFound");
      }

      var model = new RoleViewModel
      {
        id = role.Id,
        roleName = role.Name
      };

      foreach (var user in _userManager.Users)
      {
        if ( await _userManager.IsInRoleAsync(user, role.Name) ) {
          
        }
      }



      return View();
    }

    [HttpGet]
    public async Task<IActionResult> Users(string id){
      var role = await _roleManager.FindByIdAsync(id);
      RoleViewModel roleViewModel = new RoleViewModel();

      if (role == null)
      {
        ViewBag.ErrorMessage = "Role não encontrada";
        //return View("NotFound");
      }

      roleViewModel.roleName = role.Name;
      ViewBag.Role = role.Name;

      foreach (var user in _userManager.Users)
      {
        if ( await _userManager.IsInRoleAsync(user, role.Name) ) {
          User u = await _context.Users.FirstOrDefaultAsync(find => find.userId == user.Id);
          roleViewModel.Users.Add(u);
        }
      }

      return View(roleViewModel);
    }

    [HttpPost]
    public async Task<IActionResult> UserAdd(string role, string email){
      IdentityUser user = await _userManager.FindByEmailAsync(email);
      if (user == null) {
        ViewBag.ErrorMessage = "User Not Found";
        return RedirectToAction("NotFound", "Home");
      }

      await _userManager.AddToRoleAsync(user, role);

      return RedirectToAction("Index", "Role");
    }

    [HttpPost]
    public async Task<IActionResult> UserRemove(string role, string email){
      IdentityUser user = await _userManager.FindByEmailAsync(email);
      if (user == null) {
        ViewBag.ErrorMessage = "User Not Found";
        return RedirectToAction("NotFound", "Home");  
      }

      Message message = new Message(1, "Usuário removido da Role");

      await _userManager.RemoveFromRoleAsync(user, role);

      return RedirectToAction("Index", "Role");
    }
  }
}