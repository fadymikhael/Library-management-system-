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
    public partial class liste_pret : Form
    {

        private MySqlCommand maRequete;
        private MySqlDataReader monReader;

        public liste_pret()
        {
            InitializeComponent();
            RemplirListe();

        }

        private void RemplirListe()
        {
            try
            {
                dgv_liste_pret.Rows.Clear();
                connection.MaConnection.Open();
                maRequete = connection.MaConnection.CreateCommand();
                maRequete.CommandText = "select * from pret";
                monReader = maRequete.ExecuteReader();
                while (monReader.Read())
                {
                    dgv_liste_pret.Rows.Add(
                        monReader["num"].ToString(),
                        monReader["numLivre"].ToString(),
                        monReader["numAdherent"].ToString(),
                        monReader["datePret"].ToString(),
                        monReader["dateRetourPrevue"].ToString(),
                        monReader["dateRetourReelle"].ToString()
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


        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
