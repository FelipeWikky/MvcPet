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
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity.UI.Services;
using System.Web;
using System.Net;
using System.IO;
using System.Text;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;

namespace MvcPet.Controllers
{
  [Authorize(Roles="Admin, User")]
  public class UserController : Controller
  {
    public readonly MvcPetContext _context;
    public readonly RoleManager<IdentityRole> _roleManager;
    public readonly UserManager<IdentityUser> _userManager;
    public UserController(
      RoleManager<IdentityRole> roleManager,
      UserManager<IdentityUser> userManager,
      MvcPetContext context)
    {
      _context = context;
      _userManager = userManager;
      _roleManager = roleManager;
    }

    [HttpGet]
    public async Task<IActionResult> Details(string id)
    {
      User user = await _context.Users.FirstOrDefaultAsync(u => u.userId == id);

      return View(user);
    }

    [Authorize(Roles="Admin")]
    public async Task<IActionResult> Users()
    {
      UserPetViewModel viewModel = new UserPetViewModel();
      viewModel.Users = await _context.Users.ToListAsync();

      return View(viewModel);
    }
  }
}