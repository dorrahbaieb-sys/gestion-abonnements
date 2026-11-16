using gestion_abonnements.Models;
using Microsoft.EntityFrameworkCore;

namespace gestion_abonnements
{
    public partial class Form1 : Form
    {
        private int _selectedCatId = 0;
        private int _selectedAboId = 0;

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;

            // Événements Catégories
            btnAjouterCat.Click += BtnAjouterCat_Click;
            btnModifierCat.Click += BtnModifierCat_Click;
            btnSupprimerCat.Click += BtnSupprimerCat_Click;
            dgvCategories.CellClick += DgvCategories_CellClick;

            // Événements Abonnements
            btnAjouterAbo.Click += BtnAjouterAbo_Click;
            btnModifierAbo.Click += BtnModifierAbo_Click;
            btnSupprimerAbo.Click += BtnSupprimerAbo_Click;
            dgvAbonnements.CellClick += DgvAbonnements_CellClick;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            ChargerCategories();
            ChargerAbonnements();
        }

        // ==================== GESTION DES CATÉGORIES ====================

        private void ChargerCategories()
        {
            using var db = new AppDbContext();
            var liste = db.Categories
                          .Select(c => new { c.Id, c.Nom })
                          .ToList();

            dgvCategories.DataSource = liste;

            // Alimente aussi la liste déroulante de l'onglet Abonnements
            cmbCategorie.DataSource = db.Categories.ToList();
            cmbCategorie.DisplayMember = "Nom";
            cmbCategorie.ValueMember = "Id";
        }

        private void DgvCategories_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _selectedCatId = Convert.ToInt32(dgvCategories.Rows[e.RowIndex].Cells["Id"].Value);
                txtNomCategorie.Text = dgvCategories.Rows[e.RowIndex].Cells["Nom"].Value?.ToString();
            }
        }

        private void BtnAjouterCat_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomCategorie.Text)) return;

            using var db = new AppDbContext();
            db.Categories.Add(new Categorie { Nom = txtNomCategorie.Text.Trim() });
            db.SaveChanges();

            txtNomCategorie.Clear();
            ChargerCategories();
        }

        private void BtnModifierCat_Click(object? sender, EventArgs e)
        {
            if (_selectedCatId == 0 || string.IsNullOrWhiteSpace(txtNomCategorie.Text)) return;

            using var db = new AppDbContext();
            var cat = db.Categories.Find(_selectedCatId);
            if (cat != null)
            {
                cat.Nom = txtNomCategorie.Text.Trim();
                db.SaveChanges();
            }

            _selectedCatId = 0;
            txtNomCategorie.Clear();
            ChargerCategories();
            ChargerAbonnements();
        }

        private void BtnSupprimerCat_Click(object? sender, EventArgs e)
        {
            if (_selectedCatId == 0) return;

            using var db = new AppDbContext();
            var cat = db.Categories.Find(_selectedCatId);
            if (cat != null)
            {
                db.Categories.Remove(cat);
                db.SaveChanges();
            }

            _selectedCatId = 0;
            txtNomCategorie.Clear();
            ChargerCategories();
        }

        // ==================== GESTION DES ABONNEMENTS ====================

        private void ChargerAbonnements()
        {
            using var db = new AppDbContext();
            var liste = db.Abonnements
                          .Include(a => a.Categorie)
                          .Select(a => new
                          {
                              a.Id,
                              a.NomService,
                              a.Montant,
                              a.Periodicite,
                              a.DateDebut,
                              a.DateProchainRenouvellement,
                              a.Statut,
                              Categorie = a.Categorie != null ? a.Categorie.Nom : "",
                              a.CategorieId
                          })
                          .ToList();

            dgvAbonnements.DataSource = liste;
        }

        private void DgvAbonnements_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvAbonnements.Rows[e.RowIndex];
                _selectedAboId = Convert.ToInt32(row.Cells["Id"].Value);
                txtNomService.Text = row.Cells["NomService"].Value?.ToString();
                numMontant.Value = Convert.ToDecimal(row.Cells["Montant"].Value);
                cmbPeriodicite.Text = row.Cells["Periodicite"].Value?.ToString();
                dtpDebut.Value = Convert.ToDateTime(row.Cells["DateDebut"].Value);
                dtpRenouvellement.Value = Convert.ToDateTime(row.Cells["DateProchainRenouvellement"].Value);
                cmbStatut.Text = row.Cells["Statut"].Value?.ToString();
                cmbCategorie.SelectedValue = Convert.ToInt32(row.Cells["CategorieId"].Value);
            }
        }

        private void BtnAjouterAbo_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomService.Text) || cmbCategorie.SelectedValue == null) return;

            using var db = new AppDbContext();
            var abo = new Abonnement
            {
                NomService = txtNomService.Text.Trim(),
                Montant = numMontant.Value,
                Periodicite = cmbPeriodicite.Text,
                DateDebut = dtpDebut.Value,
                DateProchainRenouvellement = dtpRenouvellement.Value,
                Statut = cmbStatut.Text,
                CategorieId = (int)cmbCategorie.SelectedValue
            };

            db.Abonnements.Add(abo);
            db.SaveChanges();
            ChargerAbonnements();
        }

        private void BtnModifierAbo_Click(object? sender, EventArgs e)
        {
            if (_selectedAboId == 0 || cmbCategorie.SelectedValue == null) return;

            using var db = new AppDbContext();
            var abo = db.Abonnements.Find(_selectedAboId);
            if (abo != null)
            {
                abo.NomService = txtNomService.Text.Trim();
                abo.Montant = numMontant.Value;
                abo.Periodicite = cmbPeriodicite.Text;
                abo.DateDebut = dtpDebut.Value;
                abo.DateProchainRenouvellement = dtpRenouvellement.Value;
                abo.Statut = cmbStatut.Text;
                abo.CategorieId = (int)cmbCategorie.SelectedValue;
                db.SaveChanges();
            }

            _selectedAboId = 0;
            ChargerAbonnements();
        }

        private void BtnSupprimerAbo_Click(object? sender, EventArgs e)
        {
            if (_selectedAboId == 0) return;

            using var db = new AppDbContext();
            var abo = db.Abonnements.Find(_selectedAboId);
            if (abo != null)
            {
                db.Abonnements.Remove(abo);
                db.SaveChanges();
            }

            _selectedAboId = 0;
            ChargerAbonnements();
        }

        private void txtNomCategorie_TextChanged(object sender, EventArgs e)
        {

        }
    }
}