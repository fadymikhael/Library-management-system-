namespace bibliothèque
{
    partial class liste_pret
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
            this.dgv_liste_pret = new System.Windows.Forms.DataGridView();
            this.num_pret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_Livre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_adherent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_pret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_retour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_retour_reelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_liste_pret)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_liste_pret
            // 
            this.dgv_liste_pret.AllowUserToAddRows = false;
            this.dgv_liste_pret.AllowUserToDeleteRows = false;
            this.dgv_liste_pret.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_liste_pret.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num_pret,
            this.num_Livre,
            this.num_adherent,
            this.date_pret,
            this.date_retour,
            this.date_retour_reelle});
            this.dgv_liste_pret.Location = new System.Drawing.Point(35, 12);
            this.dgv_liste_pret.Name = "dgv_liste_pret";
            this.dgv_liste_pret.ReadOnly = true;
            this.dgv_liste_pret.Size = new System.Drawing.Size(656, 150);
            this.dgv_liste_pret.TabIndex = 0;
            this.dgv_liste_pret.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // num_pret
            // 
            this.num_pret.HeaderText = "Numéro";
            this.num_pret.Name = "num_pret";
            this.num_pret.ReadOnly = true;
            // 
            // num_Livre
            // 
            this.num_Livre.HeaderText = "Numéro de livre";
            this.num_Livre.Name = "num_Livre";
            this.num_Livre.ReadOnly = true;
            // 
            // num_adherent
            // 
            this.num_adherent.HeaderText = "Numéro d\'dherent";
            this.num_adherent.Name = "num_adherent";
            this.num_adherent.ReadOnly = true;
            // 
            // date_pret
            // 
            this.date_pret.HeaderText = "Date de Prét";
            this.date_pret.Name = "date_pret";
            this.date_pret.ReadOnly = true;
            // 
            // date_retour
            // 
            this.date_retour.HeaderText = "Date de retour Prévue";
            this.date_retour.Name = "date_retour";
            this.date_retour.ReadOnly = true;
            // 
            // date_retour_reelle
            // 
            this.date_retour_reelle.HeaderText = "Date de retour réelle";
            this.date_retour_reelle.Name = "date_retour_reelle";
            this.date_retour_reelle.ReadOnly = true;
            // 
            // liste_pret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 271);
            this.Controls.Add(this.dgv_liste_pret);
            this.Name = "liste_pret";
            this.Text = "Prets";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_liste_pret)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_liste_pret;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_pret;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_Livre;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_adherent;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_pret;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_retour;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_retour_reelle;
    }
}