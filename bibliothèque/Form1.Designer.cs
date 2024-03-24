namespace bibliothèque
{
    partial class Form_LiseAuteurs
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_listeAuteurs = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_affiche = new System.Windows.Forms.Button();
            this.btn_modifiction = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_nouveau = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listeAuteurs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_listeAuteurs
            // 
            this.dgv_listeAuteurs.AllowUserToAddRows = false;
            this.dgv_listeAuteurs.AllowUserToDeleteRows = false;
            this.dgv_listeAuteurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listeAuteurs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.Nom,
            this.Prenom,
            this.Nation});
            this.dgv_listeAuteurs.Location = new System.Drawing.Point(12, 12);
            this.dgv_listeAuteurs.MultiSelect = false;
            this.dgv_listeAuteurs.Name = "dgv_listeAuteurs";
            this.dgv_listeAuteurs.ReadOnly = true;
            this.dgv_listeAuteurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_listeAuteurs.Size = new System.Drawing.Size(450, 216);
            this.dgv_listeAuteurs.TabIndex = 0;
            this.dgv_listeAuteurs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_listeAuteurs_CellContentClick);
            // 
            // Num
            // 
            this.Num.HeaderText = "Numéro";
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Prenom
            // 
            this.Prenom.HeaderText = "Prénom";
            this.Prenom.Name = "Prenom";
            this.Prenom.ReadOnly = true;
            // 
            // Nation
            // 
            this.Nation.HeaderText = "Nationalité";
            this.Nation.Name = "Nation";
            this.Nation.ReadOnly = true;
            // 
            // btn_affiche
            // 
            this.btn_affiche.Location = new System.Drawing.Point(468, 12);
            this.btn_affiche.Name = "btn_affiche";
            this.btn_affiche.Size = new System.Drawing.Size(75, 23);
            this.btn_affiche.TabIndex = 1;
            this.btn_affiche.Text = "Afficher";
            this.btn_affiche.UseVisualStyleBackColor = true;
            this.btn_affiche.Click += new System.EventHandler(this.btn_affiche_Click);
            // 
            // btn_modifiction
            // 
            this.btn_modifiction.Location = new System.Drawing.Point(469, 42);
            this.btn_modifiction.Name = "btn_modifiction";
            this.btn_modifiction.Size = new System.Drawing.Size(75, 23);
            this.btn_modifiction.TabIndex = 2;
            this.btn_modifiction.Text = "Modifier";
            this.btn_modifiction.UseVisualStyleBackColor = true;
            this.btn_modifiction.Click += new System.EventHandler(this.btn_modifiction_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Location = new System.Drawing.Point(469, 72);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(75, 23);
            this.btn_supprimer.TabIndex = 3;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_nouveau
            // 
            this.btn_nouveau.Location = new System.Drawing.Point(469, 102);
            this.btn_nouveau.Name = "btn_nouveau";
            this.btn_nouveau.Size = new System.Drawing.Size(75, 23);
            this.btn_nouveau.TabIndex = 4;
            this.btn_nouveau.Text = "Nouveau";
            this.btn_nouveau.UseVisualStyleBackColor = true;
            // 
            // Form_LiseAuteurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_nouveau);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_modifiction);
            this.Controls.Add(this.btn_affiche);
            this.Controls.Add(this.dgv_listeAuteurs);
            this.Name = "Form_LiseAuteurs";
            this.Text = "Liste des Auteurs";
            this.Load += new System.EventHandler(this.Form_LiseAuteurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listeAuteurs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_listeAuteurs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nation;
        private System.Windows.Forms.Button btn_affiche;
        private System.Windows.Forms.Button btn_modifiction;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_nouveau;
    }
}

