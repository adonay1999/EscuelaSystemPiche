﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace EscuelaSystem.Models
{
    public class Alumno : EntityBase
    {
        public int hidden;

        [Required(ErrorMessage = "El campo Codigo del Alumno no puede estar vacio")]
        [MinLength(2, ErrorMessage = "El campo Codigo del Alumno debe tener minimo 2 caracteres")]
        [MaxLength(10, ErrorMessage = "El campo Codigo del Alumno debe tener maximo 10 caracteres")]
        [Display(Name = "Codigo de alumno")]
        public string CodigoA { get; set; }
        [Required(ErrorMessage = "El campo Nombre del Alumno no puede estar vacio")]
        [MinLength(3, ErrorMessage = "El campo Nombre del Alumno debe tener minimo 3 caracteres")]
        [MaxLength(25, ErrorMessage = "El campo Nombre del Alumno debe tener maximo 25 caracteres")]
        [Display(Name = "Nombre del Alumno")]
        public string Nombre { get; set; }
        public bool Inscrito { get; set; }

    }
}
