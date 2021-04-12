using DatabaseAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace DatabaseAccess.Repositories
{
    public class CompteRepository : RepositoryBase
    {
        private const string sqlStrCompteByUserNameAndPawword = "select * from compte where username = @UserName and password = @Password and niveau = @Niveau";

        public static Compte GetCompteByUserNameAndPassword(string userName, string password, int niveau)
        {
            try
            {
                using (var connexion = PatrimoineEntrpriseDBContext.GetDBConnection())
                {
                    var sqlQuery = new SqlCommand(sqlStrCompteByUserNameAndPawword, connexion);
                    sqlQuery.Parameters.Add(GetParam("@UserName", userName));
                    sqlQuery.Parameters.Add(GetParam("@Password", password));
                    sqlQuery.Parameters.Add(GetParam("@Niveau", niveau));

                    var listeComptes = GetListeEmployesSqlCommand(sqlQuery);
                    if (listeComptes.Any())
                        return listeComptes[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Important Exception {ex.Message}", $"What happened?", MessageBoxButtons.YesNo);
            }

            return new Compte();
        }


        private static List<Compte> GetListeEmployesSqlCommand(SqlCommand sqlQuery)
        {
            var comptesListe = new List<Compte>();
            sqlQuery.Connection.Open();
            using (var reader = sqlQuery.ExecuteReader())
            {
                while (reader.Read())
                {
                    comptesListe.Add(new Compte()
                    {
                        userName = (string)reader["userName"],
                        niveau = Convert.ToInt32(reader["niveau"])
                    });
                }
            }

            return comptesListe;
        }
    }
}
