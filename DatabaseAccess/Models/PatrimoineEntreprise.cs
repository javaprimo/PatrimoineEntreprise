using System;

namespace DatabaseAccess.Models
{
    public class PatrimoineEntreprise
    {
        public int IdPatrimoine { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public decimal Prix { get; set; }
        public int DureeAmortissement { get; set; }
        public decimal? TauxAmortissement { get; set; }
        public decimal PrixApresAmortissement { get; set; }
        public int Anciennete { get; set; }
        public string Status { get; set; }
        public DateTime DateAchat { get; set; }
        public string Categorie { get; set; }
        public string Employe { get; set; }

        public override string ToString()
        {
            if (IdPatrimoine == 0)
                return string.Empty;

            return $"[{IdPatrimoine}] {Nom.Substring(0, Nom.Length > 17 ? 17 : Nom.Length)}";
        }

    }
}
