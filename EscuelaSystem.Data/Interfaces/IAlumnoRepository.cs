using System;
using System.Collections.Generic;
using System.Text;
using EscuelaSystem.Models;
using EscuelaSystemData.Interfaces;

namespace EscuelaSystem.Data.Interfaces
{
    public interface IAlumnoRepository : IRepository<Alumno>
    {
        void DeleteHabilitada();

    }
}
