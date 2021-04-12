namespace GestionPatrimoine
{
    partial class FenetrePrincipaleAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstTabsGestionPatrimoine = new System.Windows.Forms.TabControl();
            this.tabListePatrimoine = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgridListePatrimoineEntreprise = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbFiltrerEmploye = new System.Windows.Forms.ComboBox();
            this.cmbFiltrerCategorie = new System.Windows.Forms.ComboBox();
            this.txtFiltrerPatrimoineEntrpriseNom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAjouterPatrimoine = new System.Windows.Forms.Button();
            this.btnFiltrerListePatrimoine = new System.Windows.Forms.Button();
            this.tabDemandeAffectation = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgridListeDemandeAffectation = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpDateDemandeAffectation = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbFiltrerDemandeAffectationNomPatrimoine = new System.Windows.Forms.ComboBox();
            this.cmbFiltrerDemandeAffectationListeEmploye = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnFiltrerListeDemandeAffectation = new System.Windows.Forms.Button();
            this.tabListeEmployes = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbFiltrerPoste = new System.Windows.Forms.ComboBox();
            this.txtFiltrerEmployePrenomEmploye = new System.Windows.Forms.TextBox();
            this.txtFiltrerEmployeNomEmploye = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFiltrerListeEmployes = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgridListeEmployes = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.lstTabsGestionPatrimoine.SuspendLayout();
            this.tabListePatrimoine.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridListePatrimoineEntreprise)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabDemandeAffectation.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridListeDemandeAffectation)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabListeEmployes.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridListeEmployes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1120, 183);
            this.panel2.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::GestionPatrimoine.Resources.header_materiel_liste;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1120, 183);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lstTabsGestionPatrimoine
            // 
            this.lstTabsGestionPatrimoine.Controls.Add(this.tabListePatrimoine);
            this.lstTabsGestionPatrimoine.Controls.Add(this.tabDemandeAffectation);
            this.lstTabsGestionPatrimoine.Controls.Add(this.tabListeEmployes);
            this.lstTabsGestionPatrimoine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTabsGestionPatrimoine.Location = new System.Drawing.Point(0, 182);
            this.lstTabsGestionPatrimoine.Name = "lstTabsGestionPatrimoine";
            this.lstTabsGestionPatrimoine.SelectedIndex = 0;
            this.lstTabsGestionPatrimoine.Size = new System.Drawing.Size(1120, 470);
            this.lstTabsGestionPatrimoine.TabIndex = 12;
            // 
            // tabListePatrimoine
            // 
            this.tabListePatrimoine.Controls.Add(this.panel1);
            this.tabListePatrimoine.Controls.Add(this.groupBox1);
            this.tabListePatrimoine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabListePatrimoine.Location = new System.Drawing.Point(4, 25);
            this.tabListePatrimoine.Name = "tabListePatrimoine";
            this.tabListePatrimoine.Padding = new System.Windows.Forms.Padding(3);
            this.tabListePatrimoine.Size = new System.Drawing.Size(1112, 441);
            this.tabListePatrimoine.TabIndex = 0;
            this.tabListePatrimoine.Text = "Liste du patrimoine entreprise";
            this.tabListePatrimoine.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgridListePatrimoineEntreprise);
            this.panel1.Location = new System.Drawing.Point(22, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 356);
            this.panel1.TabIndex = 1;
            // 
            // dgridListePatrimoineEntreprise
            // 
            this.dgridListePatrimoineEntreprise.AllowUserToAddRows = false;
            this.dgridListePatrimoineEntreprise.AllowUserToDeleteRows = false;
            this.dgridListePatrimoineEntreprise.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgridListePatrimoineEntreprise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridListePatrimoineEntreprise.Location = new System.Drawing.Point(-1, -3);
            this.dgridListePatrimoineEntreprise.MultiSelect = false;
            this.dgridListePatrimoineEntreprise.Name = "dgridListePatrimoineEntreprise";
            this.dgridListePatrimoineEntreprise.ReadOnly = true;
            this.dgridListePatrimoineEntreprise.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgridListePatrimoineEntreprise.Size = new System.Drawing.Size(1068, 358);
            this.dgridListePatrimoineEntreprise.StandardTab = true;
            this.dgridListePatrimoineEntreprise.TabIndex = 2;
            this.dgridListePatrimoineEntreprise.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridListePatrimoineEntreprise_CellClick);
            this.dgridListePatrimoineEntreprise.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridListePatrimoineEntreprise_CellContentClick);
            this.dgridListePatrimoineEntreprise.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridListePatrimoineEntreprise_CellDoubleClick);
            this.dgridListePatrimoineEntreprise.VisibleChanged += new System.EventHandler(this.FenetrePrincipaleAdmin_Load);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbFiltrerEmploye);
            this.groupBox1.Controls.Add(this.cmbFiltrerCategorie);
            this.groupBox1.Controls.Add(this.txtFiltrerPatrimoineEntrpriseNom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAjouterPatrimoine);
            this.groupBox1.Controls.Add(this.btnFiltrerListePatrimoine);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1068, 61);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtres / Ajout du patrimoine";
            // 
            // cmbFiltrerEmploye
            // 
            this.cmbFiltrerEmploye.FormattingEnabled = true;
            this.cmbFiltrerEmploye.Location = new System.Drawing.Point(338, 23);
            this.cmbFiltrerEmploye.Name = "cmbFiltrerEmploye";
            this.cmbFiltrerEmploye.Size = new System.Drawing.Size(207, 23);
            this.cmbFiltrerEmploye.TabIndex = 8;
            // 
            // cmbFiltrerCategorie
            // 
            this.cmbFiltrerCategorie.FormattingEnabled = true;
            this.cmbFiltrerCategorie.Location = new System.Drawing.Point(634, 23);
            this.cmbFiltrerCategorie.Name = "cmbFiltrerCategorie";
            this.cmbFiltrerCategorie.Size = new System.Drawing.Size(207, 23);
            this.cmbFiltrerCategorie.TabIndex = 7;
            // 
            // txtFiltrerPatrimoineEntrpriseNom
            // 
            this.txtFiltrerPatrimoineEntrpriseNom.Location = new System.Drawing.Point(89, 25);
            this.txtFiltrerPatrimoineEntrpriseNom.Name = "txtFiltrerPatrimoineEntrpriseNom";
            this.txtFiltrerPatrimoineEntrpriseNom.Size = new System.Drawing.Size(167, 21);
            this.txtFiltrerPatrimoineEntrpriseNom.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(551, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Catégorie :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Employé :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom : ";
            // 
            // btnAjouterPatrimoine
            // 
            this.btnAjouterPatrimoine.Location = new System.Drawing.Point(969, 20);
            this.btnAjouterPatrimoine.Name = "btnAjouterPatrimoine";
            this.btnAjouterPatrimoine.Size = new System.Drawing.Size(75, 28);
            this.btnAjouterPatrimoine.TabIndex = 1;
            this.btnAjouterPatrimoine.Text = "Ajouter";
            this.btnAjouterPatrimoine.UseVisualStyleBackColor = true;
            this.btnAjouterPatrimoine.Click += new System.EventHandler(this.btnAjouterPatrimoine_Click);
            // 
            // btnFiltrerListePatrimoine
            // 
            this.btnFiltrerListePatrimoine.Location = new System.Drawing.Point(876, 21);
            this.btnFiltrerListePatrimoine.Name = "btnFiltrerListePatrimoine";
            this.btnFiltrerListePatrimoine.Size = new System.Drawing.Size(75, 28);
            this.btnFiltrerListePatrimoine.TabIndex = 0;
            this.btnFiltrerListePatrimoine.Text = "Filtrer";
            this.btnFiltrerListePatrimoine.UseVisualStyleBackColor = true;
            this.btnFiltrerListePatrimoine.Click += new System.EventHandler(this.btnFiltrerListePatrimoine_Click);
            // 
            // tabDemandeAffectation
            // 
            this.tabDemandeAffectation.Controls.Add(this.panel3);
            this.tabDemandeAffectation.Controls.Add(this.groupBox2);
            this.tabDemandeAffectation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDemandeAffectation.Location = new System.Drawing.Point(4, 25);
            this.tabDemandeAffectation.Name = "tabDemandeAffectation";
            this.tabDemandeAffectation.Padding = new System.Windows.Forms.Padding(3);
            this.tabDemandeAffectation.Size = new System.Drawing.Size(1112, 441);
            this.tabDemandeAffectation.TabIndex = 1;
            this.tabDemandeAffectation.Text = "Les demandes d\'affectation";
            this.tabDemandeAffectation.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgridListeDemandeAffectation);
            this.panel3.Location = new System.Drawing.Point(21, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1068, 356);
            this.panel3.TabIndex = 5;
            // 
            // dgridListeDemandeAffectation
            // 
            this.dgridListeDemandeAffectation.AllowUserToAddRows = false;
            this.dgridListeDemandeAffectation.AllowUserToDeleteRows = false;
            this.dgridListeDemandeAffectation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgridListeDemandeAffectation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridListeDemandeAffectation.Location = new System.Drawing.Point(1, 3);
            this.dgridListeDemandeAffectation.Name = "dgridListeDemandeAffectation";
            this.dgridListeDemandeAffectation.ReadOnly = true;
            this.dgridListeDemandeAffectation.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgridListeDemandeAffectation.Size = new System.Drawing.Size(1068, 358);
            this.dgridListeDemandeAffectation.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpDateDemandeAffectation);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmbFiltrerDemandeAffectationNomPatrimoine);
            this.groupBox2.Controls.Add(this.cmbFiltrerDemandeAffectationListeEmploye);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnFiltrerListeDemandeAffectation);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(21, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1068, 61);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtres / Ajout des demandes affectation :";
            // 
            // dtpDateDemandeAffectation
            // 
            this.dtpDateDemandeAffectation.Location = new System.Drawing.Point(693, 22);
            this.dtpDateDemandeAffectation.Name = "dtpDateDemandeAffectation";
            this.dtpDateDemandeAffectation.Size = new System.Drawing.Size(223, 21);
            this.dtpDateDemandeAffectation.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(628, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Date :";
            // 
            // cmbFiltrerDemandeAffectationNomPatrimoine
            // 
            this.cmbFiltrerDemandeAffectationNomPatrimoine.FormattingEnabled = true;
            this.cmbFiltrerDemandeAffectationNomPatrimoine.Location = new System.Drawing.Point(79, 24);
            this.cmbFiltrerDemandeAffectationNomPatrimoine.Name = "cmbFiltrerDemandeAffectationNomPatrimoine";
            this.cmbFiltrerDemandeAffectationNomPatrimoine.Size = new System.Drawing.Size(207, 23);
            this.cmbFiltrerDemandeAffectationNomPatrimoine.TabIndex = 9;
            // 
            // cmbFiltrerDemandeAffectationListeEmploye
            // 
            this.cmbFiltrerDemandeAffectationListeEmploye.FormattingEnabled = true;
            this.cmbFiltrerDemandeAffectationListeEmploye.Location = new System.Drawing.Point(400, 20);
            this.cmbFiltrerDemandeAffectationListeEmploye.Name = "cmbFiltrerDemandeAffectationListeEmploye";
            this.cmbFiltrerDemandeAffectationListeEmploye.Size = new System.Drawing.Size(207, 23);
            this.cmbFiltrerDemandeAffectationListeEmploye.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(307, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Employé :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Nom : ";
            // 
            // btnFiltrerListeDemandeAffectation
            // 
            this.btnFiltrerListeDemandeAffectation.Location = new System.Drawing.Point(970, 20);
            this.btnFiltrerListeDemandeAffectation.Name = "btnFiltrerListeDemandeAffectation";
            this.btnFiltrerListeDemandeAffectation.Size = new System.Drawing.Size(84, 28);
            this.btnFiltrerListeDemandeAffectation.TabIndex = 0;
            this.btnFiltrerListeDemandeAffectation.Text = "Filtrer";
            this.btnFiltrerListeDemandeAffectation.UseVisualStyleBackColor = true;
            this.btnFiltrerListeDemandeAffectation.Click += new System.EventHandler(this.btnFiltrerListeDemandeAffectation_Click_1);
            // 
            // tabListeEmployes
            // 
            this.tabListeEmployes.Controls.Add(this.groupBox3);
            this.tabListeEmployes.Controls.Add(this.panel4);
            this.tabListeEmployes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabListeEmployes.Location = new System.Drawing.Point(4, 25);
            this.tabListeEmployes.Name = "tabListeEmployes";
            this.tabListeEmployes.Size = new System.Drawing.Size(1112, 441);
            this.tabListeEmployes.TabIndex = 2;
            this.tabListeEmployes.Text = "Liste des employés";
            this.tabListeEmployes.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbFiltrerPoste);
            this.groupBox3.Controls.Add(this.txtFiltrerEmployePrenomEmploye);
            this.groupBox3.Controls.Add(this.txtFiltrerEmployeNomEmploye);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnFiltrerListeEmployes);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(21, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1068, 61);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtres / Ajout du patrimoine";
            // 
            // cmbFiltrerPoste
            // 
            this.cmbFiltrerPoste.FormattingEnabled = true;
            this.cmbFiltrerPoste.Location = new System.Drawing.Point(697, 24);
            this.cmbFiltrerPoste.Name = "cmbFiltrerPoste";
            this.cmbFiltrerPoste.Size = new System.Drawing.Size(244, 23);
            this.cmbFiltrerPoste.TabIndex = 7;
            // 
            // txtFiltrerEmployePrenomEmploye
            // 
            this.txtFiltrerEmployePrenomEmploye.Location = new System.Drawing.Point(417, 24);
            this.txtFiltrerEmployePrenomEmploye.Name = "txtFiltrerEmployePrenomEmploye";
            this.txtFiltrerEmployePrenomEmploye.Size = new System.Drawing.Size(150, 21);
            this.txtFiltrerEmployePrenomEmploye.TabIndex = 6;
            // 
            // txtFiltrerEmployeNomEmploye
            // 
            this.txtFiltrerEmployeNomEmploye.Location = new System.Drawing.Point(129, 24);
            this.txtFiltrerEmployeNomEmploye.Name = "txtFiltrerEmployeNomEmploye";
            this.txtFiltrerEmployeNomEmploye.Size = new System.Drawing.Size(142, 21);
            this.txtFiltrerEmployeNomEmploye.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(582, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Poste employé :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Prénom employé :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nom employé :";
            // 
            // btnFiltrerListeEmployes
            // 
            this.btnFiltrerListeEmployes.Location = new System.Drawing.Point(970, 20);
            this.btnFiltrerListeEmployes.Name = "btnFiltrerListeEmployes";
            this.btnFiltrerListeEmployes.Size = new System.Drawing.Size(82, 28);
            this.btnFiltrerListeEmployes.TabIndex = 0;
            this.btnFiltrerListeEmployes.Text = "Filtrer";
            this.btnFiltrerListeEmployes.UseVisualStyleBackColor = true;
            this.btnFiltrerListeEmployes.Click += new System.EventHandler(this.btnFiltrerListeEmployes_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgridListeEmployes);
            this.panel4.Location = new System.Drawing.Point(22, 82);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1067, 356);
            this.panel4.TabIndex = 5;
            // 
            // dgridListeEmployes
            // 
            this.dgridListeEmployes.AllowUserToAddRows = false;
            this.dgridListeEmployes.AllowUserToDeleteRows = false;
            this.dgridListeEmployes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgridListeEmployes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridListeEmployes.Location = new System.Drawing.Point(-1, -5);
            this.dgridListeEmployes.Name = "dgridListeEmployes";
            this.dgridListeEmployes.ReadOnly = true;
            this.dgridListeEmployes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgridListeEmployes.Size = new System.Drawing.Size(1068, 358);
            this.dgridListeEmployes.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(995, 658);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 26);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Quitter";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FenetrePrincipaleAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 709);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lstTabsGestionPatrimoine);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FenetrePrincipaleAdmin";
            this.Text = "FenetrePrincipaleAdmin";
            this.Load += new System.EventHandler(this.FenetrePrincipaleAdmin_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.lstTabsGestionPatrimoine.ResumeLayout(false);
            this.tabListePatrimoine.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgridListePatrimoineEntreprise)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabDemandeAffectation.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgridListeDemandeAffectation)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabListeEmployes.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgridListeEmployes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl lstTabsGestionPatrimoine;
        private System.Windows.Forms.TabPage tabListePatrimoine;
        private System.Windows.Forms.TabPage tabDemandeAffectation;
        private System.Windows.Forms.TabPage tabListeEmployes;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFiltrerListePatrimoine;
        private System.Windows.Forms.Button btnAjouterPatrimoine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltrerPatrimoineEntrpriseNom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFiltrerCategorie;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbFiltrerPoste;
        private System.Windows.Forms.TextBox txtFiltrerEmployePrenomEmploye;
        private System.Windows.Forms.TextBox txtFiltrerEmployeNomEmploye;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFiltrerListeEmployes;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgridListeEmployes;
        private System.Windows.Forms.ComboBox cmbFiltrerEmploye;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbFiltrerDemandeAffectationListeEmploye;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnFiltrerListeDemandeAffectation;
        private System.Windows.Forms.DataGridView dgridListePatrimoineEntreprise;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgridListeDemandeAffectation;
        private System.Windows.Forms.DateTimePicker dtpDateDemandeAffectation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbFiltrerDemandeAffectationNomPatrimoine;
    }
}