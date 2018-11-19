using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst
{
    class FormationContext : DbContext
    {
        public FormationContext() : base("name=FormationConnectionString")
        {
        }

        public virtual DbSet<Cours> Cours { get; set; }
        public virtual DbSet<Etudiant> Etudiants { get; set; }
        public virtual DbSet<Professeur> Professeurs { get; set; }
        public virtual DbSet<Module> Modules { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Professeur>()
                .HasRequired(p => p.Module)
                .WithRequiredDependent(p => p.Professeur)
                .WillCascadeOnDelete(false);
        }
    }
}
