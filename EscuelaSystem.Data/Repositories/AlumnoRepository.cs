﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EscuelaSystem.Data.Interfaces;
using EscuelaSystem.Models;

namespace EscuelaSystem.Data.Repositories
{
    public class AlumnoRepository : Repository<Alumno>, IAlumnoRepository
    {
        private readonly ApplicationDbContext _db;
        public AlumnoRepository(ApplicationDbContext db) : base(db)
        {

        }

        public void HInscrito()
        {
            var Inscrito = _db.Alumnos.Where(c => c.Inscrito == true).ToList();
            _db.RemoveRange(Inscrito);
            _db.SaveChanges();
        }
    }
}