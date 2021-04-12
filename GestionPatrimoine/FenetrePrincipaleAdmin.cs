using DatabaseAccess.Models;
using DatabaseAccess.Repositories;
using System;
using System.Windows.Forms;

namespace GestionPatrimoine
{
    public partial class FenetrePrincipaleAdmin : Form
    {
        private Employe _connectedEmploye;

        public FenetrePrincipaleAdmin(string userName)
        {
            _connectedEmploye = EmployeRepository.GetEmployeByCompteId(userName);
            InitializeComponent();
            CenterToScreen();

            InitializeListeEmployes();
            InitializeListePostes();
            InitializeListePatrimoine();
            InitializeListeDemandesAffectation();

            InitializeCmbFiltrerEmploye();
            InitializeCmbFiltrerCategorie();
            InitializeCmbFiltrerDemandeAffectationListeEmploye();
            InitializeCmbFiltrerDemandeAffectationNomPatrimoine();
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void InitializeListeEmployes()
        {
            var source = new BindingSource();
            source.DataSource = EmployeRepository.GetEmployeListe();
            dgridListeEmployes.DataSource = source;
        }

        private void InitializeListePatrimoine()
        {
            var source = new BindingSource();
            source.DataSource = PatrimoineEntrpriseRepository.GetPatrimoineEntrpriseListe();
            dgridListePatrimoineEntreprise.DataSource = source;
        }

        private void InitializeListeDemandesAffectation()
        {
            var source = new BindingSource();
            source.DataSource = DemandeAffectationRepository.GetDemandeAffectationListe();
            dgridListeDemandeAffectation.DataSource = source;
        }

        private void InitializeListePostes()
        {
            var listePostes = PosteRepository.GetListePostes();
            cmbFiltrerPoste.Items.Insert(0, "-Veuillez selectionner un poste-");
            cmbFiltrerPoste.SelectedIndex = 0;
            foreach (var poste in listePostes)
            {
                cmbFiltrerPoste.Items.Insert(poste.Id, poste.Libelle);
            }
        }

        private void InitializeCmbFiltrerEmploye()
        {
            var listeEmployes = EmployeRepository.GetEmployeListe();
            cmbFiltrerEmploye.Items.Insert(0, "-Veuillez selectionner un Employé-");
            cmbFiltrerEmploye.SelectedIndex = 0;
            foreach (var employe in listeEmployes)
            {
                cmbFiltrerEmploye.Items.Insert(employe.Matricule, employe.ToString());
            }
        }

        private void InitializeCmbFiltrerCategorie()
        {
            var listeCategories = CategorieRepository.GetListeCategories();
            cmbFiltrerCategorie.Items.Insert(0, "-Veuillez selectionner une Catégorie-");
            cmbFiltrerCategorie.SelectedIndex = 0;
            foreach (var categorie in listeCategories)
            {
                cmbFiltrerCategorie.Items.Insert(categorie.Id, categorie.Nom);
            }
        }

        private void InitializeCmbFiltrerDemandeAffectationListeEmploye()
        {
            var listeEmployes = EmployeRepository.GetEmployeListe();
            cmbFiltrerDemandeAffectationListeEmploye.Items.Insert(0, "-Veuillez selectionner un Employé-");
            cmbFiltrerDemandeAffectationListeEmploye.SelectedIndex = 0;
            foreach (var employe in listeEmployes)
            {
                cmbFiltrerDemandeAffectationListeEmploye.Items.Insert(employe.Matricule, employe.ToString());
            }
        }

        private void InitializeCmbFiltrerDemandeAffectationNomPatrimoine()
        {
            var listePatrimoineEntrprise = PatrimoineEntrpriseRepository.GetPatrimoineEntrpriseListe();
            cmbFiltrerDemandeAffectationNomPatrimoine.Items.Insert(0, "-Veuillez selectionner une Catégorie-");
            cmbFiltrerDemandeAffectationNomPatrimoine.SelectedIndex = 0;
            foreach (var patrimoineEntrprise in listePatrimoineEntrprise)
            {
                cmbFiltrerDemandeAffectationNomPatrimoine.Items.Insert(patrimoineEntrprise.IdPatrimoine, patrimoineEntrprise.ToString());
            }
        }

        private void btnFiltrerListePatrimoine_Click(object sender, System.EventArgs e)
        {
            var source = new BindingSource();
            source.DataSource = PatrimoineEntrpriseRepository.GetFilterePatrimoineEntrpriseListe(txtFiltrerPatrimoineEntrpriseNom.Text,
                cmbFiltrerEmploye.SelectedIndex,
                cmbFiltrerCategorie.SelectedIndex
                );
            dgridListePatrimoineEntreprise.DataSource = source;
        }

        private void btnFiltrerListeEmployes_Click(object sender, System.EventArgs e)
        {
            var source = new BindingSource();
            source.DataSource = EmployeRepository.GetFiltereEmployeListe(txtFiltrerEmployeNomEmploye.Text,
                txtFiltrerEmployePrenomEmploye.Text,
                cmbFiltrerPoste.SelectedIndex
                );
            dgridListeEmployes.DataSource = source;
        }

        private void btnFiltrerListeDemandeAffectation_Click_1(object sender, System.EventArgs e)
        {
            var source = new BindingSource();
            source.DataSource = DemandeAffectationRepository.GetFiltereDemandeAffectationListe(cmbFiltrerDemandeAffectationNomPatrimoine.SelectedIndex,
                cmbFiltrerDemandeAffectationListeEmploye.SelectedIndex,
                dtpDateDemandeAffectation.Value
                );
            dgridListeDemandeAffectation.DataSource = source;
        }

        private void FenetrePrincipaleAdmin_Load(object sender, System.EventArgs e)
        {
            InitializeListeEmployes();
            InitializeListePostes();
            InitializeListePatrimoine();
            InitializeListeDemandesAffectation();
        }
        
        private void dgridListePatrimoineEntreprise_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgridListePatrimoineEntreprise.Rows[e.RowIndex].Selected = true;
        }

        private void dgridListePatrimoineEntreprise_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgridListePatrimoineEntreprise.Rows[e.RowIndex].Selected = true;
        }

        private void dgridListePatrimoineEntreprise_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgridListePatrimoineEntreprise.Rows[e.RowIndex].Selected = true;
            var idPatrimoineEnreprise = Convert.ToInt32(dgridListePatrimoineEntreprise.Rows[e.RowIndex].Cells[0].Value);
            var ajouterUpdateForm = new AjoutModificationPatrimoineEntreprise(idPatrimoineEnreprise);
            AjouterUpdatePatrimoineEntreprise(ajouterUpdateForm);
        }

        private void btnAjouterPatrimoine_Click(object sender, System.EventArgs e)
        {
            var ajouterUpdateForm = new AjoutModificationPatrimoineEntreprise();
            AjouterUpdatePatrimoineEntreprise(ajouterUpdateForm);
        }

        private void AjouterUpdatePatrimoineEntreprise(AjoutModificationPatrimoineEntreprise ajouterUpdateForm)
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
                InitializeListePatrimoine();
            }
        }

    }
}
