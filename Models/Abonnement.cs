using System;
using System.Collections.Generic;
using System.Text;

namespace gestion_abonnements.Models
{
    public class Abonnement
    {
        public int Id { get; set; }
        public string NomService { get; set; } = string.Empty;
        public decimal Montant { get; set; }
        public string Periodicite { get; set; } = "Mensuel";
        public DateTime DateDebut { get; set; } = DateTime.Now;
        public DateTime DateProchainRenouvellement { get; set; }
        public string Statut { get; set; } = "Actif";

        public int CategorieId { get; set; }
        public Categorie? Categorie { get; set; }

        public ICollection<Paiement> Paiements { get; set; } = new List<Paiement>();
    }
}