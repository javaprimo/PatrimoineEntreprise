using DatabaseAccess.Repositories;
using System;
using System.Text;
using System.Windows.Forms;

namespace GestionPatrimoine
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            try
            {
                var userName = txtLogin.Text;
                var motDePasse = txtMotDePasse.Text;
                var niveau = chkBIsAdmin.Checked ? NiveauCompte.Admin : NiveauCompte.Employe;
                CheckLoginInputData(userName, motDePasse, niveau);

                byte[] bytesData = Encoding.ASCII.GetBytes(motDePasse);
                string passwordHash = Convert.ToBase64String(bytesData);
                var compte = CompteRepository.GetCompteByUserNameAndPassword(userName, passwordHash, (int)niveau);
                if (compte.userName != userName)
                {
                    throw new Exception("L'information UserName/Password forunie est incorrecte");
                }

                var niveauCompte = (NiveauCompte)compte.niveau;
                if (niveauCompte == NiveauCompte.Employe)
                {
                    var fenetrePrincipale = new FenetrePrincipaleEmployeSimple(compte.userName);
                    Hide();
                    fenetrePrincipale.Show();
                }
                else if (niveauCompte == NiveauCompte.Admin)
                {
                    var fenetrePrincipale = new FenetrePrincipaleAdmin(compte.userName);
                    Hide();
                    fenetrePrincipale.Show();
                }
                else
                {
                    throw new Exception("Votre niveau d'habilitation est inconnu, merci de vous approcher de votre administrateur système");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"What happened?", $"Important Exception {ex.Message}", MessageBoxButtons.YesNo);
            }
        }

        private void CheckLoginInputData(string login, string motDePasse, NiveauCompte niveau)
        {
            if (string.IsNullOrWhiteSpace(login))
                throw new Exception("Veuillez saisir un login");

            if (string.IsNullOrWhiteSpace(motDePasse))
                throw new Exception("Veuillez saisir un mot de passe");

            if ((int)niveau == -1)
                throw new Exception("Veuillez choisur un niveau d'habilitation");

            if ((int)niveau > 1)
                throw new Exception("Niveau d'habilitation non géré");
        }
    }

    //voir enum NiveauUser
    public enum NiveauCompte
    {
        Employe,
        Admin
    }
}
