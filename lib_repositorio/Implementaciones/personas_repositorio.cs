using lib_entidades;
using lib_repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lib_repositorio.Implementaciones.personas_repositorio;

namespace lib_repositorio.Implementaciones
{
        public class personas_repositorio : ipersonas_repositorio
    {
            private Conexion? conexion = null;

            public personas_repositorio(Conexion conexion)
            {
                this.conexion = conexion;
            }

            public List<Personas> Listar()
            {
                return conexion!.Listar<Personas>();
            }

            public Personas Guardar(Personas entidad)
            {
                conexion!.Guardar(entidad);
                conexion!.GuardarCambios();
                return entidad;
            }

            public Personas Modificar(Personas entidad)
            {
                conexion!.Modificar(entidad);
                conexion!.GuardarCambios();
                return entidad;
            }

            public Personas Borrar(Personas entidad)
            {
                conexion!.Borrar(entidad);
                conexion!.GuardarCambios();
                return entidad;
            }
        }

    }

