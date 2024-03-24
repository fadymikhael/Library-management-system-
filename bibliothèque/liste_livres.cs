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
    public partial class liste_livres : Form
    {

        private MySqlCommand maRequete;
        private MySqlDataReader monReader;

        public liste_livres()
        {
            InitializeComponent();
            RemplirListe();

        }

        private void RemplirListe()
        {
            try
            {
                dgv_listelivres.Rows.Clear();
                connection.MaConnection.Open();
                maRequete = connection.MaConnection.CreateCommand();
                maRequete.CommandText = "select * from livre";
                monReader = maRequete.ExecuteReader();
                while (monReader.Read())
                {
                    dgv_listelivres.Rows.Add(
                        monReader["num"].ToString(),
                        monReader["ISBN"].ToString(),
                        monReader["titre"].ToString(),
                        monReader["prix"].ToString(),
                        monReader["editeur"].ToString(),
                        monReader["annee"].ToString(),
                        monReader["langue"].ToString(),
                        monReader["numAuteur"].ToString(),
                        monReader["numGenre"].ToString()
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

        private void Dgv_liste_livres_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
