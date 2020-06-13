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

using Microsoft.AspNetCore.Mvc.Rendering;

using System.Web;
using System.Net;
using System.IO;
using System.Text;
using System.Runtime.Serialization.Json;

using Newtonsoft.Json;

namespace MvcPet.Controllers
{
  
  [Authorize(Roles = "Admin")]
  public class AnimalController : Controller
  {
    private readonly MvcPetContext _context;
    private readonly SignInManager<IdentityUser> _signInManager;
    private readonly UserManager<IdentityUser> _userManager;

    public AnimalController(
      MvcPetContext context,
      UserManager<IdentityUser> userManager,
      SignInManager<IdentityUser> signInManager
    )
    {
      _context = context;
      _signInManager = signInManager;
      _userManager = userManager;
    }

    [HttpGet]
    public async Task<IActionResult> Index(){
      return View( await _context.Animals.ToListAsync() );
    }

  }
}