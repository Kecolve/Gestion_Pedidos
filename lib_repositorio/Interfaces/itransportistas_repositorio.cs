using lib_entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorio.Interfaces
{
    public interface itransportistas_repositorio
    {
        List<Transportistas> Listar();
        Transportistas Guardar(Transportistas entidad);
        Transportistas Modificar(Transportistas entidad);
        Transportistas Borrar(Transportistas entidad);


    }
}
