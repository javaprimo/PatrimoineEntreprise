namespace DatabaseAccess.Models
{
    public class Employe
    {
        public int Matricule { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Poste { get; set; }
        public int Niveau { get; set; }

        public override string ToString()
        {
            if (Matricule == 0)
                return string.Empty;

            return $"[{Matricule}] {Prenom} {Nom?.ToUpper()}";
        }
    }
}
