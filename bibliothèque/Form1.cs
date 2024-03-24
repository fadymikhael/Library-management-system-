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
    public partial class Form_LiseAuteurs : Form
    {

        private MySqlCommand maRequete;
        private MySqlDataReader monReader;
        public Form_LiseAuteurs()
        {
            InitializeComponent();
            RemplirListe();

        }

        private void RemplirListe()
        {
            RemplirListe(monReader);
        }

        private void RemplirListe(MySqlDataReader monReader)
        {
            try
            {
                dgv_listeAuteurs.Rows.Clear();
                connection.MaConnection.Open();
                maRequete = connection.MaConnection.CreateCommand();
                maRequete.CommandText = "select * from auteur order by nom";
                monReader = maRequete.ExecuteReader();
                while (monReader.Read())
                {
                    dgv_listeAuteurs.Rows.Add(
                        monReader["num"].ToString(),
                        monReader["nom"].ToString(),
                        monReader["prenom"].ToString(),
                        monReader["nationalite"].ToString()
                        );
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("erreur :" + ex.Message);
            }

            finally
            {
                monReader.Close();
                connection.MaConnection.Close();
            }
        }

        private void btn_affiche_Click(object sender, EventArgs e)
        {
           int element = Convert.ToInt16( dgv_listeAuteurs.SelectedRows[0].Cells[0].Value.ToString());
            FicheAuteur frm = new FicheAuteur(false, element);
            frm.Show();
        }

        private void Form_LiseAuteurs_Load(object sender, EventArgs e)
        {

        }

        private void btn_modifiction_Click(object sender, EventArgs e)
        {
            int element = Convert.ToInt16(dgv_listeAuteurs.SelectedRows[0].Cells[0].Value.ToString());
            FicheAuteur frm = new FicheAuteur(true, element);
            frm.Show();
            RemplirListe();
            dgv_listeAuteurs.Refresh();
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {

        }

        private void Dgv_listeAuteurs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
