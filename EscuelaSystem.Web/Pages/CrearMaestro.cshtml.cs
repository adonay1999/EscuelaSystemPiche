using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EscuelaSystem.Data.Interfaces;
using EscuelaSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EscuelaSystem.Web.Pages
{
    public class CrearMaestroModel : PageModel
    {
        private readonly IMaestroRepository _maestroRepository;

        public CrearMaestroModel(IMaestroRepository MaestroRepository)
        {
            _maestroRepository = MaestroRepository;
        }

        [BindProperty]
        public Maestro Maestro { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _maestroRepository.Insert(Maestro);

            return RedirectToPage("./Maestros");
        }
    }
}
