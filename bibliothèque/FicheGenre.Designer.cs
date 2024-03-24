namespace bibliothèque
{
    partial class FicheGenre
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
            this.num_genre = new System.Windows.Forms.Label();
            this.nom_genre = new System.Windows.Forms.Label();
            this.txt_numgenre = new System.Windows.Forms.TextBox();
            this.txt_genre = new System.Windows.Forms.TextBox();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_valider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // num_genre
            // 
            this.num_genre.AutoSize = true;
            this.num_genre.Location = new System.Drawing.Point(58, 25);
            this.num_genre.Name = "num_genre";
            this.num_genre.Size = new System.Drawing.Size(44, 13);
            this.num_genre.TabIndex = 0;
            this.num_genre.Text = "Numéro";
            // 
            // nom_genre
            // 
            this.nom_genre.AutoSize = true;
            this.nom_genre.Location = new System.Drawing.Point(58, 63);
            this.nom_genre.Name = "nom_genre";
            this.nom_genre.Size = new System.Drawing.Size(36, 13);
            this.nom_genre.TabIndex = 1;
            this.nom_genre.Text = "Genre";
            // 
            // txt_numgenre
            // 
            this.txt_numgenre.Enabled = false;
            this.txt_numgenre.Location = new System.Drawing.Point(187, 25);
            this.txt_numgenre.Name = "txt_numgenre";
            this.txt_numgenre.Size = new System.Drawing.Size(100, 20);
            this.txt_numgenre.TabIndex = 2;
            // 
            // txt_genre
            // 
            this.txt_genre.Enabled = false;
            this.txt_genre.Location = new System.Drawing.Point(187, 60);
            this.txt_genre.Name = "txt_genre";
            this.txt_genre.Size = new System.Drawing.Size(100, 20);
            this.txt_genre.TabIndex = 3;
            // 
            // btn_annuler
            // 
            this.btn_annuler.Location = new System.Drawing.Point(27, 150);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(75, 23);
            this.btn_annuler.TabIndex = 4;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.Btn_annuler_Click);
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(208, 150);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(75, 23);
            this.btn_valider.TabIndex = 5;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.Btn_valider_Click);
            // 
            // FicheGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 204);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.txt_genre);
            this.Controls.Add(this.txt_numgenre);
            this.Controls.Add(this.nom_genre);
            this.Controls.Add(this.num_genre);
            this.Name = "FicheGenre";
            this.Text = "Fiche Genre";
            this.Load += new System.EventHandler(this.FicheGenre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label num_genre;
        private System.Windows.Forms.Label nom_genre;
        private System.Windows.Forms.TextBox txt_numgenre;
        private System.Windows.Forms.TextBox txt_genre;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_valider;
    }
}