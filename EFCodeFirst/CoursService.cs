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
            using (var dbContext = new FormationContext())
            {
                Cours cours = new Cours();
                {
                    cours.Id = 1;
                    cours.Nom = "Entity Framework";
                };
                dbContext.Cours.Add(cours);
                dbContext.SaveChanges();
            }
        }
    }
}
