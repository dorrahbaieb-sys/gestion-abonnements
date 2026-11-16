namespace gestion_abonnements
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;

        // Onglet 1 : Catégories
        private Label lblNomCategorie;
        private TextBox txtNomCategorie;
        private Button btnAjouterCat;
        private Button btnModifierCat;
        private Button btnSupprimerCat;
        private DataGridView dgvCategories;

        // Onglet 2 : Abonnements
        private Label lblNomService;
        private TextBox txtNomService;
        private Label lblMontant;
        private NumericUpDown numMontant;
        private Label lblPeriodicite;
        private ComboBox cmbPeriodicite;
        private Label lblDebut;
        private DateTimePicker dtpDebut;
        private Label lblRenouvellement;
        private DateTimePicker dtpRenouvellement;
        private Label lblStatut;
        private ComboBox cmbStatut;
        private Label lblCategorie;
        private ComboBox cmbCategorie;
        private Button btnAjouterAbo;
        private Button btnModifierAbo;
        private Button btnSupprimerAbo;
        private DataGridView dgvAbonnements;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            lblNomCategorie = new Label();
            txtNomCategorie = new TextBox();
            btnAjouterCat = new Button();
            btnModifierCat = new Button();
            btnSupprimerCat = new Button();
            dgvCategories = new DataGridView();
            tabPage2 = new TabPage();
            lblNomService = new Label();
            txtNomService = new TextBox();
            lblMontant = new Label();
            numMontant = new NumericUpDown();
            lblPeriodicite = new Label();
            cmbPeriodicite = new ComboBox();
            lblDebut = new Label();
            dtpDebut = new DateTimePicker();
            lblRenouvellement = new Label();
            dtpRenouvellement = new DateTimePicker();
            lblStatut = new Label();
            cmbStatut = new ComboBox();
            lblCategorie = new Label();
            cmbCategorie = new ComboBox();
            btnAjouterAbo = new Button();
            btnModifierAbo = new Button();
            btnSupprimerAbo = new Button();
            dgvAbonnements = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMontant).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAbonnements).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(920, 560);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lblNomCategorie);
            tabPage1.Controls.Add(txtNomCategorie);
            tabPage1.Controls.Add(btnAjouterCat);
            tabPage1.Controls.Add(btnModifierCat);
            tabPage1.Controls.Add(btnSupprimerCat);
            tabPage1.Controls.Add(dgvCategories);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(912, 527);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Gestion des Catégories";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblNomCategorie
            // 
            lblNomCategorie.AutoSize = true;
            lblNomCategorie.Location = new Point(25, 28);
            lblNomCategorie.Name = "lblNomCategorie";
            lblNomCategorie.Size = new Size(153, 20);
            lblNomCategorie.TabIndex = 0;
            lblNomCategorie.Text = "Nom de la catégorie :";
            // 
            // txtNomCategorie
            // 
            txtNomCategorie.Location = new Point(170, 25);
            txtNomCategorie.Name = "txtNomCategorie";
            txtNomCategorie.Size = new Size(250, 27);
            txtNomCategorie.TabIndex = 0;
            txtNomCategorie.TextChanged += txtNomCategorie_TextChanged;
            // 
            // btnAjouterCat
            // 
            btnAjouterCat.Location = new Point(445, 23);
            btnAjouterCat.Name = "btnAjouterCat";
            btnAjouterCat.Size = new Size(110, 30);
            btnAjouterCat.TabIndex = 1;
            btnAjouterCat.Text = "Ajouter";
            btnAjouterCat.UseVisualStyleBackColor = true;
            // 
            // btnModifierCat
            // 
            btnModifierCat.Location = new Point(570, 23);
            btnModifierCat.Name = "btnModifierCat";
            btnModifierCat.Size = new Size(110, 30);
            btnModifierCat.TabIndex = 2;
            btnModifierCat.Text = "Modifier";
            btnModifierCat.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerCat
            // 
            btnSupprimerCat.Location = new Point(695, 23);
            btnSupprimerCat.Name = "btnSupprimerCat";
            btnSupprimerCat.Size = new Size(110, 30);
            btnSupprimerCat.TabIndex = 3;
            btnSupprimerCat.Text = "Supprimer";
            btnSupprimerCat.UseVisualStyleBackColor = true;
            // 
            // dgvCategories
            // 
            dgvCategories.AllowUserToAddRows = false;
            dgvCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Location = new Point(25, 75);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.ReadOnly = true;
            dgvCategories.RowHeadersWidth = 51;
            dgvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategories.Size = new Size(860, 425);
            dgvCategories.TabIndex = 4;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lblNomService);
            tabPage2.Controls.Add(txtNomService);
            tabPage2.Controls.Add(lblMontant);
            tabPage2.Controls.Add(numMontant);
            tabPage2.Controls.Add(lblPeriodicite);
            tabPage2.Controls.Add(cmbPeriodicite);
            tabPage2.Controls.Add(lblDebut);
            tabPage2.Controls.Add(dtpDebut);
            tabPage2.Controls.Add(lblRenouvellement);
            tabPage2.Controls.Add(dtpRenouvellement);
            tabPage2.Controls.Add(lblStatut);
            tabPage2.Controls.Add(cmbStatut);
            tabPage2.Controls.Add(lblCategorie);
            tabPage2.Controls.Add(cmbCategorie);
            tabPage2.Controls.Add(btnAjouterAbo);
            tabPage2.Controls.Add(btnModifierAbo);
            tabPage2.Controls.Add(btnSupprimerAbo);
            tabPage2.Controls.Add(dgvAbonnements);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(912, 527);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Gestion des Abonnements";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblNomService
            // 
            lblNomService.AutoSize = true;
            lblNomService.Location = new Point(20, 22);
            lblNomService.Name = "lblNomService";
            lblNomService.Size = new Size(63, 20);
            lblNomService.TabIndex = 0;
            lblNomService.Text = "Service :";
            // 
            // txtNomService
            // 
            txtNomService.Location = new Point(100, 19);
            txtNomService.Name = "txtNomService";
            txtNomService.Size = new Size(180, 27);
            txtNomService.TabIndex = 0;
            // 
            // lblMontant
            // 
            lblMontant.AutoSize = true;
            lblMontant.Location = new Point(305, 22);
            lblMontant.Name = "lblMontant";
            lblMontant.Size = new Size(72, 20);
            lblMontant.TabIndex = 1;
            lblMontant.Text = "Montant :";
            // 
            // numMontant
            // 
            numMontant.DecimalPlaces = 3;
            numMontant.Location = new Point(385, 19);
            numMontant.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numMontant.Name = "numMontant";
            numMontant.Size = new Size(120, 27);
            numMontant.TabIndex = 1;
            // 
            // lblPeriodicite
            // 
            lblPeriodicite.AutoSize = true;
            lblPeriodicite.Location = new Point(530, 22);
            lblPeriodicite.Name = "lblPeriodicite";
            lblPeriodicite.Size = new Size(86, 20);
            lblPeriodicite.TabIndex = 2;
            lblPeriodicite.Text = "Périodicité :";
            // 
            // cmbPeriodicite
            // 
            cmbPeriodicite.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPeriodicite.FormattingEnabled = true;
            cmbPeriodicite.Items.AddRange(new object[] { "Mensuel", "Annuel", "Trimestriel" });
            cmbPeriodicite.Location = new Point(625, 19);
            cmbPeriodicite.Name = "cmbPeriodicite";
            cmbPeriodicite.Size = new Size(160, 28);
            cmbPeriodicite.TabIndex = 2;
            // 
            // lblDebut
            // 
            lblDebut.AutoSize = true;
            lblDebut.Location = new Point(20, 62);
            lblDebut.Name = "lblDebut";
            lblDebut.Size = new Size(91, 20);
            lblDebut.TabIndex = 3;
            lblDebut.Text = "Date début :";
            // 
            // dtpDebut
            // 
            dtpDebut.Format = DateTimePickerFormat.Short;
            dtpDebut.Location = new Point(110, 59);
            dtpDebut.Name = "dtpDebut";
            dtpDebut.Size = new Size(140, 27);
            dtpDebut.TabIndex = 3;
            // 
            // lblRenouvellement
            // 
            lblRenouvellement.AutoSize = true;
            lblRenouvellement.Location = new Point(275, 62);
            lblRenouvellement.Name = "lblRenouvellement";
            lblRenouvellement.Size = new Size(180, 20);
            lblRenouvellement.TabIndex = 4;
            lblRenouvellement.Text = "Prochain renouvellement :";
            // 
            // dtpRenouvellement
            // 
            dtpRenouvellement.Format = DateTimePickerFormat.Short;
            dtpRenouvellement.Location = new Point(455, 59);
            dtpRenouvellement.Name = "dtpRenouvellement";
            dtpRenouvellement.Size = new Size(140, 27);
            dtpRenouvellement.TabIndex = 4;
            // 
            // lblStatut
            // 
            lblStatut.AutoSize = true;
            lblStatut.Location = new Point(20, 102);
            lblStatut.Name = "lblStatut";
            lblStatut.Size = new Size(55, 20);
            lblStatut.TabIndex = 5;
            lblStatut.Text = "Statut :";
            // 
            // cmbStatut
            // 
            cmbStatut.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatut.FormattingEnabled = true;
            cmbStatut.Items.AddRange(new object[] { "Actif", "Résilié", "En pause" });
            cmbStatut.Location = new Point(100, 99);
            cmbStatut.Name = "cmbStatut";
            cmbStatut.Size = new Size(150, 28);
            cmbStatut.TabIndex = 5;
            // 
            // lblCategorie
            // 
            lblCategorie.AutoSize = true;
            lblCategorie.Location = new Point(275, 102);
            lblCategorie.Name = "lblCategorie";
            lblCategorie.Size = new Size(81, 20);
            lblCategorie.TabIndex = 6;
            lblCategorie.Text = "Catégorie :";
            // 
            // cmbCategorie
            // 
            cmbCategorie.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategorie.FormattingEnabled = true;
            cmbCategorie.Location = new Point(365, 99);
            cmbCategorie.Name = "cmbCategorie";
            cmbCategorie.Size = new Size(200, 28);
            cmbCategorie.TabIndex = 6;
            // 
            // btnAjouterAbo
            // 
            btnAjouterAbo.Location = new Point(20, 142);
            btnAjouterAbo.Name = "btnAjouterAbo";
            btnAjouterAbo.Size = new Size(120, 30);
            btnAjouterAbo.TabIndex = 7;
            btnAjouterAbo.Text = "Ajouter";
            btnAjouterAbo.UseVisualStyleBackColor = true;
            // 
            // btnModifierAbo
            // 
            btnModifierAbo.Location = new Point(155, 142);
            btnModifierAbo.Name = "btnModifierAbo";
            btnModifierAbo.Size = new Size(120, 30);
            btnModifierAbo.TabIndex = 8;
            btnModifierAbo.Text = "Modifier";
            btnModifierAbo.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerAbo
            // 
            btnSupprimerAbo.Location = new Point(290, 142);
            btnSupprimerAbo.Name = "btnSupprimerAbo";
            btnSupprimerAbo.Size = new Size(120, 30);
            btnSupprimerAbo.TabIndex = 9;
            btnSupprimerAbo.Text = "Supprimer";
            btnSupprimerAbo.UseVisualStyleBackColor = true;
            // 
            // dgvAbonnements
            // 
            dgvAbonnements.AllowUserToAddRows = false;
            dgvAbonnements.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAbonnements.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAbonnements.Location = new Point(20, 185);
            dgvAbonnements.Name = "dgvAbonnements";
            dgvAbonnements.ReadOnly = true;
            dgvAbonnements.RowHeadersWidth = 51;
            dgvAbonnements.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAbonnements.Size = new Size(870, 320);
            dgvAbonnements.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 560);
            Controls.Add(tabControl1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion des Abonnements";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMontant).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAbonnements).EndInit();
            ResumeLayout(false);
        }
    }
}
