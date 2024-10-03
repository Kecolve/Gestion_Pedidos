using lib_entidades;
using lib_repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lib_repositorio.Implementaciones.transportistas_repositorio;

namespace lib_repositorio.Implementaciones
{
        public class transportistas_repositorio : itransportistas_repositorio
    {
            private Conexion? conexion = null;

            public transportistas_repositorio(Conexion conexion)
            {
                this.conexion = conexion;
            }

            public List<Transportistas> Listar()
            {
                return conexion!.Listar<Transportistas>();
            }

            public Transportistas Guardar(Transportistas entidad)
            {
                conexion!.Guardar(entidad);
                conexion!.GuardarCambios();
                return entidad;
            }

            public Transportistas Modificar(Transportistas entidad)
            {
                conexion!.Modificar(entidad);
                conexion!.GuardarCambios();
                return entidad;
            }

            public Transportistas Borrar(Transportistas entidad)
            {
                conexion!.Borrar(entidad);
                conexion!.GuardarCambios();
                return entidad;
            }
        }

    }

