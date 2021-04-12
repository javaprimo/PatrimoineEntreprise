namespace GestionPatrimoine
{
    partial class FenetrePrincipaleEmployeSimple
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
            this.btnExit = new System.Windows.Forms.Button();
            this.tabDemandeAffectation = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgridListeMesDemandeAffectation = new System.Windows.Forms.DataGridView();
            this.tabListePatrimoine = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgridListePatrimoineEntreprise = new System.Windows.Forms.DataGridView();
            this.btnFiltrerMesEquipements = new System.Windows.Forms.Button();
            this.lstTabsGestionPatrimoine = new System.Windows.Forms.TabControl();
            this.btnListeToutLesEquipements = new System.Windows.Forms.Button();
            this.btnNouvelleDemandeAffectation = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabDemandeAffectation.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridListeMesDemandeAffectation)).BeginInit();
            this.tabListePatrimoine.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridListePatrimoineEntreprise)).BeginInit();
            this.lstTabsGestionPatrimoine.SuspendLayout();
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
            // tabDemandeAffectation
            // 
            this.tabDemandeAffectation.Controls.Add(this.panel3);
            this.tabDemandeAffectation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDemandeAffectation.Location = new System.Drawing.Point(4, 25);
            this.tabDemandeAffectation.Name = "tabDemandeAffectation";
            this.tabDemandeAffectation.Padding = new System.Windows.Forms.Padding(3);
            this.tabDemandeAffectation.Size = new System.Drawing.Size(1112, 441);
            this.tabDemandeAffectation.TabIndex = 1;
            this.tabDemandeAffectation.Text = "Lites des/mes demandes équipements";
            this.tabDemandeAffectation.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgridListeMesDemandeAffectation);
            this.panel3.Location = new System.Drawing.Point(21, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1068, 438);
            this.panel3.TabIndex = 5;
            // 
            // dgridListeMesDemandeAffectation
            // 
            this.dgridListeMesDemandeAffectation.AllowUserToAddRows = false;
            this.dgridListeMesDemandeAffectation.AllowUserToDeleteRows = false;
            this.dgridListeMesDemandeAffectation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgridListeMesDemandeAffectation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridListeMesDemandeAffectation.Location = new System.Drawing.Point(1, 3);
            this.dgridListeMesDemandeAffectation.Name = "dgridListeMesDemandeAffectation";
            this.dgridListeMesDemandeAffectation.ReadOnly = true;
            this.dgridListeMesDemandeAffectation.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgridListeMesDemandeAffectation.Size = new System.Drawing.Size(1067, 435);
            this.dgridListeMesDemandeAffectation.TabIndex = 2;
            this.dgridListeMesDemandeAffectation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridListeMesDemandeAffectation_CellContentClick);


            this.dgridListeMesDemandeAffectation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridListeMesDemandeAffectation_CellClick);
            this.dgridListeMesDemandeAffectation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridListeMesDemandeAffectation_CellContentClick);
            this.dgridListeMesDemandeAffectation.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridListeMesDemandeAffectation_CellDoubleClick);
            this.dgridListeMesDemandeAffectation.VisibleChanged += new System.EventHandler(this.FenetrePrincipaleEmployeSimple_Load);

            // 
            // tabListePatrimoine
            // 
            this.tabListePatrimoine.Controls.Add(this.panel1);
            this.tabListePatrimoine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabListePatrimoine.Location = new System.Drawing.Point(4, 25);
            this.tabListePatrimoine.Name = "tabListePatrimoine";
            this.tabListePatrimoine.Padding = new System.Windows.Forms.Padding(3);
            this.tabListePatrimoine.Size = new System.Drawing.Size(1112, 441);
            this.tabListePatrimoine.TabIndex = 0;
            this.tabListePatrimoine.Text = "Liste des/mes équipements";
            this.tabListePatrimoine.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgridListePatrimoineEntreprise);
            this.panel1.Location = new System.Drawing.Point(22, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 432);
            this.panel1.TabIndex = 1;
            // 
            // dgridListePatrimoineEntreprise
            // 
            this.dgridListePatrimoineEntreprise.AllowUserToAddRows = false;
            this.dgridListePatrimoineEntreprise.AllowUserToDeleteRows = false;
            this.dgridListePatrimoineEntreprise.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgridListePatrimoineEntreprise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridListePatrimoineEntreprise.Location = new System.Drawing.Point(-1, -3);
            this.dgridListePatrimoineEntreprise.Name = "dgridListePatrimoineEntreprise";
            this.dgridListePatrimoineEntreprise.ReadOnly = true;
            this.dgridListePatrimoineEntreprise.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgridListePatrimoineEntreprise.Size = new System.Drawing.Size(1068, 432);
            this.dgridListePatrimoineEntreprise.TabIndex = 2;
            // 
            // btnFiltrerMesEquipements
            // 
            this.btnFiltrerMesEquipements.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrerMesEquipements.Location = new System.Drawing.Point(533, 658);
            this.btnFiltrerMesEquipements.Name = "btnFiltrerMesEquipements";
            this.btnFiltrerMesEquipements.Size = new System.Drawing.Size(163, 28);
            this.btnFiltrerMesEquipements.TabIndex = 0;
            this.btnFiltrerMesEquipements.Text = "Mes équipements";
            this.btnFiltrerMesEquipements.UseVisualStyleBackColor = true;
            this.btnFiltrerMesEquipements.Click += new System.EventHandler(this.btnFiltrerMesEquipements_Click);
            // 
            // lstTabsGestionPatrimoine
            // 
            this.lstTabsGestionPatrimoine.Controls.Add(this.tabListePatrimoine);
            this.lstTabsGestionPatrimoine.Controls.Add(this.tabDemandeAffectation);
            this.lstTabsGestionPatrimoine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTabsGestionPatrimoine.Location = new System.Drawing.Point(0, 182);
            this.lstTabsGestionPatrimoine.Name = "lstTabsGestionPatrimoine";
            this.lstTabsGestionPatrimoine.SelectedIndex = 0;
            this.lstTabsGestionPatrimoine.Size = new System.Drawing.Size(1120, 470);
            this.lstTabsGestionPatrimoine.TabIndex = 12;
            // 
            // btnListeToutLesEquipements
            // 
            this.btnListeToutLesEquipements.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListeToutLesEquipements.Location = new System.Drawing.Point(321, 658);
            this.btnListeToutLesEquipements.Name = "btnListeToutLesEquipements";
            this.btnListeToutLesEquipements.Size = new System.Drawing.Size(176, 28);
            this.btnListeToutLesEquipements.TabIndex = 2;
            this.btnListeToutLesEquipements.Text = "Tout les équipements";
            this.btnListeToutLesEquipements.UseVisualStyleBackColor = true;
            this.btnListeToutLesEquipements.Click += new System.EventHandler(this.btnListeToutLesEquipements_Click);
            // 
            // btnNouvelleDemandeAffectation
            // 
            this.btnNouvelleDemandeAffectation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouvelleDemandeAffectation.Location = new System.Drawing.Point(725, 658);
            this.btnNouvelleDemandeAffectation.Name = "btnNouvelleDemandeAffectation";
            this.btnNouvelleDemandeAffectation.Size = new System.Drawing.Size(230, 28);
            this.btnNouvelleDemandeAffectation.TabIndex = 15;
            this.btnNouvelleDemandeAffectation.Text = "nouvelle demande d\'équipement";
            this.btnNouvelleDemandeAffectation.UseVisualStyleBackColor = true;
            this.btnNouvelleDemandeAffectation.Click += new System.EventHandler(this.btnNouvelleDemandeAffectation_Click);
            // 
            // FenetrePrincipaleEmployeSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 709);
            this.Controls.Add(this.btnNouvelleDemandeAffectation);
            this.Controls.Add(this.btnListeToutLesEquipements);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnFiltrerMesEquipements);
            this.Controls.Add(this.lstTabsGestionPatrimoine);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FenetrePrincipaleEmployeSimple";
            this.Text = "FenetrePrincipaleEmployeSimple";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabDemandeAffectation.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgridListeMesDemandeAffectation)).EndInit();
            this.tabListePatrimoine.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgridListePatrimoineEntreprise)).EndInit();
            this.lstTabsGestionPatrimoine.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TabPage tabDemandeAffectation;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgridListeMesDemandeAffectation;
        private System.Windows.Forms.TabPage tabListePatrimoine;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgridListePatrimoineEntreprise;
        private System.Windows.Forms.Button btnFiltrerMesEquipements;
        private System.Windows.Forms.TabControl lstTabsGestionPatrimoine;
        private System.Windows.Forms.Button btnListeToutLesEquipements;
        private System.Windows.Forms.Button btnNouvelleDemandeAffectation;
    }
}