using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetHygiene
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void BtnConnnect_Click(object sender, EventArgs e)
        {
            ChoixConnexion cc = new ChoixConnexion();
            cc.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChoixConnexion cc = new ChoixConnexion();
            cc.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConnexionUsers cu = new ConnexionUsers();
            cu.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Signalement s = new Signalement();
            s.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Equipe ep = new Equipe();
            ep.Show();
            this.Hide();
        }
    }
}
