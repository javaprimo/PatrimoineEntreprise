using DatabaseAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace DatabaseAccess.Repositories
{
    public class EmployeRepository : RepositoryBase
    {
        private const string sqlStrListeEmploye = @"select * from Employe where 1 = 1";
        private const string sqlStrFiltrerNomEmploye = @"(nom like '%' + @Nom + '%')";
        private const string sqlStrFiltrerPrenomEmploye = @" and (prenom like '%' + @Prenom + '%')";
        private const string sqlStrFiltrerEmployeWithIdPoste = @"(idPoste = @IdPoste)";
        private const string sqlStrFiltrerEmployByMatricule = @"(matricule = @Matricule)";
        private const string sqlStrEmployeByCompteId = @"(userName = @userName)";

        public static List<Employe> GetFiltereEmployeListe(string nom, string prenom, int idPoste)
        {
            try
            {
                using (var connexion = PatrimoineEntrpriseDBContext.GetDBConnection())
                {
                    var sqlstring = sqlStrListeEmploye;
                    if (!string.IsNullOrWhiteSpace(nom))
                        sqlstring = $"{sqlstring} and {sqlStrFiltrerNomEmploye}";
                    if (!string.IsNullOrWhiteSpace(prenom))
                        sqlstring = $"{sqlstring} and {sqlStrFiltrerPrenomEmploye}";
                    if (idPoste > 0)
                        sqlstring = $"{sqlstring} and {sqlStrFiltrerEmployeWithIdPoste}";

                    var sqlCommand = new SqlCommand(sqlstring, connexion);
                    sqlCommand.Parameters.Add(GetParam("@Nom", nom));
                    sqlCommand.Parameters.Add(GetParam("@Prenom", prenom));
                    sqlCommand.Parameters.Add(GetParam("@IdPoste", idPoste));

                    return GetListeEmployesSqlCommand(sqlCommand);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Important Exception {ex.Message}", $"What happened?", MessageBoxButtons.YesNo);
            }

            return new List<Employe>();
        }

        public static List<Employe> GetEmployeListe()
        {
            try
            {
                using (var connexion = PatrimoineEntrpriseDBContext.GetDBConnection())
                {
                    var sqlQuery = new SqlCommand(sqlStrListeEmploye, connexion);
                    return GetListeEmployesSqlCommand(sqlQuery);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Important Exception {ex.Message}", $"What happened?", MessageBoxButtons.YesNo);
            }

            return new List<Employe>();
        }

        public static Employe GetEmployeByMatricule(int matricule)
        {
            try
            {
                using (var connexion = PatrimoineEntrpriseDBContext.GetDBConnection())
                {
                    var sqlstring = sqlStrListeEmploye;
                    if (matricule > 0)
                        sqlstring = $"{sqlstring} and {sqlStrFiltrerEmployByMatricule}";

                    var sqlQuery = new SqlCommand(sqlstring, connexion);
                    sqlQuery.Parameters.Add(GetParam("@Matricule", matricule));
                    var listeEmployes = GetListeEmployesSqlCommand(sqlQuery);
                    if (listeEmployes.Any())
                        return listeEmployes[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Important Exception {ex.Message}", $"What happened?", MessageBoxButtons.YesNo);
            }

            return new Employe();
        }

        public static Employe GetEmployeByCompteId(string userName)
        {
            try
            {
                using (var connexion = PatrimoineEntrpriseDBContext.GetDBConnection())
                {
                    var sqlstring = sqlStrListeEmploye;
                    if (!string.IsNullOrWhiteSpace(userName))
                        sqlstring = $"{sqlstring} and {sqlStrEmployeByCompteId}";

                    var sqlQuery = new SqlCommand(sqlstring, connexion);
                    sqlQuery.Parameters.Add(GetParam("@UserName", userName));
                    var listeEmployes = GetListeEmployesSqlCommand(sqlQuery);
                    if (listeEmployes.Any())
                        return listeEmployes[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Important Exception {ex.Message}", $"What happened?", MessageBoxButtons.YesNo);
            }

            return new Employe();
        }


        private static List<Employe> GetListeEmployesSqlCommand(SqlCommand sqlQuery)
        {
            var employesListe = new List<Employe>();
            sqlQuery.Connection.Open();
            using (var reader = sqlQuery.ExecuteReader())
            {
                while (reader.Read())
                {
                    var poste = PosteRepository.GetPosteById((int)reader["idPoste"]);
                    employesListe.Add(new Employe()
                    {
                        Matricule = Convert.ToInt32(reader["matricule"]),
                        Nom = (string)reader["Nom"],
                        Prenom = (string)reader["Prenom"],
                        Poste = poste.Libelle
                    });
                }
            }

            return employesListe;
        }
    }
}
