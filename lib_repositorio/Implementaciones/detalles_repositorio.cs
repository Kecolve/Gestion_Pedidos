using lib_entidades;
using lib_repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lib_repositorio.Implementaciones.detalles_repositorio;

namespace lib_repositorio.Implementaciones
{
    public class detalles_repositorio : idetalles_repositorio
    {
        private Conexion? conexion = null;

        public detalles_repositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public List<Detalles> Listar()
        {
            return conexion!.Listar<Detalles>();
        }

        public Detalles Guardar(Detalles entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Detalles Modificar(Detalles entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Detalles Borrar(Detalles entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }
    }

}

