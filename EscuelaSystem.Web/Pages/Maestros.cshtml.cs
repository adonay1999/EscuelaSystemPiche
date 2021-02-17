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
    public class MaestrosModel : PageModel
    {
        private readonly IMaestroRepository _maestroRepository;

        public MaestrosModel(IMaestroRepository MaestroRepository)
        {
            _maestroRepository = MaestroRepository;
        }

        [BindProperty]
        public IEnumerable<Maestro> Maestros { get; set; }

        public IActionResult OnGet()
        {
            Maestros = _maestroRepository.List();
            return Page();
        }
    }
}
