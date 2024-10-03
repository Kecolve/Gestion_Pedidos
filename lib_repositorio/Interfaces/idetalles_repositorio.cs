using lib_entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorio.Interfaces
{
    public interface idetalles_repositorio
    {
        List<Detalles> Listar();
        Detalles Guardar(Detalles entidad);
        Detalles Modificar(Detalles entidad);
        Detalles Borrar(Detalles entidad);
    }
}
