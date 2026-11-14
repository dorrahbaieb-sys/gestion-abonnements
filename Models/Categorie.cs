using System;
using System.Collections.Generic;
using System.Text;

namespace gestion_abonnements.Models
{
    public class Categorie
    {
        public int Id { get; set; }
        public string Nom { get; set; } = string.Empty;

        public ICollection<Abonnement> Abonnements { get; set; } = new List<Abonnement>();
    }
}
