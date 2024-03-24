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
    public partial class Liste_Genres : Form
    {
        private MySqlCommand maRequete;
        private MySqlDataReader monReader;
        public Liste_Genres()
        {
            InitializeComponent();
            RemplirListe();

        }

        private void RemplirListe()
        {
            try
            {
                dgv_listegenres.Rows.Clear();
                connection.MaConnection.Open();
                maRequete = connection.MaConnection.CreateCommand();
                maRequete.CommandText = "select * from genre ";
                monReader = maRequete.ExecuteReader();
                while (monReader.Read())
                {
                    dgv_listegenres.Rows.Add(
                        monReader["num"].ToString(),
                        monReader["libelle"].ToString()
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

        private void Liste_Genres_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_affichergenre_Click(object sender, EventArgs e)
        {
            int element = Convert.ToInt16(dgv_listegenres.SelectedRows[0].Cells[0].Value.ToString());
            FicheGenre frm = new FicheGenre(false, element);
            frm.Show();
        }

        private void Btn_modifiergenre_Click(object sender, EventArgs e)
        {
            int element = Convert.ToInt16(dgv_listegenres.SelectedRows[0].Cells[0].Value.ToString());
            FicheGenre frm = new FicheGenre(true, element);
            frm.Show();
            RemplirListe();
            dgv_listegenres.Refresh();
        }
    }
}
