using System;

namespace DatabaseAccess.Models
{
    public class DemandeAffectation
    {
        public int IdDemande { get; set; }
        public DateTime DateDemande { get; set; }
        public string NomPatrimoine { get; set; }
        public string NomPrenomEmploye { get; set; }

        public int IdPatrimoine { get; set; }
        public int MatriculeEmploye { get; set; }
    }
}
