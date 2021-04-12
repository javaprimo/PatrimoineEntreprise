using DatabaseAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseAccess.Repositories
{
    public class DemandeAffectationRepository : RepositoryBase
    {
        private const string sqlStrListeDemandeAffectation = "select * from Demande where 1 = 1";
        private const string sqlStrFiltrerWithNomPatrimoineEntreprise = @"(idPatrimoine = @IdPatrimoine)";
        private const string sqlStrFiltrerWithNomMatriculeEmploye = @"(matricule = @MatriculeEmploye)";
        private const string sqlStrFiltrerWithDateDemandeAffectation = @"(dateDemande = @DateDemande)";
        private const string sqlStrDemandeAffectationById = "select * from demande where idDemande = @IdDemande";
        private const string sqlStrNewDemandeAffectation = @"insert into demande(idPatrimoine, matricule, dateDemande) " +
            "VALUES(@IdPatrimoine, @Matricule, @DateDemande)";
        private const string sqlStrUpdateDemandeAffectation = @"update demande set idPatrimoine = @IdPatrimoine, dateDemande = @DateDemande where idDemande = @IdDemande";

        public static List<DemandeAffectation> GetDemandeAffectationListe()
        {
            try
            {
                using (var connexion = PatrimoineEntrpriseDBContext.GetDBConnection())
                {
                    var sqlQuery = new SqlCommand(sqlStrListeDemandeAffectation, connexion);
                    return GetListeDemandeAffectationFromSqlCommand(sqlQuery);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Important Exception {ex.Message}", $"What happened?", MessageBoxButtons.YesNo);
                return new List<DemandeAffectation>();
            }
        }

        public static DemandeAffectation GetDemandeAffectationById(int idDemande)
        {
            try
            {
                using (var connexion = PatrimoineEntrpriseDBContext.GetDBConnection())
                {
                    var sqlQuery = new SqlCommand(sqlStrDemandeAffectationById, connexion);
                    sqlQuery.Parameters.Add(GetParam("@IdDemande", idDemande));
                    var listeDemandesAffectations = GetListeDemandeAffectationFromSqlCommand(sqlQuery);
                    if (listeDemandesAffectations.Any())
                        return listeDemandesAffectations[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Important Exception {ex.Message}", $"What happened?", MessageBoxButtons.YesNo);
            }

            return new DemandeAffectation();
        }

        public static List<DemandeAffectation> GetFiltereDemandeAffectationListe(int idPtrimoineEntrptise, int matriculeEmploye, DateTime dateDemande)
        {
            try
            {
                using (var connexion = PatrimoineEntrpriseDBContext.GetDBConnection())
                {
                    var sqlstring = sqlStrListeDemandeAffectation;
                    if (idPtrimoineEntrptise > 0)
                        sqlstring = $"{sqlstring} and {sqlStrFiltrerWithNomPatrimoineEntreprise}";
                    if (matriculeEmploye > 0)
                        sqlstring = $"{sqlstring} and {sqlStrFiltrerWithNomMatriculeEmploye}";

                    if (dateDemande > DateTime.MinValue)
                        sqlstring = $"{sqlstring} and {sqlStrFiltrerWithDateDemandeAffectation}";

                    var sqlCommand = new SqlCommand(sqlstring, connexion);
                    sqlCommand.Parameters.Add(GetParam("@IdPatrimoine", idPtrimoineEntrptise));
                    sqlCommand.Parameters.Add(GetParam("@MatriculeEmploye", matriculeEmploye));
                    sqlCommand.Parameters.Add(GetParam("@DateDemande", dateDemande));

                    return GetListeDemandeAffectationFromSqlCommand(sqlCommand);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Important Exception {ex.Message}", $"What happened?", MessageBoxButtons.YesNo);
            }

            return new List<DemandeAffectation>();
        }
        
        public static List<DemandeAffectation> GetFiltereDemandeAffectationListe(int matriculeEmploye)
        {
            try
            {
                using (var connexion = PatrimoineEntrpriseDBContext.GetDBConnection())
                {
                    var sqlstring = sqlStrListeDemandeAffectation;
                    if (matriculeEmploye > 0)
                        sqlstring = $"{sqlstring} and {sqlStrFiltrerWithNomMatriculeEmploye}";

                    var sqlCommand = new SqlCommand(sqlstring, connexion);
                    sqlCommand.Parameters.Add(GetParam("@MatriculeEmploye", matriculeEmploye));

                    return GetListeDemandeAffectationFromSqlCommand(sqlCommand);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Important Exception {ex.Message}", $"What happened?", MessageBoxButtons.YesNo);
            }

            return new List<DemandeAffectation>();
        }

        public static bool TryInsertNewDemandeAffectation(DemandeAffectation demandeAffectation)
        {
            try
            {
                using (var connexion = PatrimoineEntrpriseDBContext.GetDBConnection())
                {
                    var sqlCommand = new SqlCommand(sqlStrNewDemandeAffectation, connexion);
                    sqlCommand.Parameters.Add(GetParam("@IdPatrimoine", demandeAffectation.IdPatrimoine));
                    sqlCommand.Parameters.Add(GetParam("@Matricule", demandeAffectation.MatriculeEmploye));
                    sqlCommand.Parameters.Add(GetParam("@DateDemande", demandeAffectation.DateDemande));

                    sqlCommand.Connection.Open();

                    return sqlCommand.ExecuteNonQuery() == 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Important Exception {ex.Message}", $"What happened?", MessageBoxButtons.YesNo);
            }

            return false;
        }

        public static bool TryUpdateDemandeAffectation(int idDemande, int idPatrimoine, DateTime dateDemandeAffectationSohaitee)
        {
            try
            {
                using (var connexion = PatrimoineEntrpriseDBContext.GetDBConnection())
                {

                    if (idPatrimoine <= 0)
                        return false;

                    var sqlCommand = new SqlCommand(sqlStrUpdateDemandeAffectation, connexion);
                    sqlCommand.Parameters.Add(GetParam("@IdDemande", idDemande));
                    sqlCommand.Parameters.Add(GetParam("@IdPatrimoine", idPatrimoine));
                    sqlCommand.Parameters.Add(GetParam("@DateDemande", dateDemandeAffectationSohaitee));

                    sqlCommand.Connection.Open();

                    return sqlCommand.ExecuteNonQuery() == 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Important Exception {ex.Message}", $"What happened?", MessageBoxButtons.YesNo);
            }

            return false;
        }

        private static List<DemandeAffectation> GetListeDemandeAffectationFromSqlCommand(SqlCommand sqlCommand)
        {
            var demandeAffectationListe = new List<DemandeAffectation>();
            sqlCommand.Connection.Open();
            using (var reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    var patrimoine = new PatrimoineEntreprise();
                    if (reader["idPatrimoine"] != DBNull.Value)
                        patrimoine = PatrimoineEntrpriseRepository.GetPatrimoineEntrpriseById((int)reader["idPatrimoine"]);

                    var employe = new Employe();
                    if (reader["matricule"] != DBNull.Value)
                        employe = EmployeRepository.GetEmployeByMatricule((int)reader["matricule"]);

                    demandeAffectationListe.Add(new DemandeAffectation()
                    {
                        IdDemande = Convert.ToInt32(reader["idDemande"]),
                        DateDemande = Convert.ToDateTime(reader["dateDemande"]),
                        NomPatrimoine = patrimoine?.ToString(),
                        NomPrenomEmploye = employe?.ToString(),
                        IdPatrimoine = patrimoine?.IdPatrimoine??0,
                        MatriculeEmploye = employe?.Matricule??0
                    });
                }
            }

            return demandeAffectationListe;
        }
    }
}
