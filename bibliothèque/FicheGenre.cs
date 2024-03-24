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
    public partial class FicheGenre : Form
    {

        private MySqlCommand maRequete;
        private MySqlDataReader monReader;
        private int numGenre;
        public FicheGenre(bool modification, int num)
        {
            InitializeComponent();
            numGenre = num;

            try
            {
                connection.MaConnection.Open();
                maRequete = connection.MaConnection.CreateCommand();
                maRequete.CommandText = "select * from genre where num=@paramNum";
                maRequete.Prepare();
                maRequete.Parameters.AddWithValue("@paramNum", num);
                monReader = maRequete.ExecuteReader();
                if (monReader.Read())
                {
                    txt_numgenre.Text = num.ToString();
                    txt_genre.Text = monReader["libelle"].ToString();
                }

                else
                {
                    MessageBox.Show("erreur : genre introuvable !");
                }
                if (modification == false)
                {
                    txt_genre.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                monReader.Close();
                connection.MaConnection.Close();
            }

        }
        private void FicheGenre_Load(object sender, EventArgs e)
        {

        }

        private void Btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_valider_Click(object sender, EventArgs e)
        {
            if (ControleSaisises()==true)
            {
                maRequete.CommandText = "update genre set " +
                   "libelle=@paramLibelle";
                maRequete.Parameters.Clear();
                maRequete.Parameters.AddWithValue("@paramLibelle", txt_genre.Text);
                maRequete.Parameters.AddWithValue("@paramNum", numGenre);

                try
                {
                    connection.MaConnection.Open();
                    int resulta = maRequete.ExecuteNonQuery();
                    if (resulta > 0)
                    {
                        MessageBox.Show("Le genre a été mis a jour.");

                    }
                    else
                    {
                        MessageBox.Show("une erreur s'est produite le genre n'a pas été mis a jour");

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    throw;
                }
                finally
                {
                    connection.MaConnection.Close();
                    this.Close();
                }

            }

        }
        private bool ControleSaisises()
        {
            bool controle = true;
            if (txt_genre.Text == "")
            {
                MessageBox.Show("vous devez saisir un genre");
                controle = false;
            }
            return controle;

        }


    }
}
