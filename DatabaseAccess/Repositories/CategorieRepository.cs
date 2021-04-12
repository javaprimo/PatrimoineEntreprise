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
    public class CategorieRepository : RepositoryBase
    {

        private const string sqlStrListeCategories = "select * from categorie";
        private const string sqlStrTrouverCategorieParId = "select * from categorie where id = @Id";

        public static List<Categorie> GetListeCategories()
        {
            try
            {
                using (var connexion = PatrimoineEntrpriseDBContext.GetDBConnection())
                {
                    var sqlQuery = new SqlCommand(sqlStrListeCategories, connexion);
                    return GetListeCategoriesFromSqlCommand(sqlQuery);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Important Exception {ex.Message}", $"What happened?", MessageBoxButtons.YesNo);
            }

            return new List<Categorie>();
        }

        public static Categorie GetCategorieById(int id)
        {
            try
            {
                using (var connexion = PatrimoineEntrpriseDBContext.GetDBConnection())
                {
                    var sqlQuery = new SqlCommand(sqlStrTrouverCategorieParId, connexion);
                    sqlQuery.Parameters.Add(GetParam("@Id", id));
                    var listCategories = GetListeCategoriesFromSqlCommand(sqlQuery);
                    if (listCategories.Any())
                        return listCategories[0];

                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Important Exception {ex.Message}", $"What happened?", MessageBoxButtons.YesNo);
            }

            return null;
        }


        private static List<Categorie> GetListeCategoriesFromSqlCommand(SqlCommand sqlCommand)
        {
            var categoriesListe = new List<Categorie>();
            sqlCommand.Connection.Open();
            using (var reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    categoriesListe.Add(new Categorie()
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        Nom = (string)reader["libelle"]
                    });
                }
            }

            return categoriesListe;
        }
    }
}
