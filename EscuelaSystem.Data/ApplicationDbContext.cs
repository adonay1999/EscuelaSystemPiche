﻿//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace EscuelaSystem.Data
//{
//    class ApplicationDbContext
//    {
//    }
//}

using System;
using System.Collections.Generic;
using System.Text;
using EscuelaSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace EscuelaSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Materia> Materias { get; set; }

        public DbSet<Alumno> Alumnos { get; set; }

        public DbSet<Maestro> Maestros { get; set; }
    }
}

