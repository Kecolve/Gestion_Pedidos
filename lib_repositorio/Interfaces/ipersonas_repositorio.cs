using lib_entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorio.Interfaces
{
    public interface ipersonas_repositorio
    {
            List<Personas> Listar();
            Personas Guardar(Personas entidad);
            Personas Modificar(Personas entidad);
            Personas Borrar(Personas entidad);
        

    }
}
