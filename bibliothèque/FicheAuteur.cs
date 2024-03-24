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
    public partial class FicheAuteur : Form
    {

        private MySqlCommand maRequete;
        private MySqlDataReader monReader;
        private int numAuteur;

        public FicheAuteur(bool modification, int num)
        {
            InitializeComponent();
            numAuteur = num;

            try
            {
                connection.MaConnection.Open();
                maRequete = connection.MaConnection.CreateCommand();
                maRequete.CommandText = "select * from auteur where num=@paramNum";
                maRequete.Prepare();
                maRequete.Parameters.AddWithValue("@paramNum",num);
                monReader = maRequete.ExecuteReader();
                if (monReader.Read())
                {
                    txt_num.Text = num.ToString();
                    txt_nom.Text = monReader["nom"].ToString();
                    txt_prenom.Text = monReader["prenom"].ToString();
                    txt_nationalite.Text = monReader["nationalite"].ToString();
                }

                else
                {
                    MessageBox.Show("erreur : Auteur introuvable !");
                }
                if (modification == false)
                {
                    txt_nom.Enabled = false;
                    txt_prenom.Enabled = false;
                    txt_nationalite.Enabled = false;
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

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void FicheAuteur_Load(object sender, EventArgs e)
        {

        }

        private void Txt_num_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_nom_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lab_num_Click(object sender, EventArgs e)
        {

        }

        private void Lab_prenom_Click(object sender, EventArgs e)
        {

        }

        private void Btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            if (ControleSaisises()==true)
            {
                maRequete.CommandText ="update auteur set " +
                    "nom=@paramNom, prenom=@paramPrenom, nationalite=@paramNationlite where num=@paramNum";
                maRequete.Parameters.Clear();
                maRequete.Parameters.AddWithValue("@paramNom", txt_nom.Text);
                maRequete.Parameters.AddWithValue("@paramPrenom", txt_prenom.Text);
                maRequete.Parameters.AddWithValue("@paramNationlite", txt_nationalite.Text);
                maRequete.Parameters.AddWithValue("@paramNum", numAuteur);

                try
                {
                    connection.MaConnection.Open();
                    int resulta = maRequete.ExecuteNonQuery();
                    if (resulta>0)
                    {
                        MessageBox.Show("L'auteur a été mis a jour.");
                    }
                    else
                    {
                        MessageBox.Show("une erreur s'est produite l'auteur n'a pas été mis a jour");
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
            if (txt_nom.Text == "")
            {
                    MessageBox.Show("vous devez saisir un nom");
                        controle = false;
            }

            if (txt_prenom.Text == "")
            {
                MessageBox.Show("vous devez saisir un prenom");
                controle = false;
            }

            if (txt_nationalite.Text == "")
            {
                MessageBox.Show("vous devez saisir un nationalité");
                controle = false;
            }
            return controle;

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
