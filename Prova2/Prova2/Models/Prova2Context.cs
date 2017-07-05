using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Prova2.Models
{
    public class Prova2Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Prova2Context() : base("name=Prova2Context")
        {
            // apaga e cria semrpre
            Database.SetInitializer<Prova2Context>(new DropCreateDatabaseAlways<Prova2Context>());
            
            // apaga e cria se mudar as modelos
            //Database.SetInitializer<Prova2Context>(new DropCreateDatabaseIfModelChanges<Prova2Context>());
            
            // apaga e cria se nao existir base ainda 
            //Database.SetInitializer<Prova2Context>(new CreateDatabaseIfNotExists<Prova2Context>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
        public System.Data.Entity.DbSet<Modelos.Departamento> Departamentoes { get; set; }

        public System.Data.Entity.DbSet<Modelos.Cargo> Cargoes { get; set; }

        public System.Data.Entity.DbSet<Modelos.Funcionario> Funcionarios { get; set; }

        public System.Data.Entity.DbSet<Modelos.Escala> Escalas { get; set; }

        public System.Data.Entity.DbSet<Modelos.Ausencia> Ausencias { get; set; }

        public System.Data.Entity.DbSet<Modelos.HoraExtra> HoraExtras { get; set; }

        public System.Data.Entity.DbSet<Modelos.Usuario> Usuarios { get; set; }
    }
}
