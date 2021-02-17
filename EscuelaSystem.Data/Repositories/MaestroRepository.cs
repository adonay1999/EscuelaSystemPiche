using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EscuelaSystem.Data.Interfaces;
using EscuelaSystem.Models;

namespace EscuelaSystem.Data.Repositories
{
    public class MaestroRepository : Repository<Maestro>, IMaestroRepository
    {
        private readonly ApplicationDbContext _db;
        public MaestroRepository(ApplicationDbContext db) : base(db)
        {

        }

        public void HActivo()
        {
            var Activo = _db.Maestros.Where(c => c.Activo == true).ToList();
            _db.RemoveRange(Activo);
            _db.SaveChanges();
        }
    }
}