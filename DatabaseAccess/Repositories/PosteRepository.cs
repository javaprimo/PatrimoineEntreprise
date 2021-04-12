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
    public class PosteRepository : RepositoryBase
    {

        private const string sqlStrListePostes = "select * from Poste";
        private const string sqlStrTrouverPosteParId = "select * from Poste where id = @Id";

        public static List<Poste> GetListePostes()
        {
            try
            {
                using (var connexion = PatrimoineEntrpriseDBContext.GetDBConnection())
                {
                    var sqlQuery = new SqlCommand(sqlStrListePostes, connexion);
                    return GetListePosteFromSqlCommand(sqlQuery);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Important Exception {ex.Message}", $"What happened?", MessageBoxButtons.YesNo);
            }

            return new List<Poste>();
        }

        public static Poste GetPosteById(int id)
        {
            try
            {
                using (var connexion = PatrimoineEntrpriseDBContext.GetDBConnection())
                {
                    var sqlQuery = new SqlCommand(sqlStrTrouverPosteParId, connexion);
                    sqlQuery.Parameters.Add(GetParam("@Id", id));
                    var listePostes = GetListePosteFromSqlCommand(sqlQuery);
                    if (listePostes.Any())
                        return listePostes[0];

                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Important Exception {ex.Message}", $"What happened?", MessageBoxButtons.YesNo);
            }

            return null;
        }


        private static List<Poste> GetListePosteFromSqlCommand(SqlCommand sqlCommand)
        {
            var postesListe = new List<Poste>();
            sqlCommand.Connection.Open();
            using (var reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    postesListe.Add(new Poste()
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        Libelle = (string)reader["libelle"]
                    });
                }
            }

            return postesListe;
        }
    }
}
