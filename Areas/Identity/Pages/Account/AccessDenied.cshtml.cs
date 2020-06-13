using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MvcPet.Areas.Identity.Pages.Account
{
  public class AccessDeniedModel : PageModel
  {
    public IActionResult OnGet()
    {
			return RedirectToAction("Error404", "Home");
    }
  }
}

