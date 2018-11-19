using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst
{
    public partial class Professeur : Personne
    {
        public int ModuleID { get; set; }

        public virtual Module Module { get; set; }
    }
}
