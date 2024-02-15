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

namespace ProjetHygiene
{
    public partial class ConnexionUsers : Form
    {
        public ConnexionUsers()
        {
            InitializeComponent();
        }

        private void btnConnexion2_Click(object sender, EventArgs e)
        {
           
            //recuperer les valeurs des champs du formulaire
            
            UsersBLL usr = new UsersBLL();
            usr.nom = txtConNom.Text;
            usr.password = txtConMdp.Text;
            UserDAL da = new UserDAL();
            //string password = da.GetpasswordFormDatabase(usr.username);

            bool verify = da.loginUser(usr);
            //MessageBox.Show(""+verify);
            if (verify == true)
            {
                MessageBox.Show("Connection bien Etablie", "CONNEXION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Signalement pd = new Signalement(); ;
                pd.Show(); 
                this.Hide();
            }
            else if (txtConMdp.Text != txtConCmdp.Text)
            {
                MessageBox.Show("Les mots de passe ne sont pas identiques", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect", "CONNEXION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void gunaCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (gunaCheckBox1.Checked)
            {
                gunaCheckBox1.Text = "Masque le mot de passe";
                txtConMdp.PasswordChar = '\0';
                txtConCmdp.PasswordChar='\0';

            }
            else
            {
                gunaCheckBox1.Text = "Afficher le mot de passe";
               txtConMdp.PasswordChar = '*';
                txtConCmdp.PasswordChar='*';
            }
        }
        }
        }
    

