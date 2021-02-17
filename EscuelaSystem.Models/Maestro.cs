using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace EscuelaSystem.Models
{
    public class Maestro : EntityBase
    {
        public int hidden;

        [Required(ErrorMessage = "El campo Carnet del Docente no puede estar vacio")]
        [MinLength(2, ErrorMessage = "El campo Carnet del Docente debe tener minimo 2 caracteres")]
        [MaxLength(10, ErrorMessage = "El campo Carnet del Docente debe tener maximo 10 caracteres")]
        [Display(Name = "Carnet del Docente")]
        public string Carnet { get; set; }
        [Required(ErrorMessage = "El campo Nombre del Docente no puede estar vacio")]
        [MinLength(3, ErrorMessage = "El campo Nombre del Docente debe tener minimo 3 caracteres")]
        [MaxLength(25, ErrorMessage = "El campo Nombre del Docente debe tener maximo 25 caracteres")]
        [Display(Name = "Nombre del Docente")]
        public string Docente { get; set; }
        public bool Activo { get; set; }

    }
}
