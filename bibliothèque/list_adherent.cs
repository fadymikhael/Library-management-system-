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
    public partial class list_adherent : Form
    {

        private MySqlCommand maRequete;
        private MySqlDataReader monReader;

        public list_adherent()
        {
            InitializeComponent();
            RemplirListe();

        }
        private void RemplirListe()
        {
            try
            {
                dgv_list_aderent.Rows.Clear();
                connection.MaConnection.Open();
                maRequete = connection.MaConnection.CreateCommand();
                maRequete.CommandText = "select * from adherent ";
                monReader = maRequete.ExecuteReader();
                while (monReader.Read())
                {
                    dgv_list_aderent.Rows.Add(
                        monReader["num"].ToString(),
                        monReader["nom"].ToString(),
                        monReader["prenom"].ToString(),
                        monReader["adrRue"].ToString(),
                        monReader["adrCP"].ToString(),
                        monReader["adrVille"].ToString(),
                        monReader["tel"].ToString(),
                        monReader["mel"].ToString()
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

        private void List_adherent_Load(object sender, EventArgs e)
        {

        }
    }
}
