using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcPet.Models;
using MvcPet.Data;

using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace MvcPet.Controllers
{
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;
    private readonly MvcPetContext _context;
    private readonly SignInManager<IdentityUser> _signInManager;
    private readonly UserManager<IdentityUser> _userManager;

    public HomeController(
        ILogger<HomeController> logger,
        MvcPetContext context,
        UserManager<IdentityUser> userManager,
        SignInManager<IdentityUser> signInManager)
    {
      _logger = logger;
      _context = context;
      _signInManager = signInManager;
      _userManager = userManager;
    }

    public async Task<IActionResult> Index()
    {
      if (_signInManager.IsSignedIn(User))
      {
        var users = from m in _context.Users select m;

        // users = users.Where( u => u.userId.Equals( _userManager.GetUserId(User) ) );

        // return View(await users.ToListAsync() );
        var user = await _context.Users.FirstOrDefaultAsync(m => m.userId == _userManager.GetUserId(User));
        UserPetViewModel vm = new UserPetViewModel();
        vm.User = user;
        // return View(user);
        return View(vm);
      }
      else
      {
        return View();
      }
    }

    public IActionResult About()
    {
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult Error404()
    {
      return View();
    }

  }
}
