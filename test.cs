using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using System.Data.SqlClient;
using System.Configuration;
namespace ProjetHygiene
    
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            afficher();
        }


        public void afficher()
        {

            // Connexion à la base de données
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {

                connection.Open();

                // Exécution de la requête SQL
                string query = "SELECT * FROM Membre";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                // Création dynamique des contrôles
                int i = 0;
                while (reader.Read())
                {
                    // Création d'un nouveau GroupBox
                    GroupBox groupBox = new GroupBox();
                    groupBox.Name = "groupBox" + i;
                    groupBox.Text = "GroupBox " + i;
                    groupBox.Size = new Size(200, 50);
                    groupBox.Location = new Point(10, i * 60);

                    // Création d'un nouveau Label
                    Label label = new Label();
                    label.Name = "label" + i;
                    label.Text = reader["nom de la colonne"].ToString();
                    label.Location = new Point(10, 20);

                    // Ajout du Label au GroupBox
                    groupBox.Controls.Add(label);

                    // Ajout du GroupBox au formulaire
                    this.Controls.Add(groupBox);

                    i++;
                }

                // Fermeture de la connexion
                connection.Close();
            }
        }
    }
}
