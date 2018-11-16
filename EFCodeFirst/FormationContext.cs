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
    }
}
