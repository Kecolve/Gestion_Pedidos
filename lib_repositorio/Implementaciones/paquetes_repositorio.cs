using lib_entidades;
using lib_repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lib_repositorio.Implementaciones.paquetes_repositorio;

namespace lib_repositorio.Implementaciones
{
        public class paquetes_repositorio : ipaquetes_repositorio
    {
            private Conexion? conexion = null;

            public paquetes_repositorio(Conexion conexion)
            {
                this.conexion = conexion;
            }

            public List<Paquetes> Listar()
            {
                return conexion!.Listar<Paquetes>();
            }

            public Paquetes Guardar(Paquetes entidad)
            {
                conexion!.Guardar(entidad);
                conexion!.GuardarCambios();
                return entidad;
            }

            public Paquetes Modificar(Paquetes entidad)
            {
                conexion!.Modificar(entidad);
                conexion!.GuardarCambios();
                return entidad;
            }

            public Paquetes Borrar(Paquetes entidad)
            {
                conexion!.Borrar(entidad);
                conexion!.GuardarCambios();
                return entidad;
            }
        }

    }

