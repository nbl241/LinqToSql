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
                    Id = id,
                    Nom = nom,
                    DateNaissance = dateDeNaissance,
                    Adresse = adresse
                };
                dbContext.Etudiants.Add(etudiant);
                dbContext.SaveChanges();
            }
        }
    }
}
