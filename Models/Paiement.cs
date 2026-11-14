using System;
using System.Collections.Generic;
using System.Text;

namespace gestion_abonnements.Models
{
    public class Paiement
    {
        public int Id { get; set; }
        public DateTime DatePaiement { get; set; } = DateTime.Now;
        public decimal MontantPaye { get; set; }
        public bool EstPaye { get; set; }

        public int AbonnementId { get; set; }
        public Abonnement? Abonnement { get; set; }
    }
}