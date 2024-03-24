namespace bibliothèque
{
    partial class liste_livres
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
            this.dgv_listelivres = new System.Windows.Forms.DataGridView();
            this.num_livre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN_livre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titre_livre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix_livre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editeur_livre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.annee_livre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.langue_livre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_auteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listelivres)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_listelivres
            // 
            this.dgv_listelivres.AllowUserToAddRows = false;
            this.dgv_listelivres.AllowUserToDeleteRows = false;
            this.dgv_listelivres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listelivres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num_livre,
            this.ISBN_livre,
            this.titre_livre,
            this.prix_livre,
            this.editeur_livre,
            this.annee_livre,
            this.langue_livre,
            this.num_auteur,
            this.num_genre});
            this.dgv_listelivres.Location = new System.Drawing.Point(12, 1);
            this.dgv_listelivres.Name = "dgv_listelivres";
            this.dgv_listelivres.ReadOnly = true;
            this.dgv_listelivres.Size = new System.Drawing.Size(738, 150);
            this.dgv_listelivres.TabIndex = 0;
            this.dgv_listelivres.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_liste_livres_CellContentClick);
            // 
            // num_livre
            // 
            this.num_livre.HeaderText = "Numéro";
            this.num_livre.Name = "num_livre";
            this.num_livre.ReadOnly = true;
            this.num_livre.Width = 70;
            // 
            // ISBN_livre
            // 
            this.ISBN_livre.HeaderText = "ISBN";
            this.ISBN_livre.Name = "ISBN_livre";
            this.ISBN_livre.ReadOnly = true;
            // 
            // titre_livre
            // 
            this.titre_livre.HeaderText = "Titre";
            this.titre_livre.Name = "titre_livre";
            this.titre_livre.ReadOnly = true;
            // 
            // prix_livre
            // 
            this.prix_livre.HeaderText = "Prix";
            this.prix_livre.Name = "prix_livre";
            this.prix_livre.ReadOnly = true;
            // 
            // editeur_livre
            // 
            this.editeur_livre.HeaderText = "Editeur";
            this.editeur_livre.Name = "editeur_livre";
            this.editeur_livre.ReadOnly = true;
            // 
            // annee_livre
            // 
            this.annee_livre.HeaderText = "Année";
            this.annee_livre.Name = "annee_livre";
            this.annee_livre.ReadOnly = true;
            // 
            // langue_livre
            // 
            this.langue_livre.HeaderText = "Langue";
            this.langue_livre.Name = "langue_livre";
            this.langue_livre.ReadOnly = true;
            // 
            // num_auteur
            // 
            this.num_auteur.HeaderText = "Numéro de Auteur";
            this.num_auteur.Name = "num_auteur";
            this.num_auteur.ReadOnly = true;
            // 
            // num_genre
            // 
            this.num_genre.HeaderText = "Numéro de Genre";
            this.num_genre.Name = "num_genre";
            this.num_genre.ReadOnly = true;
            // 
            // liste_livres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 241);
            this.Controls.Add(this.dgv_listelivres);
            this.Name = "liste_livres";
            this.Text = "Liste de Livres";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listelivres)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_listelivres;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_livre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN_livre;
        private System.Windows.Forms.DataGridViewTextBoxColumn titre_livre;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix_livre;
        private System.Windows.Forms.DataGridViewTextBoxColumn editeur_livre;
        private System.Windows.Forms.DataGridViewTextBoxColumn annee_livre;
        private System.Windows.Forms.DataGridViewTextBoxColumn langue_livre;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_auteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_genre;
    }
}