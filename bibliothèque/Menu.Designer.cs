namespace bibliothèque
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Form_ListeAuteurs = new System.Windows.Forms.ToolStripMenuItem();
            this.genereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adherenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prétsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem,
            this.basesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(511, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1_ItemClicked);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.QuitterToolStripMenuItem_Click);
            // 
            // basesToolStripMenuItem
            // 
            this.basesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Form_ListeAuteurs,
            this.genereToolStripMenuItem,
            this.adherenToolStripMenuItem,
            this.livresToolStripMenuItem,
            this.prétsToolStripMenuItem});
            this.basesToolStripMenuItem.Name = "basesToolStripMenuItem";
            this.basesToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.basesToolStripMenuItem.Text = "Bases";
            this.basesToolStripMenuItem.Click += new System.EventHandler(this.BasesToolStripMenuItem_Click);
            // 
            // Form_ListeAuteurs
            // 
            this.Form_ListeAuteurs.Name = "Form_ListeAuteurs";
            this.Form_ListeAuteurs.Size = new System.Drawing.Size(128, 22);
            this.Form_ListeAuteurs.Text = "Auteurs";
            this.Form_ListeAuteurs.Click += new System.EventHandler(this.AuteursToolStripMenuItem_Click);
            // 
            // genereToolStripMenuItem
            // 
            this.genereToolStripMenuItem.Name = "genereToolStripMenuItem";
            this.genereToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.genereToolStripMenuItem.Text = "Genres";
            this.genereToolStripMenuItem.Click += new System.EventHandler(this.GenereToolStripMenuItem_Click);
            // 
            // adherenToolStripMenuItem
            // 
            this.adherenToolStripMenuItem.Name = "adherenToolStripMenuItem";
            this.adherenToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.adherenToolStripMenuItem.Text = "Adhérents";
            this.adherenToolStripMenuItem.Click += new System.EventHandler(this.AdherenToolStripMenuItem_Click);
            // 
            // livresToolStripMenuItem
            // 
            this.livresToolStripMenuItem.Name = "livresToolStripMenuItem";
            this.livresToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.livresToolStripMenuItem.Text = "Livres";
            this.livresToolStripMenuItem.Click += new System.EventHandler(this.LivresToolStripMenuItem_Click);
            // 
            // prétsToolStripMenuItem
            // 
            this.prétsToolStripMenuItem.Name = "prétsToolStripMenuItem";
            this.prétsToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.prétsToolStripMenuItem.Text = "Préts";
            this.prétsToolStripMenuItem.Click += new System.EventHandler(this.PréteToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(511, 365);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Form_ListeAuteurs;
        private System.Windows.Forms.ToolStripMenuItem genereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adherenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prétsToolStripMenuItem;
    }
}