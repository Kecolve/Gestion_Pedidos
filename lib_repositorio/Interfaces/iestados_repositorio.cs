using lib_entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorio.Interfaces
{
    public interface iestados_repositorio
    {

        List<Estados> Listar();
        Estados Guardar(Estados entidad);
        Estados Modificar(Estados entidad);
        Estados Borrar(Estados entidad);



    }
}
