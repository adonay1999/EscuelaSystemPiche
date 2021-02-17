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
    public class EliminarAlumnoModel : PageModel
    {
        private readonly IAlumnoRepository _alumnoRepository;

        public EliminarAlumnoModel(IAlumnoRepository AlumnoRepository)
        {
            _alumnoRepository = AlumnoRepository;
        }

        [BindProperty]
        public Alumno Alumno { get; set; }
        public IActionResult OnGet(int id)
        {
            Alumno = _alumnoRepository.GetbyId(id);
            if (Alumno == null)
            {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPost(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var AlumnoToUpdate = _alumnoRepository.GetbyId(id);
            if (AlumnoToUpdate == null)
                return NotFound();

            AlumnoToUpdate.CodigoA = Alumno.CodigoA;
            AlumnoToUpdate.Nombre = Alumno.Nombre;
            AlumnoToUpdate.Inscrito = Alumno.Inscrito;

            _alumnoRepository.Delete(AlumnoToUpdate);

            return RedirectToPage("./Alumnos");
        }
    }
}


