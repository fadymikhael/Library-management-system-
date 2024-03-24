namespace bibliothèque
{
    partial class Liste_Genres
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
            this.dgv_listegenres = new System.Windows.Forms.DataGridView();
            this.num_genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n_genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_affichergenre = new System.Windows.Forms.Button();
            this.btn_modifiergenre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listegenres)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_listegenres
            // 
            this.dgv_listegenres.AllowUserToAddRows = false;
            this.dgv_listegenres.AllowUserToDeleteRows = false;
            this.dgv_listegenres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listegenres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num_genre,
            this.n_genre});
            this.dgv_listegenres.Location = new System.Drawing.Point(12, 12);
            this.dgv_listegenres.MultiSelect = false;
            this.dgv_listegenres.Name = "dgv_listegenres";
            this.dgv_listegenres.ReadOnly = true;
            this.dgv_listegenres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_listegenres.Size = new System.Drawing.Size(246, 171);
            this.dgv_listegenres.TabIndex = 4;
            this.dgv_listegenres.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // num_genre
            // 
            this.num_genre.HeaderText = "Numéro";
            this.num_genre.Name = "num_genre";
            this.num_genre.ReadOnly = true;
            // 
            // n_genre
            // 
            this.n_genre.HeaderText = "Genres";
            this.n_genre.MinimumWidth = 7;
            this.n_genre.Name = "n_genre";
            this.n_genre.ReadOnly = true;
            // 
            // btn_affichergenre
            // 
            this.btn_affichergenre.Location = new System.Drawing.Point(354, 37);
            this.btn_affichergenre.Name = "btn_affichergenre";
            this.btn_affichergenre.Size = new System.Drawing.Size(75, 23);
            this.btn_affichergenre.TabIndex = 5;
            this.btn_affichergenre.Text = "Afficher";
            this.btn_affichergenre.UseVisualStyleBackColor = true;
            this.btn_affichergenre.Click += new System.EventHandler(this.btn_affichergenre_Click);
            // 
            // btn_modifiergenre
            // 
            this.btn_modifiergenre.Location = new System.Drawing.Point(354, 92);
            this.btn_modifiergenre.Name = "btn_modifiergenre";
            this.btn_modifiergenre.Size = new System.Drawing.Size(75, 23);
            this.btn_modifiergenre.TabIndex = 6;
            this.btn_modifiergenre.Text = "Modifier";
            this.btn_modifiergenre.UseVisualStyleBackColor = true;
            this.btn_modifiergenre.Click += new System.EventHandler(this.Btn_modifiergenre_Click);
            // 
            // Liste_Genres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 226);
            this.Controls.Add(this.btn_modifiergenre);
            this.Controls.Add(this.btn_affichergenre);
            this.Controls.Add(this.dgv_listegenres);
            this.Name = "Liste_Genres";
            this.Text = "Liste de Genres";
            this.Load += new System.EventHandler(this.Liste_Genres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listegenres)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_listegenres;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn n_genre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_affichergenre;
        private System.Windows.Forms.Button btn_modifiergenre;
    }
}