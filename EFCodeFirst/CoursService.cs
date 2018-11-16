using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst
{
    public class CoursService
    {
        public void AddCours()
        {
            //Cours cours = new Cours();
            //cours.Id = 1;
            //cours.Nom = "Entity Framework";
        }

        public void AddEtudiant()
        {
            using (var dbContext = new FormationContext())
            {
                Etudiant etudiant = new Etudiant
                {
                    Id = 1,
                    Nom = "nabil",
                    DateNaissance = new DateTime(1986, 11, 24),
                    Adresse = "59 rue Gambetta 76250"
                };

            }
        }
    }
}
