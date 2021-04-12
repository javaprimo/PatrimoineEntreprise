using DatabaseAccess.Models;
using DatabaseAccess.Repositories;
using System;
using System.Windows.Forms;

namespace GestionPatrimoine
{
    public partial class AjoutModificationPatrimoineEntreprise : Form
    {
        private readonly int _idPatrimoine = 0;
        public AjoutModificationPatrimoineEntreprise()
        {
            InitializeComponent();
            CenterToScreen();

            InitializeCmbFiltrerDemandeAffectationListeEmploye();
            InitializeCmbFiltrerCategorie();
        }

        public AjoutModificationPatrimoineEntreprise(int idPatrimoine)
        {
            _idPatrimoine = idPatrimoine;

            InitializeComponent();
            CenterToScreen();

            InitializeCmbFiltrerDemandeAffectationListeEmploye();
            InitializeCmbFiltrerCategorie();

            LoadEditData();
        }

        private void InitializeCmbFiltrerDemandeAffectationListeEmploye()
        {
            var listeEmployes = EmployeRepository.GetEmployeListe();
            cmbEmploye.Items.Insert(0, "-Aucune Affetation-");
            cmbEmploye.SelectedIndex = 0;
            foreach (var employe in listeEmployes)
            {
                cmbEmploye.Items.Insert(employe.Matricule, employe.ToString());
            }
        }

        private void InitializeCmbFiltrerCategorie()
        {
            var listeCategories = CategorieRepository.GetListeCategories();
            cmbCategorie.Items.Insert(0, "-Aucune Catégorie-");
            cmbCategorie.SelectedIndex = 0;
            foreach (var categorie in listeCategories)
            {
                cmbCategorie.Items.Insert(categorie.Id, categorie.Nom);
            }
        }

        private void btnFermerFormulaure_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Hide();
            Dispose();
        }

        private void LoadEditData()
        {
            if (_idPatrimoine <= 0)
                return;

            var patrimoineEntreprise = PatrimoineEntrpriseRepository.GetPatrimoineEntrpriseById(_idPatrimoine);
            txtNom.Text = patrimoineEntreprise.Nom;
            txtDescription.Text = patrimoineEntreprise.Description;
            numUDPrix.Value = patrimoineEntreprise.Prix;
            numUDDateAmotissement.Value = patrimoineEntreprise.DureeAmortissement;
            numUDTauxAmortissement.Value = patrimoineEntreprise.TauxAmortissement.Value;
            numUDPrixAmotissement.Value = patrimoineEntreprise.PrixApresAmortissement;
            numUDAnciennete.Value = patrimoineEntreprise.Anciennete;
            cmbStatus.SelectedItem = patrimoineEntreprise.Status;
            dtDateAchat.Value = patrimoineEntreprise.DateAchat;
            cmbCategorie.SelectedItem = patrimoineEntreprise.Categorie;
            cmbEmploye.SelectedItem = patrimoineEntreprise.Employe;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            var patrimoineEntreprise = new PatrimoineEntreprise()
            {
                IdPatrimoine = _idPatrimoine,
                Nom = txtNom.Text,
                Description = txtDescription.Text,
                Prix = numUDPrix.Value,
                DureeAmortissement = Convert.ToInt32(numUDDateAmotissement.Value),
                TauxAmortissement = numUDTauxAmortissement.Value,
                PrixApresAmortissement = numUDPrixAmotissement.Value,
                Anciennete = Convert.ToInt32(numUDAnciennete.Value),
                Status = (string)cmbStatus.SelectedItem,
                DateAchat = dtDateAchat.Value
            };

            var operationReussie = false;
            if (_idPatrimoine > 0)
            {
                operationReussie = PatrimoineEntrpriseRepository.TryUpdatePatrimoineEntrprise(patrimoineEntreprise, cmbCategorie.SelectedIndex, cmbEmploye.SelectedIndex);
            }
            else
            {
                operationReussie = PatrimoineEntrpriseRepository.TryInsertNewPatrimoineEntrprise(patrimoineEntreprise, cmbCategorie.SelectedIndex, cmbEmploye.SelectedIndex);
            }

            if (operationReussie)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.Abort;
            }
        }
    }
}
