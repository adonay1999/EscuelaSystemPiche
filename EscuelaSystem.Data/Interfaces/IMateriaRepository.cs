//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace EscuelaSystem.Data.Interfaces
//{
//    class IMateriaRepository
//    {
//    }
//}

using System;
using System.Collections.Generic;
using System.Text;
using EscuelaSystem.Models;
using EscuelaSystemData.Interfaces;

namespace EscuelaSystem.Data.Interfaces
{
    public interface IMateriaRepository : IRepository<Materia>   
    {
        void DeleteHabilitada();
     
    }
}
