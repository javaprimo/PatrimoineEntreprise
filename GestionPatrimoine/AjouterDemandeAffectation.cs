using DatabaseAccess.Models;
using DatabaseAccess.Repositories;
using System;
using System.Windows.Forms;

namespace GestionPatrimoine
{
    public partial class AjouterDemandeAffectation : Form
    {
        private readonly int _idDemandeAffectation = 0;
        private readonly int _idConnectedUser = 0;

        public AjouterDemandeAffectation(int idConnectedUser)
        {
            _idConnectedUser = idConnectedUser;
            InitializeComponent();
            CenterToScreen();

            InitializeCmbPatrimoineEntrprise();
        }

        public AjouterDemandeAffectation(int idConnectedUser, int idDemandeAffectation)
        {
            _idConnectedUser = idConnectedUser;
            _idDemandeAffectation = idDemandeAffectation;
            InitializeComponent();
            CenterToScreen();

            InitializeCmbPatrimoineEntrprise();
            LoadDemandeAffectation();
        }

        private void LoadDemandeAffectation()
        {
            if (_idDemandeAffectation <= 0)
                return;

            var demandeAffectation = DemandeAffectationRepository.GetDemandeAffectationById(_idDemandeAffectation);
            cmbPatrimoineEntreprise.SelectedIndex = demandeAffectation.IdPatrimoine;
            dtDateDemandeAffectation.Value = demandeAffectation.DateDemande;
        }

        private void btnFermerFormulaure_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Hide();
            Dispose();
        }

        private void InitializeCmbPatrimoineEntrprise()
        {
            var listePatrimoineEntreprise = PatrimoineEntrpriseRepository.GetPatrimoineEntrpriseListe();
            cmbPatrimoineEntreprise.Items.Insert(0, "-Aucun Patrimoine selectionné-");
            cmbPatrimoineEntreprise.SelectedIndex = 0;
            foreach (var patrimoineEntreprise in listePatrimoineEntreprise)
            {
                cmbPatrimoineEntreprise.Items.Insert(patrimoineEntreprise.IdPatrimoine, patrimoineEntreprise.Nom);
            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            var operationReussie = false;
            if (_idDemandeAffectation > 0)
            {
                operationReussie = DemandeAffectationRepository.TryUpdateDemandeAffectation(_idDemandeAffectation, cmbPatrimoineEntreprise.SelectedIndex, dtDateDemandeAffectation.Value);
            }
            else
            {
                var demandeAffectation = new DemandeAffectation()
                {
                    IdDemande = _idDemandeAffectation,
                    MatriculeEmploye = _idConnectedUser,
                    IdPatrimoine = cmbPatrimoineEntreprise.SelectedIndex,
                    DateDemande = dtDateDemandeAffectation.Value
                };

                operationReussie = DemandeAffectationRepository.TryInsertNewDemandeAffectation(demandeAffectation);
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

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Hide();
            Dispose();
        }
    }
}
