﻿using lib_entidades;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using static System.Reflection.Metadata.BlobBuilder;
using System.Linq.Expressions;

namespace lib_repositorio
{

    public class Conexion : DbContext
    {
        public string? StringConnection { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this.StringConnection!, p => { });
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }
        protected DbSet<Personas>? Personas { get; set; }
        protected DbSet<Detalles>? Detalles { get; set; }
        protected DbSet<Estados>? Estados { get; set; }
        protected DbSet<Paquetes>? Paquetes { get; set; }
        protected DbSet<Pedidos>? Pedidos { get; set; }
        protected DbSet<Transportistas>? Transportistas { get; set; }

        public virtual DbSet<T> ObtenerSet<T>() where T : class, new()
        {
            return this.Set<T>();
        }
        public virtual List<T> Listar<T>() where T : class, new()
        {
            return this.Set<T>().ToList();
        }
        public virtual List<T> Buscar<T>(Expression<Func<T, bool>> condiciones) where T : class, new()
        {
            return this.Set<T>().Where(condiciones).ToList();
        }
        public virtual bool Existe<T>(Expression<Func<T, bool>> condiciones) where T : class, new()
        {
            return this.Set<T>().Any(condiciones);
        }
        public virtual void Guardar<T>(T entidad) where T : class, new()
        {
            this.Set<T>().Add(entidad);
        }
        public virtual void Modificar<T>(T entidad) where T : class
        {
            var entry = this.Entry(entidad);
            entry.State = EntityState.Modified;
        }
        public virtual void Borrar<T>(T entidad) where T : class, new()
        {
            this.Set<T>().Remove(entidad);
        }
        public virtual void Separadar<T>(T entidad) where T : class, new()
        {
            this.Entry(entidad).State = EntityState.Detached;
        }
        public virtual void GuardarCambios()
        {
            this.SaveChanges();
        }
    }
}