﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst
{
    public partial class Etudiant : Personne
    {
        [ForeignKey("Cours")]
        public int CoursID { get; set; }

        public virtual ICollection<Cours> Cours { get; set; }
    }
}
