﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Programa.Entidades
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EDWEntities : DbContext
    {
        public EDWEntities()
            : base("name=EDWEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Can> Can { get; set; }
        public virtual DbSet<Dueño> Dueño { get; set; }
        public virtual DbSet<Paseador> Paseador { get; set; }
        public virtual DbSet<Solicitud> Solicitud { get; set; }
    }
}
