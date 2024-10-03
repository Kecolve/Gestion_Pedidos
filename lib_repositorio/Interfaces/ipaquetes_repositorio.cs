using lib_entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorio.Interfaces
{
    public interface ipaquetes_repositorio
    {

        List<Paquetes> Listar();
        Paquetes Guardar(Paquetes entidad);
        Paquetes Modificar(Paquetes entidad);
        Paquetes Borrar(Paquetes entidad);


    }
}
