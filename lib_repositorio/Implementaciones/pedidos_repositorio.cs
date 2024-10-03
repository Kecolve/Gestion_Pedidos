using lib_entidades;
using lib_repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lib_repositorio.Implementaciones.pedidos_repositorio;

namespace lib_repositorio.Implementaciones
{
        public class pedidos_repositorio : ipedidos_repositorio
    {
            private Conexion? conexion = null;

            public pedidos_repositorio(Conexion conexion)
            {
                this.conexion = conexion;
            }

            public List<Pedidos> Listar()
            {
                return conexion!.Listar<Pedidos>();
            }

            public Pedidos Guardar(Pedidos entidad)
            {
                conexion!.Guardar(entidad);
                conexion!.GuardarCambios();
                return entidad;
            }

            public Pedidos Modificar(Pedidos entidad)
            {
                conexion!.Modificar(entidad);
                conexion!.GuardarCambios();
                return entidad;
            }

            public Pedidos Borrar(Pedidos entidad)
            {
                conexion!.Borrar(entidad);
                conexion!.GuardarCambios();
                return entidad;
            }
        }

    }

