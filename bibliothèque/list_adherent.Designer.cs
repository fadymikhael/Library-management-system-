namespace bibliothèque
{
    partial class list_adherent
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
            this.dgv_list_aderent = new System.Windows.Forms.DataGridView();
            this.num_ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom_ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adr_ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cp_ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ville_ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel_ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail_ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list_aderent)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_list_aderent
            // 
            this.dgv_list_aderent.AllowUserToAddRows = false;
            this.dgv_list_aderent.AllowUserToDeleteRows = false;
            this.dgv_list_aderent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_list_aderent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num_ad,
            this.nom_ad,
            this.prenom_ad,
            this.adr_ad,
            this.cp_ad,
            this.ville_ad,
            this.tel_ad,
            this.mail_ad});
            this.dgv_list_aderent.Location = new System.Drawing.Point(12, 12);
            this.dgv_list_aderent.Name = "dgv_list_aderent";
            this.dgv_list_aderent.ReadOnly = true;
            this.dgv_list_aderent.Size = new System.Drawing.Size(819, 188);
            this.dgv_list_aderent.TabIndex = 0;
            this.dgv_list_aderent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // num_ad
            // 
            this.num_ad.FillWeight = 50F;
            this.num_ad.HeaderText = "Numéro";
            this.num_ad.Name = "num_ad";
            this.num_ad.ReadOnly = true;
            this.num_ad.Width = 50;
            // 
            // nom_ad
            // 
            this.nom_ad.HeaderText = "Nom";
            this.nom_ad.Name = "nom_ad";
            this.nom_ad.ReadOnly = true;
            // 
            // prenom_ad
            // 
            this.prenom_ad.HeaderText = "Prénom";
            this.prenom_ad.Name = "prenom_ad";
            this.prenom_ad.ReadOnly = true;
            // 
            // adr_ad
            // 
            this.adr_ad.HeaderText = "Adresse";
            this.adr_ad.Name = "adr_ad";
            this.adr_ad.ReadOnly = true;
            // 
            // cp_ad
            // 
            this.cp_ad.HeaderText = "Code postal";
            this.cp_ad.Name = "cp_ad";
            this.cp_ad.ReadOnly = true;
            // 
            // ville_ad
            // 
            this.ville_ad.HeaderText = "Ville";
            this.ville_ad.Name = "ville_ad";
            this.ville_ad.ReadOnly = true;
            // 
            // tel_ad
            // 
            this.tel_ad.HeaderText = "Tel";
            this.tel_ad.Name = "tel_ad";
            this.tel_ad.ReadOnly = true;
            // 
            // mail_ad
            // 
            this.mail_ad.HeaderText = "Mail";
            this.mail_ad.Name = "mail_ad";
            this.mail_ad.ReadOnly = true;
            // 
            // list_adherent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 287);
            this.Controls.Add(this.dgv_list_aderent);
            this.Name = "list_adherent";
            this.Text = "list_adherent";
            this.Load += new System.EventHandler(this.List_adherent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list_aderent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_list_aderent;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom_ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn adr_ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cp_ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ville_ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel_ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail_ad;
    }
}