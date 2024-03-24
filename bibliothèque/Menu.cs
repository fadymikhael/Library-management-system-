using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace bibliothèque
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void GenereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Liste_Genres frm = new Liste_Genres();
            frm.Show();
        }

        private void QuitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AuteursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_LiseAuteurs frm = new Form_LiseAuteurs();
            frm.Show();
        }

        private void BasesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PréteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            liste_pret frm = new liste_pret();
            frm.Show();
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void AdherenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list_adherent frm = new list_adherent();
            frm.Show();
        }

        private void LivresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            liste_livres frm = new liste_livres();
            frm.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
