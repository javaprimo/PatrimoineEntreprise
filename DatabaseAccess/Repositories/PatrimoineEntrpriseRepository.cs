using DatabaseAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace DatabaseAccess.Repositories
{
    public class PatrimoineEntrpriseRepository : RepositoryBase
    {
        private const string sqlStrListePatrimoineEntreprise = "select * from patrimoine where 1 = 1";
        private const string sqlStrFiltrerWithNomPatrimoineEntreprise = @"(nom like '%' + @Nom + '%')";
        private const string sqlStrFiltrerWithNomMatriculeEmploye = @"(matricule = @MatriculeEmploye)";
        private const string sqlStrFiltrerWithNomIdCategorie = @"(idCategorie = @CategoryId)";
        private const string sqlStrPatrimoineEntrepriseById = "select * from patrimoine where idPatrimoine = @IdPatrimoine";
        private const string sqlStrInsertPatrimoineEntreprise = "insert into patrimoine(nom, description, prix, dureeAmortissement, tauxAmortissement, prixApresAmortissement, anciennete, status, dateAchat, idCategorie, matricule) " +
            "VALUES (@Nom, @Description, @Prix, @DureeAmortissement, @TauxAmortissement, @PrixApresAmortissement, @Anciennete, @Status, @DateAchat, @IdCategorie, @Matricule)";
        private const string sqlStrUpdatePatrimoineEntreprise = "update patrimoine set nom = @Nom, description = @Description, prix = @Prix, dureeAmortissement = @DureeAmortissement, " +
            "tauxAmortissement = @TauxAmortissement, prixApresAmortissement = @PrixApresAmortissement, anciennete = @Anciennete, status = @Status, dateAchat = @DateAchat, idCategorie = @IdCategorie, matricule = @Matricule where idPatrimoine = @IdPatrimoine";

        public static List<PatrimoineEntreprise> GetPatrimoineEntrpriseListe()
        {
            try
            {
                using (var connexion = PatrimoineEntrpriseDBContext.GetDBConnection())
                {
                    var sqlQuery = new SqlCommand(sqlStrListePatrimoineEntreprise, connexion);
                    return GetListePatrimoineEntrepriseSqlCommand(sqlQuery);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Important Exception {ex.Message}", $"What happened?", MessageBoxButtons.YesNo);
            }

            return new List<PatrimoineEntreprise>();
        }

        public static List<PatrimoineEntreprise> GetFilterePatrimoineEntrpriseListe(string nom, int matriculeEmploye, int categoryId)
        {
            try
            {
                using (var connexion = PatrimoineEntrpriseDBContext.GetDBConnection())
                {
                    var sqlstring = sqlStrListePatrimoineEntreprise;
                    if (!string.IsNullOrWhiteSpace(nom))
                        sqlstring = $"{sqlstring} and {sqlStrFiltrerWithNomPatrimoineEntreprise}";
                    if (matriculeEmploye > 0)
                        sqlstring = $"{sqlstring} and {sqlStrFiltrerWithNomMatriculeEmploye}";
                    if (categoryId > 0)
                        sqlstring = $"{sqlstring} and {sqlStrFiltrerWithNomIdCategorie}";

                    var sqlCommand = new SqlCommand(sqlstring, connexion);
                    sqlCommand.Parameters.Add(GetParam("@Nom", nom));
                    sqlCommand.Parameters.Add(GetParam("@MatriculeEmploye", matriculeEmploye));
                    sqlCommand.Parameters.Add(GetParam("@CategoryId", categoryId));

                    return GetListePatrimoineEntrepriseSqlCommand(sqlCommand);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Important Exception {ex.Message}", $"What happened?", MessageBoxButtons.YesNo);
            }

            return new List<PatrimoineEntreprise>();
        }

        public static bool TryInsertNewPatrimoineEntrprise(PatrimoineEntreprise patrimoineEntreprise, int idCategorie, int? idEmploye)
        {
            try
            {
                using (var connexion = PatrimoineEntrpriseDBContext.GetDBConnection())
                {
                    var sqlCommand = new SqlCommand(sqlStrInsertPatrimoineEntreprise, connexion);
                    sqlCommand.Parameters.Add(GetParam("@Nom", patrimoineEntreprise.Nom));
                    sqlCommand.Parameters.Add(GetParam("@Description", patrimoineEntreprise.Description));
                    sqlCommand.Parameters.Add(GetParam("@Prix", patrimoineEntreprise.Prix));
                    sqlCommand.Parameters.Add(GetParam("@DureeAmortissement", patrimoineEntreprise.DureeAmortissement));
                    sqlCommand.Parameters.Add(GetParam("@TauxAmortissement", patrimoineEntreprise.TauxAmortissement));
                    sqlCommand.Parameters.Add(GetParam("@PrixApresAmortissement", patrimoineEntreprise.PrixApresAmortissement));
                    sqlCommand.Parameters.Add(GetParam("@Anciennete", patrimoineEntreprise.Anciennete));
                    sqlCommand.Parameters.Add(GetParam("@Status", patrimoineEntreprise.Status));
                    sqlCommand.Parameters.Add(GetParam("@DateAchat", patrimoineEntreprise.DateAchat));
                    sqlCommand.Parameters.Add(GetParam("@IdCategorie", idCategorie));
                    if(idEmploye > 0)
                        sqlCommand.Parameters.Add(GetParam("@Matricule", idEmploye));
                    else
                        sqlCommand.Parameters.Add(GetParam("@Matricule", DBNull.Value));

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

        public static bool TryUpdatePatrimoineEntrprise(PatrimoineEntreprise patrimoineEntreprise, int idCategorie, int? idEmploye)
        {
            try
            {
                using (var connexion = PatrimoineEntrpriseDBContext.GetDBConnection())
                {

                    if (patrimoineEntreprise.IdPatrimoine <= 0)
                        return false;

                    var sqlCommand = new SqlCommand(sqlStrUpdatePatrimoineEntreprise, connexion);
                    sqlCommand.Parameters.Add(GetParam("@IdPatrimoine", patrimoineEntreprise.IdPatrimoine));
                    sqlCommand.Parameters.Add(GetParam("@Nom", patrimoineEntreprise.Nom));
                    sqlCommand.Parameters.Add(GetParam("@Description", patrimoineEntreprise.Description));
                    sqlCommand.Parameters.Add(GetParam("@Prix", patrimoineEntreprise.Prix));
                    sqlCommand.Parameters.Add(GetParam("@DureeAmortissement", patrimoineEntreprise.DureeAmortissement));
                    sqlCommand.Parameters.Add(GetParam("@TauxAmortissement", patrimoineEntreprise.TauxAmortissement));
                    sqlCommand.Parameters.Add(GetParam("@PrixApresAmortissement", patrimoineEntreprise.PrixApresAmortissement));
                    sqlCommand.Parameters.Add(GetParam("@Anciennete", patrimoineEntreprise.Anciennete));
                    sqlCommand.Parameters.Add(GetParam("@Status", patrimoineEntreprise.Status));
                    sqlCommand.Parameters.Add(GetParam("@DateAchat", patrimoineEntreprise.DateAchat));
                    sqlCommand.Parameters.Add(GetParam("@IdCategorie", idCategorie));
                    if (idEmploye > 0)
                        sqlCommand.Parameters.Add(GetParam("@Matricule", idEmploye));
                    else
                        sqlCommand.Parameters.Add(GetParam("@Matricule", DBNull.Value));

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

        public static List<PatrimoineEntreprise> GetFilterePatrimoineEntrpriseListe(int matriculeEmploye)
        {
            try
            {
                using (var connexion = PatrimoineEntrpriseDBContext.GetDBConnection())
                {
                    var sqlstring = sqlStrListePatrimoineEntreprise;
                    if (matriculeEmploye > 0)
                        sqlstring = $"{sqlstring} and {sqlStrFiltrerWithNomMatriculeEmploye}";
                    
                    var sqlCommand = new SqlCommand(sqlstring, connexion);
                    sqlCommand.Parameters.Add(GetParam("@MatriculeEmploye", matriculeEmploye));
                    
                    return GetListePatrimoineEntrepriseSqlCommand(sqlCommand);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Important Exception {ex.Message}", $"What happened?", MessageBoxButtons.YesNo);
            }

            return new List<PatrimoineEntreprise>();
        }

        public static PatrimoineEntreprise GetPatrimoineEntrpriseById(int idPatrimoine)
        {
            try
            {
                using (var connexion = PatrimoineEntrpriseDBContext.GetDBConnection())
                {
                    var sqlQuery = new SqlCommand(sqlStrPatrimoineEntrepriseById, connexion);
                    sqlQuery.Parameters.Add(GetParam("@IdPatrimoine", idPatrimoine));
                    var listePatrimoineEntreprise = GetListePatrimoineEntrepriseSqlCommand(sqlQuery);
                    if (listePatrimoineEntreprise.Any())
                        return listePatrimoineEntreprise[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Important Exception {ex.Message}", $"What happened?", MessageBoxButtons.YesNo);
            }

            return new PatrimoineEntreprise();
        }

        private static List<PatrimoineEntreprise> GetListePatrimoineEntrepriseSqlCommand(SqlCommand sqlQuery)
        {
            var patrimoineEntrepriseListe = new List<PatrimoineEntreprise>();
            sqlQuery.Connection.Open();
            using (var reader = sqlQuery.ExecuteReader())
            {
                while (reader.Read())
                {
                    var categorie = CategorieRepository.GetCategorieById((int)reader["idCategorie"]);
                    var employe = new Employe();
                    if (reader["matricule"] != DBNull.Value)
                        employe = EmployeRepository.GetEmployeByMatricule(Convert.ToInt32(reader["matricule"]));

                    patrimoineEntrepriseListe.Add(new PatrimoineEntreprise()
                    {
                        IdPatrimoine = Convert.ToInt32(reader["idPatrimoine"]),
                        Nom = (string)reader["nom"],
                        Description = (string)reader["description"],
                        Prix = Convert.ToDecimal(reader["prix"] != DBNull.Value ? reader["prix"] : null),
                        DureeAmortissement = Convert.ToInt32(reader["dureeAmortissement"] != DBNull.Value ? reader["dureeAmortissement"] : null),
                        TauxAmortissement = Convert.ToDecimal(reader["tauxAmortissement"] != DBNull.Value ? reader["tauxAmortissement"] : null),
                        PrixApresAmortissement = Convert.ToDecimal(reader["prixApresAmortissement"] != DBNull.Value ? reader["prixApresAmortissement"] : null),
                        Anciennete = Convert.ToInt32(reader["anciennete"] != DBNull.Value ? reader["anciennete"] : null),
                        Status = (string)reader["status"],
                        DateAchat = Convert.ToDateTime(reader["dateAchat"] != DBNull.Value ? reader["dateAchat"] : null),
                        Categorie = categorie?.Nom,
                        Employe = employe?.ToString()
                    });
                }
            }

            return patrimoineEntrepriseListe;
        }
    }
}
