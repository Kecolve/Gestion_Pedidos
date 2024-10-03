using lib_entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorio.Interfaces
{
    public interface ipedidos_repositorio
    {
        List<Pedidos> Listar();
        Pedidos Guardar(Pedidos entidad);
        Pedidos Modificar(Pedidos entidad);
        Pedidos Borrar(Pedidos entidad);


    }
}
