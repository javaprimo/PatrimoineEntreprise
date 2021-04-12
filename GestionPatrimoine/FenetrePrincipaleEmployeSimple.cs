using DatabaseAccess.Models;
using DatabaseAccess.Repositories;
using System;
using System.Windows.Forms;

namespace GestionPatrimoine
{
    public partial class FenetrePrincipaleEmployeSimple : Form
    {
        private Employe _connectedEmploye;

        public FenetrePrincipaleEmployeSimple(string userName)
        {
            _connectedEmploye = EmployeRepository.GetEmployeByCompteId(userName);
            InitializeComponent();
            CenterToScreen();

            InitializeListeEquipements();
            InitializeMesDemandesEquipements();
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void FenetrePrincipaleEmployeSimple_Load(object sender, System.EventArgs e)
        {
            InitializeListeEquipements();
            InitializeMesDemandesEquipements();
        }

        private void InitializeListeEquipements()
        {
            var source = new BindingSource();
            source.DataSource = PatrimoineEntrpriseRepository.GetPatrimoineEntrpriseListe();
            dgridListePatrimoineEntreprise.DataSource = source;
        }

        private void InitializeMesDemandesEquipements()
        {
            var source = new BindingSource();
            source.DataSource = DemandeAffectationRepository.GetFiltereDemandeAffectationListe(_connectedEmploye.Matricule);
            dgridListeMesDemandeAffectation.DataSource = source;
        }

        private void btnFiltrerMesEquipements_Click(object sender, System.EventArgs e)
        {
            var source = new BindingSource();
            source.DataSource = PatrimoineEntrpriseRepository.GetFilterePatrimoineEntrpriseListe(_connectedEmploye.Matricule);
            dgridListePatrimoineEntreprise.DataSource = source;
        }

        private void btnListeToutLesEquipements_Click(object sender, System.EventArgs e)
        {
            InitializeListeEquipements();
        }

        private void dgridListeMesDemandeAffectation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgridListeMesDemandeAffectation.Rows[e.RowIndex].Selected = true;
        }

        private void dgridListeMesDemandeAffectation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgridListeMesDemandeAffectation.Rows[e.RowIndex].Selected = true;
        }

        private void dgridListeMesDemandeAffectation_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgridListeMesDemandeAffectation.Rows[e.RowIndex].Selected = true;
            var idDemandeAffectation = Convert.ToInt32(dgridListeMesDemandeAffectation.Rows[e.RowIndex].Cells[0].Value);
            var ajouterUpdateForm = new AjouterDemandeAffectation(_connectedEmploye.Matricule, idDemandeAffectation);
            AjouterUpdatePatrimoineEntreprise(ajouterUpdateForm);
        }

        private void btnNouvelleDemandeAffectation_Click(object sender, System.EventArgs e)
        {
            var ajouterUpdateForm = new AjouterDemandeAffectation(_connectedEmploye.Matricule);
            AjouterUpdatePatrimoineEntreprise(ajouterUpdateForm);
        }

        private void AjouterUpdatePatrimoineEntreprise(AjouterDemandeAffectation ajouterUpdateForm)
        {
            try
            {
                var dialogResult = ajouterUpdateForm.ShowDialog(this);
                if (dialogResult == DialogResult.OK)
                {
                    MessageBox.Show($"Enregistrmeant effectuée avec succès !", $"Succès !", MessageBoxButtons.OK);
                }
                else if (dialogResult == DialogResult.Abort)
                {
                    MessageBox.Show($"Enregistrmeant échoué, merci de vérifier vos données !", $"Echec !", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Important Exception {ex.Message}", $"What happened?", MessageBoxButtons.YesNo);
            }
            finally
            {
                InitializeMesDemandesEquipements();
            }
        }
    }
}
