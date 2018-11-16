using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst
{
    public partial class Cours
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string NumeroSalle { get; set; }
        public int EtudiantId { get; set; }

        public virtual Etudiant Etudiant { get; set; }
    }
}
