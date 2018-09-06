using Intranet.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Intranet.AcessoDados
{
    public class PremioContexto : DbContext

    {
        public DbSet<Premio> Premios { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Departamento> Departamentos{ get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Properties<string>().Configure(c => c.HasMaxLength(100));
           
        }

    }
}
