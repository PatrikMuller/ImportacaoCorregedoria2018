﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModuloPrincipal.InfraCorregedoria2018.LinqCorregedoria2018
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Corregedoria2018Entities : DbContext
    {
        public Corregedoria2018Entities()
            : base("name=Corregedoria2018Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Certidao> Certidao { get; set; }
        public virtual DbSet<Corregedor> Corregedor { get; set; }
        public virtual DbSet<Endereco> Endereco { get; set; }
        public virtual DbSet<Municipio> Municipio { get; set; }
        public virtual DbSet<Pena> Pena { get; set; }
        public virtual DbSet<Pessoa> Pessoa { get; set; }
        public virtual DbSet<Processo> Processo { get; set; }
        public virtual DbSet<ProcessoSindicado> ProcessoSindicado { get; set; }
        public virtual DbSet<ProcessoTestemunha> ProcessoTestemunha { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tipoDocumento> tipoDocumento { get; set; }
        public virtual DbSet<tipoProcesso> tipoProcesso { get; set; }
        public virtual DbSet<ProcessoEncerramento> ProcessoEncerramento { get; set; }
    }
}