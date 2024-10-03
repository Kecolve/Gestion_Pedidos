using lib_entidades;
using lib_repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lib_repositorio.Implementaciones.estados_repositorio;

namespace lib_repositorio.Implementaciones
{
        public class estados_repositorio : iestados_repositorio
    {
            private Conexion? conexion = null;

            public estados_repositorio(Conexion conexion)
            {
                this.conexion = conexion;
            }

            public List<Estados> Listar()
            {
                return conexion!.Listar<Estados>();
            }

            public Estados Guardar(Estados entidad)
            {
                conexion!.Guardar(entidad);
                conexion!.GuardarCambios();
                return entidad;
            }

            public Estados Modificar(Estados entidad)
            {
                conexion!.Modificar(entidad);
                conexion!.GuardarCambios();
                return entidad;
            }

            public Estados Borrar(Estados entidad)
            {
                conexion!.Borrar(entidad);
                conexion!.GuardarCambios();
                return entidad;
            }
        }

    }

