namespace bibliothèque
{
    partial class FicheAuteur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FicheAuteur));
            this.txt_num = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.txt_nationalite = new System.Windows.Forms.TextBox();
            this.lab_num = new System.Windows.Forms.Label();
            this.lab_nom = new System.Windows.Forms.Label();
            this.lab_prenom = new System.Windows.Forms.Label();
            this.lab_nationalite = new System.Windows.Forms.Label();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_valider = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_num
            // 
            this.txt_num.Enabled = false;
            this.txt_num.Location = new System.Drawing.Point(100, 28);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(100, 20);
            this.txt_num.TabIndex = 0;
            this.txt_num.TextChanged += new System.EventHandler(this.Txt_num_TextChanged);
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(100, 66);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(100, 20);
            this.txt_nom.TabIndex = 1;
            this.txt_nom.TextChanged += new System.EventHandler(this.Txt_nom_TextChanged);
            // 
            // txt_prenom
            // 
            this.txt_prenom.Location = new System.Drawing.Point(100, 108);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(100, 20);
            this.txt_prenom.TabIndex = 2;
            // 
            // txt_nationalite
            // 
            this.txt_nationalite.Location = new System.Drawing.Point(100, 144);
            this.txt_nationalite.Name = "txt_nationalite";
            this.txt_nationalite.Size = new System.Drawing.Size(100, 20);
            this.txt_nationalite.TabIndex = 3;
            // 
            // lab_num
            // 
            this.lab_num.AutoSize = true;
            this.lab_num.Location = new System.Drawing.Point(34, 28);
            this.lab_num.Name = "lab_num";
            this.lab_num.Size = new System.Drawing.Size(44, 13);
            this.lab_num.TabIndex = 4;
            this.lab_num.Text = "Numéro";
            this.lab_num.Click += new System.EventHandler(this.Lab_num_Click);
            // 
            // lab_nom
            // 
            this.lab_nom.AutoSize = true;
            this.lab_nom.Location = new System.Drawing.Point(31, 66);
            this.lab_nom.Name = "lab_nom";
            this.lab_nom.Size = new System.Drawing.Size(29, 13);
            this.lab_nom.TabIndex = 5;
            this.lab_nom.Text = "Nom";
            // 
            // lab_prenom
            // 
            this.lab_prenom.AutoSize = true;
            this.lab_prenom.Location = new System.Drawing.Point(31, 108);
            this.lab_prenom.Name = "lab_prenom";
            this.lab_prenom.Size = new System.Drawing.Size(43, 13);
            this.lab_prenom.TabIndex = 6;
            this.lab_prenom.Text = "Prénom";
            this.lab_prenom.Click += new System.EventHandler(this.Lab_prenom_Click);
            // 
            // lab_nationalite
            // 
            this.lab_nationalite.AutoSize = true;
            this.lab_nationalite.Location = new System.Drawing.Point(34, 144);
            this.lab_nationalite.Name = "lab_nationalite";
            this.lab_nationalite.Size = new System.Drawing.Size(57, 13);
            this.lab_nationalite.TabIndex = 7;
            this.lab_nationalite.Text = "Nationalité";
            this.lab_nationalite.Click += new System.EventHandler(this.Label4_Click);
            // 
            // btn_annuler
            // 
            this.btn_annuler.Location = new System.Drawing.Point(77, 183);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(75, 23);
            this.btn_annuler.TabIndex = 8;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.Btn_annuler_Click);
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(177, 183);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(75, 23);
            this.btn_valider.TabIndex = 9;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(292, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // FicheAuteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 218);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.lab_nationalite);
            this.Controls.Add(this.lab_prenom);
            this.Controls.Add(this.lab_nom);
            this.Controls.Add(this.lab_num);
            this.Controls.Add(this.txt_nationalite);
            this.Controls.Add(this.txt_prenom);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.txt_num);
            this.Name = "FicheAuteur";
            this.Text = "Fiche Auteur";
            this.Load += new System.EventHandler(this.FicheAuteur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.TextBox txt_nationalite;
        private System.Windows.Forms.Label lab_num;
        private System.Windows.Forms.Label lab_nom;
        private System.Windows.Forms.Label lab_prenom;
        private System.Windows.Forms.Label lab_nationalite;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}