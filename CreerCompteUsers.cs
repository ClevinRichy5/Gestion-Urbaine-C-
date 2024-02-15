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
    public partial class CreerCompteUsers : Form
    {
        public CreerCompteUsers()
        {
            InitializeComponent();
        }

        public void clearFrom()
        {
            txtNom.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtPrenom.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }

        private void CreerCompteUsers_Click(object sender, EventArgs e)
        {

        }

        

        private void btnCreerCompte_Click(object sender, EventArgs e)
        {
            UsersBLL usr = new  UsersBLL();
            UserDAL da = new UserDAL();
            usr.nom = txtNom.Text;
            usr.prenom = txtPrenom.Text;
            usr.email = txtEmail.Text;
            usr.password = txtPassword.Text;

            if (string.IsNullOrEmpty(txtNom.Text) || string.IsNullOrEmpty(txtPrenom.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Tout les champs ne sont pas correctement remplie", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool userExist = da.userexiste(usr);
                //MessageBox.Show(""+userExist);
                if (userExist == true)
                {
                    //int req = da.userinsert(usr);
                    //MessageBox.Show("" + req);
                    MessageBox.Show("Se nom d'utilisateur existe deja dans la base de donnes", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    da.userinsert(usr);
                    clearFrom();
                    //MessageBox.Show(""+req);
                    MessageBox.Show("votre Compte a ete creer avec success", "Nouveau Compte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }

        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            ConnexionUsers cu = new  ConnexionUsers();
            cu.Show();
        }

        private void CreerCompteUsers_Load(object sender, EventArgs e)
        {

        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void txtPrenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtNom_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void gunaLabel2_Click_1(object sender, EventArgs e)
        {

        }

        private void txtPrenom_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtNom_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void btnSeConnecter_Click_1(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCreerCompte_Click_1(object sender, EventArgs e)
        {

        }

        private void gunaLabel2_Click_2(object sender, EventArgs e)
        {

        }

     
        private void txtPrenom_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void gunaLabel3_Click_1(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
